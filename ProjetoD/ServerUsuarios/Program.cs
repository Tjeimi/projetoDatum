using System.Text;
using System.Text.Json;
using Models;
using static datumMQTT.Utils;
using static DatumPostgreSQL.Utils;

public class ServerUsuarios {
    static void Main(string[] args) {
        switch (args[0]) {
            case "Save":
                Save(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
            case "Login":
                Login(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
            case "BuscarRegistros":
                BuscarRegistros(args[1], Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
            case "Delete":
                Delete(Encoding.UTF8.GetString(Convert.FromBase64String(args[2])));
                break;
        }
    }

    static async void Save(string topicoResposta, string dados) {
        try {
            var usuario = JsonSerializer.Deserialize<UsuariosModel>(dados);
            if (usuario!.id == null) {
                usuario!.id = InserirRegistro(usuario!);
            } else {
                UpdateRegistro(usuario!);
            }
            //retorna os dados
            Console.WriteLine("enviando a resposta");
            var bpr = new BasePacketResposta();
            bpr.codigo = 200;
            bpr.mensagem = $"Sucesso {DateTime.Now.ToString()}";
            bpr.dados = JsonSerializer.Serialize(usuario);
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

    static async void Login(string topicoResposta, string dados) {
        try {
            var usuario = JsonSerializer.Deserialize<UsuariosModel>(dados);
            var usuariosList = QueryLivre<UsuariosLoginModel>($"SELECT u.id, u.idong, u.nome AS usuarionome, o.nome AS ongnome FROM usuarios u LEFT JOIN ongs o ON u.idong = o.id WHERE u.username = '{usuario.username}' AND u.password = '{usuario.password}' LIMIT 1");
            if (usuariosList.Count > 0) {
                var bpr = new BasePacketResposta();
                bpr.codigo = 200;
                bpr.mensagem = "Sucesso";
                bpr.dados = JsonSerializer.Serialize(usuariosList);
                await PublicarRespostaAsync(topicoResposta, bpr);
            } else {
                Console.WriteLine("enviando a resposta");
                var bpr = new BasePacketResposta();
                bpr.codigo = 401;
                bpr.mensagem = "N�o autorizado";
                await PublicarRespostaAsync(topicoResposta, bpr);
            }
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
            string nome = JsonSerializer.Deserialize<UsuariosModel>(dados)!.nome!;
            var usuariosList = QueryLivre<UsuariosModel>($"SELECT * FROM usuarios WHERE nome LIKE '%{nome}%' ORDER BY id DESC");
            Console.WriteLine("enviando a resposta");
            var bpr = new BasePacketResposta();
            bpr.codigo = 200;
            bpr.mensagem = "Sucesso";
            bpr.dados = JsonSerializer.Serialize(usuariosList);
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