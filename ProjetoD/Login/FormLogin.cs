using Models;
using static serverUtils.Utils;
using static datumMQTT.Utils;
using System.Text.Json;
using Main;
using System.Diagnostics;

namespace Login {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e) {
            // login

            var usuario = new UsuariosModel();
            usuario.username = tbUsuario.Text;
            usuario.password = GetSha256(tbSenha.Text);
            Debug.WriteLine(usuario.password);

            BasePacket pacote = new();
            pacote.dados = usuario;
            pacote.serverName = "ServerUsuarios";
            pacote.action = "Login";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarLogin);
        }

        void RetornarLogin(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    var r = JsonSerializer.Deserialize<List<UsuariosLoginModel>>(resposta.dados!);
                    Environment.SetEnvironmentVariable("idong", r[0].idong.ToString());
                    Environment.SetEnvironmentVariable("ongnome", r[0].ongnome);
                    Environment.SetEnvironmentVariable("usuarionome", r[0].usuarionome);
                    this.Hide();
                    FormPrincipal form = new();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                } else {
                    MessageBox.Show("Por favor tente novamente", "Usuário ou senha inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(resposta.mensagem);
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