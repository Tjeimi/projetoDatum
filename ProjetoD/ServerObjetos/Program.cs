using System.Text;
using System.Text.Json;
using Models;
using static datumMQTT.Utils;
using static DatumPostgreSQL.Utils;

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
                case "Delete":
                    Delete(Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
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

        static void Delete(string dados) {

        }
    }
}