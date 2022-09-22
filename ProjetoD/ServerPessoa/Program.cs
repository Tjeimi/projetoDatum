using System.Text;
using System.Text.Json;
using Models;
using static datumMQTT.Utils;

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
            Console.WriteLine(dados);
            var d = JsonSerializer.Deserialize<PessoasModel>(dados);
            //Console.WriteLine(DatumPostgreSQL.Utils.CreateInsertQuery(d!));
            //Console.WriteLine(d!.nome);
            //DatumPostgreSQL.Utils.InserirRegistro(d!);
            Console.WriteLine(topicoResposta);
            d!.endereco = "aadeucerto";
            await PublicarRespostaAsync(topicoResposta, d);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    static void Delete(string dados) {

    }
}