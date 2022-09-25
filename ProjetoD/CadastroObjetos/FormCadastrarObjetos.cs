using Models;
using System.Text.Json;
using System.Windows.Forms;
using static datumMQTT.Utils;

namespace CadastroObjetos {
    public partial class FormCadastrarObjetos : Form {
        public FormCadastrarObjetos() {
            InitializeComponent();
        }

        private async void BtnGravarObjeto_Click(object sender, EventArgs e) {
            var objeto = new ObjetosModel();
            if (tbIdObjeto.Text != "")
                objeto.id = Convert.ToInt64(tbIdObjeto.Text);
            objeto.objeto = tbObjeto.Text;
            if (cbCategorias.Text != "")
                objeto.idcategoria = Convert.ToInt64(cbCategorias.Text);
            objeto.descricao = tbDescricao.Text;
            //objeto.imagem = pbImagem.Text; //ver como as imagens serão salvar -- exibe imagens carregadas
            if (chbDoação.Checked == true) {
                objeto.tipo = "doacao";
            } else if (chbNecessidade.Checked == true) {
                objeto.tipo = "necessidade";
            }
            BasePacket pacote = new();
            pacote.dados = objeto;
            pacote.serverName = "ServerObjetos";
            pacote.action = "Save";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarDados);
        }

        private void BtnCarregarImagem_Click(object sender, EventArgs e) {
            using (OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.Title = "Abrir Imagem";
                dlg.Filter = "jpeg files (*.jpeg)|*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK) {
                    pbImagem.Image = new Bitmap(dlg.FileName);
                }
            }

        }

        private void BtnApagarImagem_Click(object sender, EventArgs e) {
            pbImagem.Image.Dispose();
        }

        void RetornarDados(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    var objeto = JsonSerializer.Deserialize<ObjetosModel>(resposta.dados!)!;
                    tbIdObjeto.Text = objeto.id.ToString();
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga o id na tela
                    tbIdObjeto.Text = objeto!.id.ToString();
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