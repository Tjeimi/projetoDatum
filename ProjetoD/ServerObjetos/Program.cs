using System.Text;
using System.Text.Json;
using static datumMQTT.Utils;
using static DatumPostgreSQL.Utils;
using Models;

namespace ServerObjetos {
    public class ServerObjetos {
        static void Main(string[] args) {
            switch (args[0]) {
                case "Save":
                    Save(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
                case "BuscarObjetos":
                    BuscarObjetos(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
                case "Pesquisa":
                    Pesquisa(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
                case "BuscarMatch":
                    BuscarMatch(args[1]);
                    break;
                case "FazerMatch":
                    FazerMatch(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
                case "Delete":
                    Delete(Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
            }
        }

        private static async void FazerMatch(string topicoResposta, string dados) {
            try {
                var objeto = JsonSerializer.Deserialize<MatchObjetoModel>(dados);
                ObjetosMatchModel objDoando = new();
                objDoando.id = objeto!.idobjdoando;
                objDoando.doado = true;
                UpdateRegistro(objDoando!);

                ObjetosMatchModel objNecessidade = new();
                objNecessidade.id = objeto!.idobjnecessidade;
                objNecessidade.doado = true;
                UpdateRegistro(objNecessidade!);

                //retorna os dados
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 200;
                bpr.mensagem = $"Sucesso {DateTime.Now.ToString()}";
                await PublicarRespostaAsync(topicoResposta, bpr);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 500;
                bpr.mensagem = "Erro: " + ex.Message;
                await PublicarRespostaAsync(topicoResposta, bpr);
            }
        }

        static async void Save(string topicoResposta, string dados) {
            try {
                var objeto = JsonSerializer.Deserialize<ObjetosModel>(dados);
                if (objeto!.id == null) {
                    objeto!.id = InserirRegistro(objeto!);
                } else {
                    UpdateRegistro(objeto!);
                }
                //retorna os dados
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 200;
                bpr.mensagem = $"Sucesso {DateTime.Now.ToString()}";
                bpr.dados = JsonSerializer.Serialize(objeto);
                await PublicarRespostaAsync(topicoResposta, bpr);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 500;
                bpr.mensagem = "Erro: " + ex.Message;
                await PublicarRespostaAsync(topicoResposta, bpr);
            }
        }

        static async void BuscarObjetos(string topicoResposta, string dados) {
            try {
                long? idpessoa = JsonSerializer.Deserialize<ObjetosModel>(dados)!.idpessoa!;
                var ObjetosList = QueryLivre<ObjetosModel>($"SELECT * FROM objetos WHERE idpessoa = {idpessoa} ORDER BY id DESC");
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 200;
                bpr.mensagem = "Sucesso";
                bpr.dados = JsonSerializer.Serialize(ObjetosList);
                await PublicarRespostaAsync(topicoResposta, bpr);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 500;
                bpr.mensagem = "Erro: " + ex.Message;
                await PublicarRespostaAsync(topicoResposta, bpr);
            }
        }

        static async void Pesquisa(string topicoResposta, string dados) {
            try {
                var pesquisa = JsonSerializer.Deserialize<PesquisaObjetoReqModel>(dados)!;
                var ObjetosList = QueryLivre<PesquisaObjetoRetModel>($"select idpessoa, objeto, categoria, doacao, necessidade from objetos where categoria LIKE '%{pesquisa.categoria}%' and objeto like '%{pesquisa.objeto}%' LIMIT 100");
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 200;
                bpr.mensagem = "Sucesso";
                bpr.dados = JsonSerializer.Serialize(ObjetosList);
                await PublicarRespostaAsync(topicoResposta, bpr);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 500;
                bpr.mensagem = "Erro: " + ex.Message;
                await PublicarRespostaAsync(topicoResposta, bpr);
            }
        }

        static async void BuscarMatch(string topicoResposta) {
            try { 
                var ObjetosList = QueryLivre<MatchObjetoModel>(@$"
                SELECT pd.nome AS nomedoando
                      ,odoando.objeto AS objdoando
                      ,pn.nome AS nomenecessidade
                      ,onecessidade.objeto AS objnecessidade
                      ,odoando.id AS idobjdoando
                      ,onecessidade.id AS idobjnecessidade
                      ,odoando.categoria AS categoria
                FROM objetos odoando 
                JOIN objetos onecessidade on onecessidade.categoria = odoando.categoria
                JOIN pessoas pd ON pd.id = odoando.idpessoa
                JOIN pessoas pn ON pn.id = onecessidade.idpessoa
                WHERE odoando.doacao = TRUE 
                AND onecessidade.necessidade = TRUE
				AND odoando.doado = FALSE
				AND onecessidade.doado = FALSE;");
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 200;
                bpr.mensagem = "Sucesso";
                bpr.dados = JsonSerializer.Serialize(ObjetosList);
                await PublicarRespostaAsync(topicoResposta, bpr);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 500;
                bpr.mensagem = "Erro: " + ex.Message;
                await PublicarRespostaAsync(topicoResposta, bpr);
            }
        }

        static void Delete(string dados) {

        }
    }
}