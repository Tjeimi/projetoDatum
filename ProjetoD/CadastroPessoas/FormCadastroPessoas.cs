using Models;
using System.Text.Json;
using System.Windows.Forms;
using static datumMQTT.Utils;


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

        private async void BtnAddItens_ClickAsync(object sender, EventArgs e)
        {
            // esse button executa a tela de cadastro de objetos
            // se chbDoador.Checked salva objeto na tabela de itens a serem doados 
            // se chbNecessitado.Checked salva o objeto na tabela de necessidades

            //teste
            PessoasModel pessoa = new();
            pessoa.id = 1;
            pessoa.nome = tbNomePessoa.Text;

            BasePacket pacote = new();
            pacote.dados = pessoa;
            pacote.serverName = "ServerPessoa";
            pacote.action = "Save";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarAsync(topicoResposta, MostraNaTela);

            //teste
        }

        private void MostraNaTela(string pacote) {
            var pkt = JsonSerializer.Deserialize<PessoasModel>(pacote);
            //Fica em outra thread esperando mensagens, então quando chega, tem que "invocar" a thread com a UI 
            //para que não de erro na hora de imprimir para a tela
            MethodInvoker methodInvokerDelegate = delegate () {
                //aqui dentro lida diretamente com a UI de forma segura
                tbDebug.Text = pkt!.endereco;
                tbDebug.Text += "aaaaaaaaa";
            };

            //boilerplate para invocar a thread da UI e não dar problemas
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
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