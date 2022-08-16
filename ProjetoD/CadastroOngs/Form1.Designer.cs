namespace CadastroOngs
{
    partial class FormCadastroOngs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroOngs));
            this.txtNomeOng = new System.Windows.Forms.TextBox();
            this.txtEnderecoOng = new System.Windows.Forms.TextBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.txtContatoOng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCadastrarOng = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeOng
            // 
            this.txtNomeOng.Location = new System.Drawing.Point(66, 120);
            this.txtNomeOng.Name = "txtNomeOng";
            this.txtNomeOng.Size = new System.Drawing.Size(355, 27);
            this.txtNomeOng.TabIndex = 0;
            // 
            // txtEnderecoOng
            // 
            this.txtEnderecoOng.Location = new System.Drawing.Point(66, 249);
            this.txtEnderecoOng.Name = "txtEnderecoOng";
            this.txtEnderecoOng.Size = new System.Drawing.Size(355, 27);
            this.txtEnderecoOng.TabIndex = 1;
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(66, 313);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(273, 28);
            this.comboBoxCidade.TabIndex = 2;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "PR",
            "RS",
            "SC"});
            this.comboBoxEstado.Location = new System.Drawing.Point(345, 313);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(76, 28);
            this.comboBoxEstado.TabIndex = 3;
            // 
            // txtContatoOng
            // 
            this.txtContatoOng.Location = new System.Drawing.Point(66, 183);
            this.txtContatoOng.Name = "txtContatoOng";
            this.txtContatoOng.Size = new System.Drawing.Size(355, 27);
            this.txtContatoOng.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome da Ong";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(66, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contato";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(66, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(66, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(345, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "UF";
            // 
            // btCadastrarOng
            // 
            this.btCadastrarOng.Location = new System.Drawing.Point(66, 361);
            this.btCadastrarOng.Name = "btCadastrarOng";
            this.btCadastrarOng.Size = new System.Drawing.Size(103, 46);
            this.btCadastrarOng.TabIndex = 10;
            this.btCadastrarOng.Text = "Cadastrar";
            this.btCadastrarOng.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Informe os dados da Ong:";
            // 
            // FormCadastroOngs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCadastrarOng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContatoOng);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.txtEnderecoOng);
            this.Controls.Add(this.txtNomeOng);
            this.DoubleBuffered = true;
            this.Name = "FormCadastroOngs";
            this.Text = "Cadastro de Ongs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNomeOng;
        private TextBox txtEnderecoOng;
        private ComboBox comboBoxCidade;
        private ComboBox comboBoxEstado;
        private TextBox txtContatoOng;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btCadastrarOng;
        private Label label6;
    }
}