using Models;
using System.Text.Json;
using System.Windows.Forms;
using static datumMQTT.Utils;

namespace CadastroObjetos {
    public partial class FormCadastrarObjetos : Form {
        long? idPessoaTemp;
        public FormCadastrarObjetos() {
            InitializeComponent();
        }
        public FormCadastrarObjetos(long? idPessoaExt) {
            InitializeComponent();
            idPessoaTemp = idPessoaExt;
        }

        private async void BtnGravarObjeto_Click(object sender, EventArgs e) {
            var objeto = new ObjetosModel();
            if (tbIdObjeto.Text != "")
                objeto.id = Convert.ToInt64(tbIdObjeto.Text);
            if (tbIdOng.Text != "")
                objeto.idong = Convert.ToInt64(tbIdOng.Text);
            if (tbIdPessoa.Text != "")
                objeto.idpessoa = Convert.ToInt64(tbIdPessoa.Text);
            objeto.objeto = tbObjeto.Text;
            if (cbCategorias.Text != "")
                objeto.categoria = cbCategorias.Text;
            objeto.descricao = tbDescricao.Text;
            if (pbImagem.Image != null)
                objeto.imagem = ImageToByteArray(pbImagem.Image); //ver como as imagens serão salvas -- exibe imagens carregadas
            objeto.doacao = rbDoacao.Checked;
            objeto.necessidade = rbNecessidade.Checked;
            objeto.doado = chbDoado.Checked;

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

        public byte[] ImageToByteArray(Image imageIn) {
            using (var ms = new MemoryStream()) {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] bytesArr) {
            using (MemoryStream memstr = new MemoryStream(bytesArr)) {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        void RetornarDados(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    var objeto = JsonSerializer.Deserialize<ObjetosModel>(resposta.dados!)!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga o id na tela
                    tbIdObjeto.Text = objeto!.id.ToString();
                    CarregarObjetos();
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

        private void FormCadastrarObjetos_Load(object sender, EventArgs e) {
            tbIdPessoa.Text = idPessoaTemp.ToString();
            CarregarObjetos();
        }

        async void CarregarObjetos() {
            ObjetosModel objeto = new();
            objeto.idpessoa = Convert.ToInt64(tbIdPessoa.Text);

            BasePacket pacote = new();
            pacote.dados = objeto;
            pacote.serverName = "ServerObjetos";
            pacote.action = "BuscarObjetos";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarObjetos);
        }
        void RetornarObjetos(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    var objetos = JsonSerializer.Deserialize<List<ObjetosModel>>(resposta.dados!)!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga os objetos na tela
                    dgvObjHistorico.Rows.Clear();
                    foreach (var o in objetos) {
                        var index = dgvObjHistorico.Rows.Add();
                        var row = dgvObjHistorico.Rows[index].Cells;
                        row["id"].Value = o.id;
                        row["idPessoa"].Value = o.idpessoa;
                        row["idOng"].Value = o.idong;
                        row["objeto"].Value = o.objeto;
                        row["categoria"].Value = o.categoria;
                        row["descricao"].Value = o.descricao;
                        row["doado"].Value = o.doado;
                        row["doacao"].Value = o.doacao;
                        row["necessidade"].Value = o.necessidade;
                        row["imagem"].Value = o.imagem;
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

        private void btNovo_Click(object sender, EventArgs e) {
            chbDoado.Checked = false;
            tbIdObjeto.Text = "";
            tbIdOng.Text = "";
            tbObjeto.Text = "";
            cbCategorias.Text = "";
            tbDescricao.Text = "";
            pbImagem.Image.Dispose();
        }

        private void dgvObjHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;
            var row = dgvObjHistorico.Rows[e.RowIndex].Cells;
            tbIdPessoa.Text = row["idPessoa"].Value.ToString();
            tbIdObjeto.Text = row["id"].Value.ToString();
            if (row["imagem"].Value != null) {
                pbImagem.Image = ByteArrayToImage((byte[])row["imagem"].Value);
                //ByteArrayToImage
            }

        }
    }
}