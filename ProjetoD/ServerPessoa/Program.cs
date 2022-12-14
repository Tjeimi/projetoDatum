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
            case "BuscarRegistros":
                BuscarRegistros(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
            case "Select":
                Select(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
            case "Delete":
                Delete(Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
        }
    }

    static async void Save(string topicoResposta, string dados) {
        try {
            var pessoa = JsonSerializer.Deserialize<PessoasModel>(dados);
            if (pessoa!.id == null) {
                pessoa!.id = InserirRegistro(pessoa!);
            } else {
                UpdateRegistro(pessoa!);
            }
            //retorna os dados
            Console.WriteLine("enviando a resposta");
            var bpr = new BasePacketResposta();
            bpr.codigo = 200;
            bpr.mensagem = $"Sucesso {DateTime.Now.ToString()}";
            bpr.dados = JsonSerializer.Serialize(pessoa);
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

    static async void BuscarRegistros(string topicoResposta, string dados) {
        try {
            string nome = JsonSerializer.Deserialize<PessoasModel>(dados)!.nome!;
            var pessoasList = QueryLivre<PessoasModel>($"SELECT * FROM pessoas WHERE nome LIKE '%{nome}%' ORDER BY id DESC");
            Console.WriteLine("enviando a resposta");
            var bpr = new BasePacketResposta();
            bpr.codigo = 200;
            bpr.mensagem = "Sucesso";
            bpr.dados = JsonSerializer.Serialize(pessoasList);
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

    static async void Select(string topicoResposta, string dados) {
        try {
            var id = JsonSerializer.Deserialize<PessoasModel>(dados)!.id!;
            var pessoasList = QueryLivre<PessoasModel>($"SELECT * FROM pessoas WHERE id = {id} LIMIT 1");
            Console.WriteLine("enviando a resposta");
            var bpr = new BasePacketResposta();
            bpr.codigo = 200;
            bpr.mensagem = "Sucesso";
            bpr.dados = JsonSerializer.Serialize(pessoasList[0]);
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