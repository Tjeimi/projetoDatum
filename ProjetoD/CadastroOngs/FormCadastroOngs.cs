using Models;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;
using static datumMQTT.Utils;

namespace CadastroOngs
{
    public partial class FormCadastroOngs : Form
    {
        public FormCadastroOngs()
        {
            InitializeComponent();
        }

        private async void BtnGravarOng_Click(object sender, EventArgs e)
        {
            var ong = new DadosONGModel();
            if (idOng.Text != "")
                ong.id = Convert.ToInt64(idOng.Text);
            ong.nome = tbNomeOng.Text;
            ong.endereco = tbEnderecoOng.Text;
            ong.fone = tbContatoOng.Text;
            ong.cidade = cbCidade.Text;
            ong.estado = cbEstado.Text;
            ong.email = tbEmail.Text;

            BasePacket pacote = new();
            pacote.dados = ong;
            pacote.serverName = "ServerPessoa";
            pacote.action = "Save";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarDados);

        }

        private void BtnEditarOng_Click(object sender, EventArgs e)
        {
            var ong = new Models.DadosONGModel();
            ong.id = int.Parse(idOng.Text);
            ong.nome = tbNomeOng.Text;
            ong.endereco = tbEnderecoOng.Text;
            ong.fone = tbContatoOng.Text;
            ong.cidade = cbCidade.Text;
            ong.estado = cbEstado.Text;
            ong.email = tbEmail.Text;
        }

        private void BtnApagarParceira_Click(object sender, EventArgs e)
        {
            var ong = new Models.DadosONGModel();
            ong.id = int.Parse(idOng.Text);
        }

        private void BtnGravarParceira_Click(object sender, EventArgs e)
        {
            var ong = new Models.ParceriasONGModel();
            ong.id = int.Parse(idOng.Text);
            ong.idcidadeparceria = int.Parse(cbCidadesParceiras.Text);
        }

        void RetornarDados(string r)
        {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200)
                {
                    var ong = (DadosONGModel)resposta.dados!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga o id na tela
                    idOng.Text = ong!.id.ToString();
                }
                else
                {
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