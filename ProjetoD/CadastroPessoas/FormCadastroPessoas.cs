using Models;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;
using static datumMQTT.Utils;


namespace CadastroPessoas {
    public partial class FormCadastroPessoas : Form {
        public FormCadastroPessoas() {
            InitializeComponent();
        }

        #region EVENTOS
        private async void BtnGravarPessoa_Click(object sender, EventArgs e) {
            var pessoa = new PessoasModel();
            pessoa.nome = tbNomePessoa.Text;
            if (idOng.Text != "")
                pessoa.idong = Convert.ToInt64(idOng.Text);
            pessoa.ativo = chbAtivo.Checked;
            pessoa.fone = tbContatoPessoa.Text;
            pessoa.endereco = tbContatoPessoa.Text;
            pessoa.cidade = cbCidade.Text;
            pessoa.estado = cbEstado.Text;

            BasePacket pacote = new();
            pacote.dados = pessoa;
            pacote.serverName = "ServerPessoa";
            pacote.action = "Insert";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarDados);
        }

        private void BtnEditarPessoa_Click(object sender, EventArgs e) {
            PessoasModel pessoa = new();
            pessoa.id = int.Parse(tbIdPessoa.Text);
            pessoa.nome = tbNomePessoa.Text;
            pessoa.idong = int.Parse(idOng.Text);
            pessoa.ativo = chbAtivo.Checked;
            pessoa.fone = tbContatoPessoa.Text;
            pessoa.endereco = tbContatoPessoa.Text;
            pessoa.cidade = cbCidade.Text;
            pessoa.estado = cbEstado.Text;
        }

        private void BtnDesativar_Click(object sender, EventArgs e) {
            //quando clica no botão para desativar a pessoa deve desabilitar a edição dos campos e setar no banco "0"
        }

        private void BtnPesquisar_Click(object sender, EventArgs e) {
            // pesquisa por nome e por telefone
        }

        private async void BtnAddItens_ClickAsync(object sender, EventArgs e) {
            // esse button executa a tela de cadastro de objetos
            // se chbDoador.Checked salva objeto na tabela de itens a serem doados 
            // se chbNecessitado.Checked salva o objeto na tabela de necessidades

        }

        private void BtnAddContato_Click(object sender, EventArgs e) {
            // add mais contato pra pessoa. É necessário???
        }

        private void BtnAddEndereco_Click(object sender, EventArgs e) {
            // add mais endereços pra pessoa. É necessário???
        }
        #endregion

        #region METODOS
        void RetornarDados(string resposta) {
            MethodInvoker methodInvokerDelegate = delegate () {
                try {
                    //tenta desserializar e colocar o id inserido na tela
                    var pessoa = JsonSerializer.Deserialize<PessoasModel>(resposta);
                    tbIdPessoa.Text = pessoa!.id.ToString();
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = "Sucesso";
                } catch {
                    tbResultado.BackColor = Color.DarkRed;
                    tbResultado.Text = "Falha";
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