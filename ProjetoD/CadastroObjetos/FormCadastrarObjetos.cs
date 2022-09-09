namespace CadastroObjetos
{
    public partial class FormCadastrarObjetos : Form
    {
        public FormCadastrarObjetos()
        {
            InitializeComponent();
        }

        private void BtnGravarObjeto_Click(object sender, EventArgs e) {
            var objeto = new ServerModel.Program.ObjetosModel();
            objeto.objeto = tbObjeto.Text;
            objeto.idcategoria = int.Parse(cbCategorias.Text);
            objeto.descricao = tbDescricao.Text;
            objeto.imagem = tbImagens.Text; //ver como as imagens serão salvar -- exibe imagens carregadas
            if (chbDoação.Checked == true)
            {
                var objetoDoacao = new ServerModel.Program.ObjetosDoandoModel();
                objetoDoacao.idpessoa = int.Parse(idPessoa.Text);
                objetoDoacao.idcategoria = int.Parse(cbCategorias.Text);
                objetoDoacao.idusuario = int.Parse(idUsuario.Text);
                objetoDoacao.idobjeto = int.Parse(idObjeto.Text);
            }
            else if(chbNecessidade.Checked == true) {
                var objetoNecessario = new ServerModel.Program.ObjetosNecessariosModel();
                objetoNecessario.idpessoa = int.Parse(idPessoa.Text);
                objetoNecessario.idcategoria = int.Parse(cbCategorias.Text);
                objetoNecessario.idusuario = int.Parse(idUsuario.Text);
                objetoNecessario.idobjeto = int.Parse(idObjeto.Text);
            }
        }

        private void BtnCarregarImagem_Click(object sender, EventArgs e)
        {
            // ver função para buscar imagens do computador
        }

        private void BtnApagarImagem_Click(object sender, EventArgs e)
        {

        }
    }
}