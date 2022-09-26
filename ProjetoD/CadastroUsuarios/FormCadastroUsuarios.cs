using Models;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static serverUtils.Utils;
using static datumMQTT.Utils;

namespace CadastroUsuarios {
    public partial class FormCadastroUsuarios : Form {
        public FormCadastroUsuarios() {
            InitializeComponent();
        }

        #region EVENTOS
        
        private async void BtnPesquisar_Click(object sender, EventArgs e) {
            // pesquisar usuário
            // pesquisa por nome 
            var usuario = new UsuariosModel();
            usuario.nome = tbNomeUsuario.Text;

            BasePacket pacote = new();
            pacote.dados = usuario;
            pacote.serverName = "ServerUsuarios";
            pacote.action = "BuscarRegistros";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarPesquisa);

        }

        private async void BtnGravarUsuario_Click(object sender, EventArgs e) {
            var usuario = new UsuariosModel();
            if (tbIdUsuario.Text != "")
                usuario.id = int.Parse(tbIdUsuario.Text);
            usuario.nome = tbNomeUsuario.Text;
            usuario.username = tbUsername.Text;
            if (tbSenha.Text != "")
                usuario.password = GetSha256(tbSenha.Text);
            usuario.fone = tbContatoUsuario.Text;
            usuario.ativo = chbAtivo.Checked; //ver bool verdadeiro / falso

            BasePacket pacote = new();
            pacote.dados = usuario;
            pacote.serverName = "ServerUsuarios";
            pacote.action = "Save";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarDados);
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e) {
            var usuario = new Models.UsuariosModel();
            usuario.id = int.Parse(tbIdUsuario.Text);
            usuario.nome = tbNomeUsuario.Text;
            usuario.username = tbUsername.Text;
            usuario.password = tbSenha.Text;
            usuario.fone = tbContatoUsuario.Text;
            usuario.ativo = chbAtivo.Checked; //ver bool verdadeiro / falso
        }

        private void BtnInativarUsuario_Click(object sender, EventArgs e) {
            //quando clica no botão para desativar o usuario deve desabilitar a edição dos campos e setar no banco "0"
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;
            var row = dgvUsuarios.Rows[e.RowIndex].Cells;
            tbIdUsuario.Text = row["idUsuario"].Value.ToString();
            tbNomeUsuario.Text = (row["nome"].Value ?? "").ToString();
            tbContatoUsuario.Text = (row["contato"].Value ?? "").ToString();
            tbUsername.Text = (row["username"].Value ?? "").ToString();
            chbAtivo.Checked = Convert.ToBoolean(row["ativo"].Value ?? false);
        }

        #endregion

        #region METODOS
        void RetornarDados(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    var usuarios = JsonSerializer.Deserialize<UsuariosModel>(resposta.dados!);
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga o id na tela
                    tbIdUsuario.Text = usuarios!.id.ToString();
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

        void RetornarPesquisa(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    var usuarios = JsonSerializer.Deserialize<List<UsuariosModel>>(resposta.dados!)!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga os resultados na tela
                    dgvUsuarios.Rows.Clear();
                    foreach (var p in usuarios) {
                        var index = dgvUsuarios.Rows.Add();
                        var row = dgvUsuarios.Rows[index].Cells;
                        row["idUsuario"].Value = p.id;
                        row["nome"].Value = p.nome;
                        row["contato"].Value = p.fone;
                        row["ativo"].Value = p.ativo;
                        row["username"].Value = p.username;
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

        #endregion

    }
}