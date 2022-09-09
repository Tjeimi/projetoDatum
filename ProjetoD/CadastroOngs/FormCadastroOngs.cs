namespace CadastroOngs
{
    public partial class FormCadastroOngs : Form
    {
        public FormCadastroOngs()
        {
            InitializeComponent();
        }

        private void BtnGravarOng_Click(object sender, EventArgs e)
        {
            var ong = new ServerModel.Program.DadosONGModel();
            ong.nome = tbNomeOng.Text;
            ong.endereco = tbEnderecoOng.Text;
            ong.fone = tbContatoOng.Text;
            ong.cidade = cbCidade.Text;
            ong.estado = cbEstado.Text;
            ong.email = tbEmail.Text;
        }

        private void BtnEditarOng_Click(object sender, EventArgs e)
        {
            var ong = new ServerModel.Program.DadosONGModel();
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

        }

        private void BtnGravarParceira_Click(object sender, EventArgs e)
        {
            var ong = new ServerModel.Program.ParceriasONGModel();
            ong.id = int.Parse(idOng.Text);
            ong.idcidadeparceria = int.Parse(cbCidadesParceiras.Text);
        }
    }
}