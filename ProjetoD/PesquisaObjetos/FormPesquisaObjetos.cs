using Models;
using System.Text.Json;
using static datumMQTT.Utils;
namespace PesquisaObjetos {
    public partial class FormPesquisaObjetos : Form {
        public FormPesquisaObjetos() {
            InitializeComponent();
        }

        private async void BtnPesquisarObjetos_Click(object sender, EventArgs e) {
            PesquisaObjetoReqModel p = new();
            p.categoria = cbCategorias.Text; 
            p.descricao = tbDescricao.Text;

            BasePacket pacote = new();
            pacote.dados = p;
            pacote.serverName = "ServerObjetos";
            pacote.action = "Pesquisa";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarPesquisa);
        }

        private void RetornarPesquisa(string resultado) {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(resultado);
                if (resposta!.codigo == 200) {
                    var objetos = JsonSerializer.Deserialize<List<PesquisaObjetoRetModel>>(resposta.dados!)!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga os resultados na tela
                    DgvPesquisaObjetos.Rows.Clear();
                    foreach (var p in objetos) {
                        var index = DgvPesquisaObjetos.Rows.Add();
                        var row = DgvPesquisaObjetos.Rows[index].Cells;
                        row["idPessoa"].Value = p.idpessoa;
                        row["categoria"].Value = p.categoria;
                        row["descricao"].Value = p.descricao;
                        row["tipo"].Value = p.tipo;
                    }
                } else {
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkRed;
                    tbResultado.Text = resposta.mensagem;
                }
            };
            //boilerplate para invocar a thread da UI e não dar problemas
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }
    }
}