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
            // pesquisar usuário
        }

        private void BtnGravarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new ServerModel.Program.UsuariosModel();
            usuario.idong = int.Parse(idOng.Text);
            usuario.nome = tbNomeUsuario.Text;
            usuario.username = tbUsername.Text;
            usuario.password = tbSenha.Text;
            usuario.fone = tbContatoUsuario.Text;
            usuario.ativo = chbAtivo.Checked; //ver bool verdadeiro / falso
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new ServerModel.Program.UsuariosModel();
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
            //quando clica no botão para desativar o usuario deve desabilitar a edição dos campos e setar no banco "0"
        }
    }
}