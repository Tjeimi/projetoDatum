using Models;
using System.Text.Json;
using static datumMQTT.Utils;

namespace Doacoes {
    public partial class FormDoacoes : Form {
        public FormDoacoes() {
            InitializeComponent();
        }

        private async void BtnConfirmarDoacao_Click(object sender, EventArgs e) {
            if (tbIdObjDoar.Text == "" || tbIdObjNecessario.Text == "")
                return;
            MatchObjetoModel o = new();
            o.idobjnecessidade = Convert.ToInt64(tbIdObjNecessario.Text);
            o.idobjdoando = Convert.ToInt64(tbIdObjDoar.Text);

            BasePacket pacote = new();
            pacote.serverName = "ServerObjetos";
            pacote.action = "FazerMatch";
            pacote.dados = o;

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarMatch);
        }

        private void RetornarMatch(string r) {
            MethodInvoker methodInvokerDelegate = delegate () {
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    FormDoacoes_Load(null!, null!);
                    tbIdObjDoar.Text = "";
                    tbIdObjNecessario.Text = "";
                    tbObjNecessidade.Text = "";
                    tbObjDoar.Text = "";
                }
            };
            //boilerplate para invocar a thread da UI e não dar problemas
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void RetornarSelect(string r) {

            MethodInvoker methodInvokerDelegate = delegate () {
                //tenta desserializar e colocar o id inserido na tela
                var resposta = JsonSerializer.Deserialize<BasePacketResposta>(r);
                if (resposta!.codigo == 200) {
                    var objetosList = JsonSerializer.Deserialize<List<MatchObjetoModel>>(resposta.dados!);
                    //joga os resultados na tela
                    DgvDoacao.Rows.Clear();
                    foreach (var p in objetosList!) {
                        var index = DgvDoacao.Rows.Add();
                        var row = DgvDoacao.Rows[index].Cells;
                        row["doador"].Value = p.nomedoando;
                        row["doando"].Value = p.objdoando;
                        row["necessitado"].Value = p.nomenecessidade;
                        row["necessidade"].Value = p.objnecessidade;
                        row["categoria"].Value = p.categoria;
                        row["idObjDoando"].Value = p.idobjdoando;
                        row["idObjNecessidade"].Value = p.idobjnecessidade;
                    }
                } else {

                }
            };
            //boilerplate para invocar a thread da UI e não dar problemas
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private async void FormDoacoes_Load(object sender, EventArgs e) {
            BasePacket pacote = new();
            pacote.serverName = "ServerObjetos";
            pacote.action = "BuscarMatch";

            string topicoResposta = await PublicarAsync("datum/server", pacote);
            await EscutarRespostaAsync(topicoResposta, RetornarSelect);
        }

        private void DgvDoacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;
            var row = DgvDoacao.Rows[e.RowIndex].Cells;
            tbIdObjDoar.Text = row["idObjDoando"].Value.ToString();
            tbIdObjNecessario.Text = row["idObjNecessidade"].Value.ToString();
            tbObjNecessidade.Text = row["necessidade"].Value.ToString();
            tbObjDoar.Text = row["doando"].Value.ToString();
        }
    }
}