using System.Text;
using System.Text.Json;

public class ServerPessoa {
    static void Main(string[] args) {
        switch (args[0]) {
            case "Save":
                Save(Encoding.UTF8.GetString(Convert.FromBase64String(args[1])));
                break;
            case "Delete":
                Delete(Encoding.UTF8.GetString(Convert.FromBase64String(args[1])));
                break;
        }
    }

    static void Save(string dados) {
        try {
            Console.WriteLine(dados);
            var d = JsonSerializer.Deserialize<Models.PessoasModel>(dados);
            DatumPostgreSQL.Utils.InserirRegistro(d!);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    static void Delete(string dados) {

    }
}