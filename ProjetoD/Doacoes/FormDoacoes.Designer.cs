namespace Doacoes
{
    partial class FormDoacoes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoacoes));
            this.tbObjNecessidade = new System.Windows.Forms.TextBox();
            this.tbObjDoar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvDoacao = new System.Windows.Forms.DataGridView();
            this.Doador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.necessitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.necessidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjDoando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjNecessidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConfirmarDoacao = new System.Windows.Forms.Button();
            this.tbIdObjDoar = new System.Windows.Forms.TextBox();
            this.tbIdObjNecessario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tbObjNecessidade
            // 
            this.tbObjNecessidade.Location = new System.Drawing.Point(414, 52);
            this.tbObjNecessidade.Name = "tbObjNecessidade";
            this.tbObjNecessidade.Size = new System.Drawing.Size(340, 23);
            this.tbObjNecessidade.TabIndex = 0;
            // 
            // tbObjDoar
            // 
            this.tbObjDoar.Location = new System.Drawing.Point(43, 52);
            this.tbObjDoar.Name = "tbObjDoar";
            this.tbObjDoar.Size = new System.Drawing.Size(340, 23);
            this.tbObjDoar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Para doar ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::Doacoes.Properties.Resources.icons8_trust_20px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(414, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Necessidade";
            // 
            // DgvDoacao
            // 
            this.DgvDoacao.AllowUserToAddRows = false;
            this.DgvDoacao.AllowUserToDeleteRows = false;
            this.DgvDoacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doador,
            this.doando,
            this.necessitado,
            this.necessidade,
            this.categoria,
            this.idObjDoando,
            this.idObjNecessidade});
            this.DgvDoacao.Location = new System.Drawing.Point(43, 117);
            this.DgvDoacao.MultiSelect = false;
            this.DgvDoacao.Name = "DgvDoacao";
            this.DgvDoacao.ReadOnly = true;
            this.DgvDoacao.RowHeadersVisible = false;
            this.DgvDoacao.RowTemplate.Height = 25;
            this.DgvDoacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDoacao.Size = new System.Drawing.Size(711, 321);
            this.DgvDoacao.TabIndex = 25;
            this.DgvDoacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoacao_CellDoubleClick);
            // 
            // Doador
            // 
            this.Doador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doador.HeaderText = "Doador";
            this.Doador.Name = "Doador";
            this.Doador.ReadOnly = true;
            // 
            // doando
            // 
            this.doando.HeaderText = "Doando";
            this.doando.Name = "doando";
            this.doando.ReadOnly = true;
            // 
            // necessitado
            // 
            this.necessitado.HeaderText = "Necessitado";
            this.necessitado.Name = "necessitado";
            this.necessitado.ReadOnly = true;
            // 
            // necessidade
            // 
            this.necessidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.necessidade.HeaderText = "Precisando de";
            this.necessidade.Name = "necessidade";
            this.necessidade.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // idObjDoando
            // 
            this.idObjDoando.HeaderText = "idObjDoando";
            this.idObjDoando.Name = "idObjDoando";
            this.idObjDoando.ReadOnly = true;
            this.idObjDoando.Visible = false;
            // 
            // idObjNecessidade
            // 
            this.idObjNecessidade.HeaderText = "idObjNecessidade";
            this.idObjNecessidade.Name = "idObjNecessidade";
            this.idObjNecessidade.ReadOnly = true;
            this.idObjNecessidade.Visible = false;
            // 
            // BtnConfirmarDoacao
            // 
            this.BtnConfirmarDoacao.Image = global::Doacoes.Properties.Resources.icons8_trust_20px;
            this.BtnConfirmarDoacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmarDoacao.Location = new System.Drawing.Point(333, 81);
            this.BtnConfirmarDoacao.Name = "BtnConfirmarDoacao";
            this.BtnConfirmarDoacao.Size = new System.Drawing.Size(125, 30);
            this.BtnConfirmarDoacao.TabIndex = 26;
            this.BtnConfirmarDoacao.Text = "Doação realizada";
            this.BtnConfirmarDoacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmarDoacao.UseVisualStyleBackColor = true;
            this.BtnConfirmarDoacao.Click += new System.EventHandler(this.BtnConfirmarDoacao_Click);
            // 
            // tbIdObjDoar
            // 
            this.tbIdObjDoar.Enabled = false;
            this.tbIdObjDoar.Location = new System.Drawing.Point(348, 26);
            this.tbIdObjDoar.Name = "tbIdObjDoar";
            this.tbIdObjDoar.Size = new System.Drawing.Size(35, 23);
            this.tbIdObjDoar.TabIndex = 27;
            this.tbIdObjDoar.Visible = false;
            // 
            // tbIdObjNecessario
            // 
            this.tbIdObjNecessario.Enabled = false;
            this.tbIdObjNecessario.Location = new System.Drawing.Point(719, 26);
            this.tbIdObjNecessario.Name = "tbIdObjNecessario";
            this.tbIdObjNecessario.Size = new System.Drawing.Size(35, 23);
            this.tbIdObjNecessario.TabIndex = 27;
            this.tbIdObjNecessario.Visible = false;
            // 
            // FormDoacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbIdObjNecessario);
            this.Controls.Add(this.tbIdObjDoar);
            this.Controls.Add(this.BtnConfirmarDoacao);
            this.Controls.Add(this.DgvDoacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbObjDoar);
            this.Controls.Add(this.tbObjNecessidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoacoes";
            this.Text = "DOAR";
            this.Load += new System.EventHandler(this.FormDoacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbObjNecessidade;
        private TextBox tbObjDoar;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView DgvDoacao;
        private Button BtnConfirmarDoacao;
        private DataGridViewTextBoxColumn Doador;
        private DataGridViewTextBoxColumn doando;
        private DataGridViewTextBoxColumn necessitado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn idObjDoando;
        private DataGridViewTextBoxColumn idObjNecessidade;
        private DataGridViewTextBoxColumn necessidade;
        private TextBox tbIdObjDoar;
        private TextBox tbIdObjNecessario;
    }
}