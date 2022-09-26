using CadastroOngs;
using CadastroPessoas;
using CadastroUsuarios;
using Chat;
using PesquisaObjetos;

namespace Main {
    public partial class FormPrincipal : Form {

        public FormPrincipal() {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e) {
            lblNomeOng.Text = Environment.GetEnvironmentVariable("ongnome");
        }

        private void btnPessoas_Click(object sender, EventArgs e) {
            FormCadastroPessoas form = new();
            form.Show();
        }

        private void btnChat_Click(object sender, EventArgs e) {
            FormChat form = new();
            form.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e) {
            FormCadastroUsuarios form = new();
            form.Show();
        }

        private void BtnOng_Click(object sender, EventArgs e) {
            FormCadastroOngs form = new();
            form.Show();
        }

        private void btnObjetos_Click(object sender, EventArgs e) {
            FormPesquisaObjetos form = new();
            form.Show();
        }
    }
}