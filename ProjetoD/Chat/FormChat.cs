using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace Chat {
    public partial class FormChat : Form {
        public FormChat() {
            InitializeComponent();
        }

        #region LOAD
        private async void FormChat_LoadAsync(object sender, EventArgs e) {
            await datumMQTT.Utils.EscutarAsync("datum/chatTopic", PrintToChat);
        }

        #endregion

        #region METODOS

        void PrintToChat(string mensagem) {
            Debug.WriteLine(mensagem);
            var resposta = JsonSerializer.Deserialize<ChatModel>(mensagem);
            //Fica em outra thread esperando mensagens, então quando chega, tem que "invocar" a thread com a UI 
            //para que não de erro na hora de imprimir para o campo de chat
            MethodInvoker methodInvokerDelegate = delegate () {
                //aqui dentro lida diretamente com a UI de forma segura
                tbChat.AppendText($"{resposta!.usuario}: {resposta!.mensagem}\r\n");
            };

            //boilerplate para invocar a thread da UI e não dar problemas
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        #endregion

        #region EVENTOS

        private async void btEnviar_ClickAsync(object sender, EventArgs e) {
            var msg = new ChatModel();
            msg.usuario = Environment.GetEnvironmentVariable("usuarionome");
            msg.mensagem = tbMensagemEnvio.Text;
            await datumMQTT.Utils.PublicarRespostaAsync("datum/chatTopic", msg);
            tbMensagemEnvio.Text = "";
            tbMensagemEnvio.Focus();
        }

        private void tbMensagemEnvio_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                btEnviar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region MODELO

        public class ChatModel {
            public string? usuario { get; set; }
            public string? mensagem { get; set; }
        }

        #endregion
    }
}