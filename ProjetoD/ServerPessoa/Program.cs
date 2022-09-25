using System.Text;
using System.Text.Json;
using Models;
using static datumMQTT.Utils;
using static DatumPostgreSQL.Utils;

    public class ServerPessoa {
        static void Main(string[] args) {
            switch (args[0]) {
                case "Save":
                    Save(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
                case "Delete":
                    Delete(Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                    break;
            }
        }

        static async void Save(string topicoResposta, string dados) {
            try {
                var d = JsonSerializer.Deserialize<PessoasModel>(dados);
                if (d.id == null) {
                    InserirRegistro(d!);
                } else {
                    UpdateRegistro(d!);
                }
                //retorna os dados
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 200;
                bpr.mensagem = "sucesso";
                bpr.dados = d;
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