namespace CadastroPessoas
{
    public partial class FormCadastroPessoas : Form
    {
        public FormCadastroPessoas()
        {
            InitializeComponent();
        }

        private void BtnGravarPessoa_Click(object sender, EventArgs e)
        {
            var pessoa = new Models.PessoasModel();
            pessoa.nome = tbNomePessoa.Text;
            pessoa.idong = int.Parse(idOng.Text);
            //pessoa.ativo = chbAtivo.Checked ? 1 : 0;
            pessoa.fone = tbContatoPessoa.Text;
            pessoa.endereco = tbContatoPessoa.Text;
            pessoa.cidade = cbCidade.Text;
            pessoa.estado = cbEstado.Text;
        }

        private void BtnEditarPessoa_Click(object sender, EventArgs e)
        {
            var pessoa = new Models.PessoasModel();
            pessoa.id = int.Parse(tbIdPessoa.Text);
            pessoa.nome = tbNomePessoa.Text;
            pessoa.idong = int.Parse(idOng.Text);
            //pessoa.ativo = chbAtivo.Checked ? 1 : 0;
            pessoa.fone = tbContatoPessoa.Text;
            pessoa.endereco = tbContatoPessoa.Text;
            pessoa.cidade = cbCidade.Text;
            pessoa.estado = cbEstado.Text;
        }

        private void BtnDesativar_Click(object sender, EventArgs e)
        {
            //quando clica no botão para desativar a pessoa deve desabilitar a edição dos campos e setar no banco "0"
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            // pesquisa por nome e por telefone
        }

        private void BtnAddItens_Click(object sender, EventArgs e)
        {
            // esse button executa a tela de cadastro de objetos
            // se chbDoador.Checked salva objeto na tabela de itens a serem doados 
            // se chbNecessitado.Checked salva o objeto na tabela de necessidades
        }

        private void BtnAddContato_Click(object sender, EventArgs e)
        {
            // add mais contato pra pessoa. É necessário???
        }

        private void BtnAddEndereco_Click(object sender, EventArgs e)
        {
            // add mais endereços pra pessoa. É necessário???
        }


    }
}