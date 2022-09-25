using Models;
using System.Text.Json;
using static datumMQTT.Utils;

namespace CadastroObjetos
{
    public partial class FormCadastrarObjetos : Form
    {
        public FormCadastrarObjetos()
        {
            InitializeComponent();
        }

        private async void BtnGravarObjeto_Click(object sender, EventArgs e) {
            var objeto = new ObjetosModel();
            if (idObjeto.Text != "")
                objeto.id = Convert.ToInt64(idObjeto.Text);
            objeto.objeto = tbObjeto.Text;
            objeto.idcategoria = int.Parse(cbCategorias.Text);
            objeto.descricao = tbDescricao.Text;
            objeto.imagem = tbImagens.Text; //ver como as imagens serão salvar -- exibe imagens carregadas
            if (chbDoação.Checked == true)
            {
                var objetoDoacao = new ObjetosDoandoModel();
                objetoDoacao.idpessoa = int.Parse(idPessoa.Text);
                objetoDoacao.idcategoria = int.Parse(cbCategorias.Text);
                objetoDoacao.idusuario = int.Parse(idUsuario.Text);
                objetoDoacao.idobjeto = int.Parse(idObjeto.Text);
            }
            else if(chbNecessidade.Checked == true) {
                var objetoNecessario = new ObjetosNecessariosModel();
                objetoNecessario.idpessoa = int.Parse(idPessoa.Text);
                objetoNecessario.idcategoria = int.Parse(cbCategorias.Text);
                objetoNecessario.idusuario = int.Parse(idUsuario.Text);
                objetoNecessario.idobjeto = int.Parse(idObjeto.Text);
            }
            BasePacket pacote = new();
            pacote.dados = objeto;
            pacote.serverName = "ServerPessoa";
            pacote.action = "Save";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarDados);
        }

        private void BtnCarregarImagem_Click(object sender, EventArgs e)
        {
            // ver função para buscar imagens do computador
        }

        private void BtnApagarImagem_Click(object sender, EventArgs e)
        {

        }

        void RetornarDados(string r)
        {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200)
                {
                    var objeto = JsonSerializer.Deserialize<ObjetosModel>(resposta.dados!)!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga o id na tela
                    idObjeto.Text = objeto!.id.ToString();
                }
                else
                {
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
    }
}