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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvDoacao = new System.Windows.Forms.DataGridView();
            this.Doador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Necessitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDoador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNecessitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConfirmarDoacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoacao)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 110);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 110);
            this.textBox2.TabIndex = 0;
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
            this.DgvDoacao.AllowUserToOrderColumns = true;
            this.DgvDoacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doador,
            this.Necessitado,
            this.idDoador,
            this.idNecessitado,
            this.Objeto,
            this.Cidade});
            this.DgvDoacao.Location = new System.Drawing.Point(43, 204);
            this.DgvDoacao.Name = "DgvDoacao";
            this.DgvDoacao.ReadOnly = true;
            this.DgvDoacao.RowHeadersVisible = false;
            this.DgvDoacao.RowTemplate.Height = 25;
            this.DgvDoacao.Size = new System.Drawing.Size(711, 234);
            this.DgvDoacao.TabIndex = 25;
            // 
            // Doador
            // 
            this.Doador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doador.HeaderText = "Doador";
            this.Doador.Name = "Doador";
            this.Doador.ReadOnly = true;
            // 
            // Necessitado
            // 
            this.Necessitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Necessitado.HeaderText = "Necessitado";
            this.Necessitado.Name = "Necessitado";
            this.Necessitado.ReadOnly = true;
            // 
            // idDoador
            // 
            this.idDoador.HeaderText = "idDoador";
            this.idDoador.Name = "idDoador";
            this.idDoador.ReadOnly = true;
            this.idDoador.Visible = false;
            // 
            // idNecessitado
            // 
            this.idNecessitado.HeaderText = "idNecessitado";
            this.idNecessitado.Name = "idNecessitado";
            this.idNecessitado.ReadOnly = true;
            this.idNecessitado.Visible = false;
            // 
            // Objeto
            // 
            this.Objeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Objeto.HeaderText = "Objeto";
            this.Objeto.Name = "Objeto";
            this.Objeto.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cidade.FillWeight = 50F;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // BtnConfirmarDoacao
            // 
            this.BtnConfirmarDoacao.Image = global::Doacoes.Properties.Resources.icons8_trust_20px;
            this.BtnConfirmarDoacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmarDoacao.Location = new System.Drawing.Point(336, 168);
            this.BtnConfirmarDoacao.Name = "BtnConfirmarDoacao";
            this.BtnConfirmarDoacao.Size = new System.Drawing.Size(125, 30);
            this.BtnConfirmarDoacao.TabIndex = 26;
            this.BtnConfirmarDoacao.Text = "Doação realizada";
            this.BtnConfirmarDoacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmarDoacao.UseVisualStyleBackColor = true;
            // 
            // FormDoacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConfirmarDoacao);
            this.Controls.Add(this.DgvDoacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoacoes";
            this.Text = "DOAR";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView DgvDoacao;
        private Button BtnConfirmarDoacao;
        private DataGridViewTextBoxColumn Doador;
        private DataGridViewTextBoxColumn Necessitado;
        private DataGridViewTextBoxColumn idDoador;
        private DataGridViewTextBoxColumn idNecessitado;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Cidade;
    }
}