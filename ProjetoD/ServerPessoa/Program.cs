using System.Text;
using System.Text.Json;
using Models;
using static datumMQTT.Utils;
using static DatumPostgreSQL.Utils;

public class ServerPessoa {
    static void Main(string[] args) {
        switch (args[0]) {
            case "Insert":
                Insert(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
            case "Delete":
                Delete(Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
        }
    }

    static async void Insert(string topicoResposta, string dados) {
        try {
            var d = JsonSerializer.Deserialize<PessoasModel>(dados);
            try {
                Console.WriteLine(CreateInsertQuery(d!));
                InserirRegistro(d!);
            } catch (Exception ex) {
                Console.WriteLine(ex);
                //limpa para não retornar nenhum dado
                d = new();
            }
            //retorna os dados
            Console.WriteLine("enviando a resposta");
            await PublicarRespostaAsync(topicoResposta, d);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    static void Delete(string dados) {

    }
}