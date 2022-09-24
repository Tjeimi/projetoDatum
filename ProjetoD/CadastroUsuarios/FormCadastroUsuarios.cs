using Models;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;
using static datumMQTT.Utils;

namespace CadastroUsuarios
{
    public partial class FormCadastroUsuarios : Form
    {
        public FormCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            // pesquisar usu�rio
        }

        private async void BtnGravarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new UsuariosModel();
            if (idUsuario.Text != "")
                usuario.id = int.Parse(idUsuario.Text);
            usuario.idong = int.Parse(idOng.Text);
            usuario.nome = tbNomeUsuario.Text;
            usuario.username = tbUsername.Text;
            usuario.password = tbSenha.Text;
            usuario.fone = tbContatoUsuario.Text;
            usuario.ativo = chbAtivo.Checked; //ver bool verdadeiro / falso

            BasePacket pacote = new();
            pacote.dados = usuario;
            pacote.serverName = "ServerPessoa";
            pacote.action = "Save";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarDados);
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new Models.UsuariosModel();
            usuario.id = int.Parse(idUsuario.Text);
            usuario.idong = int.Parse(idOng.Text);
            usuario.nome = tbNomeUsuario.Text;
            usuario.username = tbUsername.Text;
            usuario.password = tbSenha.Text;
            usuario.fone = tbContatoUsuario.Text;
            usuario.ativo = chbAtivo.Checked; //ver bool verdadeiro / falso
        }

        private void BtnInativarUsuario_Click(object sender, EventArgs e)
        {
            //quando clica no bot�o para desativar o usuario deve desabilitar a edi��o dos campos e setar no banco "0"
        }

        void RetornarDados(string r)
        {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200)
                {
                    var usuarios = (PessoasModel)resposta.dados!;
                    //s� para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga o id na tela
                    idUsuario.Text = usuarios!.id.ToString();
                }
                else
                {
                    //s� para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkRed;
                    tbResultado.Text = resposta.mensagem;
                }
            };
            //boilerplate para invocar a thread da UI e n�o dar problemas
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }
    }
}