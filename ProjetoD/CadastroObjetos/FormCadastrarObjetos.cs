namespace CadastroObjetos
{
    public partial class FormCadastrarObjetos : Form
    {
        public FormCadastrarObjetos()
        {
            InitializeComponent();
        }

        private void BtnGravarObjeto_Click(object sender, EventArgs e) {
            var objeto = new ServerModel.Program.ObjetoModel();
            objeto.objeto = tbObjeto.Text;

        }
    }
}