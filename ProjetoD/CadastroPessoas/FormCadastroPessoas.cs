using CadastroObjetos;
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
            if (tbIdPessoa.Text != "")
                pessoa.id = Convert.ToInt64(tbIdPessoa.Text);
            if (tbIdOng.Text != "")
                pessoa.idong = Convert.ToInt64(tbIdOng.Text);
            pessoa.nome = tbNomePessoa.Text;
            pessoa.ativo = chbAtivo.Checked;
            pessoa.fone = tbContatoPessoa.Text;
            pessoa.endereco = tbContatoPessoa.Text;
            pessoa.cidade = cbCidade.Text;
            pessoa.estado = cbEstado.Text;

            BasePacket pacote = new();
            pacote.dados = pessoa;
            pacote.serverName = "ServerPessoa";
            pacote.action = "Save";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarSave);
        }

        private async void BtnPesquisar_Click(object sender, EventArgs e) {
            // pesquisa por nome 
            var pessoa = new PessoasModel();
            pessoa.nome = tbNomePessoa.Text;

            BasePacket pacote = new();
            pacote.dados = pessoa;
            pacote.serverName = "ServerPessoa";
            pacote.action = "BuscarRegistros";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarPesquisa);
        }

        private void BtnAddItens_Click(object sender, EventArgs e) {
            FormCadastrarObjetos form = new(Convert.ToInt64(tbIdPessoa.Text));
            form.ShowDialog();
            // esse button executa a tela de cadastro de objetos

        }

        #endregion

        #region METODOS
        void RetornarSave(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    PessoasModel pessoa = JsonSerializer.Deserialize<PessoasModel>(resposta.dados!)!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga o id na tela
                    tbIdPessoa.Text = pessoa!.id.ToString();
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
                    var pessoas = JsonSerializer.Deserialize<List<PessoasModel>>(resposta.dados!)!;
                    //só para dar um feedback se deu certo
                    tbResultado.BackColor = Color.DarkGreen;
                    tbResultado.Text = resposta.mensagem;
                    //joga os resultados na tela
                    DgvPessoas.Rows.Clear();
                    foreach (var p in pessoas) {
                        var index = DgvPessoas.Rows.Add();
                        var row = DgvPessoas.Rows[index].Cells;
                        row["idPessoa"].Value = p.id;
                        //row["idOng"].Value;
                        row["nome"].Value = p.nome;
                        row["contato"].Value = p.fone;
                        row["cidade"].Value = p.cidade;
                        row["estado"].Value = p.estado;
                        row["contato"].Value = p.fone;
                        row["endereco"].Value = p.endereco;
                        row["ativo"].Value = p.ativo;
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

        private void tbIdPessoa_TextChanged(object sender, EventArgs e) {
            if (tbIdPessoa.Text == "") {
                BtnAddItens.Enabled = false;
                return;
            }
            BtnAddItens.Enabled = true;
        }

        private void btNovo_Click(object sender, EventArgs e) {
            tbIdPessoa.Text = "";
            tbIdOng.Text = "";
            tbNomePessoa.Text = "";
            cbCidade.Text = "";
            cbEstado.Text = "";
            tbContatoPessoa.Text = "";
            tbEnderecoPessoa.Text = "";
            chbAtivo.Checked = false;
        }

        private void DgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;
            var row = DgvPessoas.Rows[e.RowIndex].Cells;
            tbIdPessoa.Text = row["idPessoa"].Value.ToString();
            //tbIdOng.Text
            tbNomePessoa.Text = (row["nome"].Value ?? "").ToString();
            cbCidade.Text = (row["cidade"].Value ?? "").ToString();
            cbEstado.Text = (row["estado"].Value ?? "").ToString();
            tbContatoPessoa.Text = (row["contato"].Value ?? "").ToString();
            tbEnderecoPessoa.Text = (row["endereco"].Value ?? "").ToString();
            chbAtivo.Checked = Convert.ToBoolean(row["ativo"].Value ?? false);
        }
    }
}