namespace CadastroPessoas
{
    partial class FormCadastroPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPessoas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.txtEnderecoPessoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContatoPessoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddEndereco = new System.Windows.Forms.Button();
            this.BtnAddContato = new System.Windows.Forms.Button();
            this.BtnGravarPessoa = new System.Windows.Forms.Button();
            this.BtnAddItens = new System.Windows.Forms.Button();
            this.DgvPessoas = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnDesativar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(27, 46);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(292, 23);
            this.txtNomePessoa.TabIndex = 1;
            // 
            // txtEnderecoPessoa
            // 
            this.txtEnderecoPessoa.Location = new System.Drawing.Point(27, 96);
            this.txtEnderecoPessoa.Name = "txtEnderecoPessoa";
            this.txtEnderecoPessoa.Size = new System.Drawing.Size(292, 23);
            this.txtEnderecoPessoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // txtContatoPessoa
            // 
            this.txtContatoPessoa.Location = new System.Drawing.Point(27, 148);
            this.txtContatoPessoa.Name = "txtContatoPessoa";
            this.txtContatoPessoa.Size = new System.Drawing.Size(292, 23);
            this.txtContatoPessoa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contato";
            // 
            // BtnAddEndereco
            // 
            this.BtnAddEndereco.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddEndereco.Image = global::CadastroPessoas.Properties.Resources.icons8_add_20px;
            this.BtnAddEndereco.Location = new System.Drawing.Point(320, 95);
            this.BtnAddEndereco.Name = "BtnAddEndereco";
            this.BtnAddEndereco.Size = new System.Drawing.Size(27, 25);
            this.BtnAddEndereco.TabIndex = 6;
            this.BtnAddEndereco.UseVisualStyleBackColor = false;
            // 
            // BtnAddContato
            // 
            this.BtnAddContato.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddContato.Image = global::CadastroPessoas.Properties.Resources.icons8_add_20px;
            this.BtnAddContato.Location = new System.Drawing.Point(320, 147);
            this.BtnAddContato.Name = "BtnAddContato";
            this.BtnAddContato.Size = new System.Drawing.Size(27, 25);
            this.BtnAddContato.TabIndex = 7;
            this.BtnAddContato.UseVisualStyleBackColor = false;
            // 
            // BtnGravarPessoa
            // 
            this.BtnGravarPessoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnGravarPessoa.Image = global::CadastroPessoas.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarPessoa.Location = new System.Drawing.Point(176, 180);
            this.BtnGravarPessoa.Name = "BtnGravarPessoa";
            this.BtnGravarPessoa.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarPessoa.TabIndex = 8;
            this.BtnGravarPessoa.UseVisualStyleBackColor = false;
            // 
            // BtnAddItens
            // 
            this.BtnAddItens.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAddItens.Image = global::CadastroPessoas.Properties.Resources.icons8_welfare_20px;
            this.BtnAddItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddItens.Location = new System.Drawing.Point(27, 180);
            this.BtnAddItens.Name = "BtnAddItens";
            this.BtnAddItens.Size = new System.Drawing.Size(143, 33);
            this.BtnAddItens.TabIndex = 9;
            this.BtnAddItens.Text = "Adicionar Itens";
            this.BtnAddItens.UseVisualStyleBackColor = false;
            // 
            // DgvPessoas
            // 
            this.DgvPessoas.AllowUserToAddRows = false;
            this.DgvPessoas.AllowUserToDeleteRows = false;
            this.DgvPessoas.AllowUserToOrderColumns = true;
            this.DgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoa,
            this.nome,
            this.contato});
            this.DgvPessoas.Location = new System.Drawing.Point(385, 46);
            this.DgvPessoas.Name = "DgvPessoas";
            this.DgvPessoas.ReadOnly = true;
            this.DgvPessoas.RowHeadersVisible = false;
            this.DgvPessoas.RowTemplate.Height = 25;
            this.DgvPessoas.Size = new System.Drawing.Size(379, 222);
            this.DgvPessoas.TabIndex = 10;
            // 
            // idPessoa
            // 
            this.idPessoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPessoa.HeaderText = "idP";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.FillWeight = 150F;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // contato
            // 
            this.contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contato.HeaderText = "Contato";
            this.contato.Name = "contato";
            this.contato.ReadOnly = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.Image = global::CadastroPessoas.Properties.Resources.icons8_search_client_20px;
            this.BtnPesquisar.Location = new System.Drawing.Point(320, 46);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(27, 25);
            this.BtnPesquisar.TabIndex = 11;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            // 
            // BtnDesativar
            // 
            this.BtnDesativar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnDesativar.Image = global::CadastroPessoas.Properties.Resources.icons8_unavailable_20px_1;
            this.BtnDesativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesativar.Location = new System.Drawing.Point(215, 180);
            this.BtnDesativar.Name = "BtnDesativar";
            this.BtnDesativar.Size = new System.Drawing.Size(33, 33);
            this.BtnDesativar.TabIndex = 8;
            this.BtnDesativar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroPessoas.Properties.Resources._5254e7f0_1af9_4b25_8b98_904cfd551103__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.DgvPessoas);
            this.Controls.Add(this.BtnAddItens);
            this.Controls.Add(this.BtnDesativar);
            this.Controls.Add(this.BtnGravarPessoa);
            this.Controls.Add(this.BtnAddContato);
            this.Controls.Add(this.BtnAddEndereco);
            this.Controls.Add(this.txtContatoPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnderecoPessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroPessoas";
            this.Text = "Cadastro de Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNomePessoa;
        private TextBox txtEnderecoPessoa;
        private Label label3;
        private TextBox txtContatoPessoa;
        private Label label4;
        private Button BtnAddEndereco;
        private Button BtnAddContato;
        private Button BtnGravarPessoa;
        private Button BtnAddItens;
        private DataGridView DgvPessoas;
        private DataGridViewTextBoxColumn idPessoa;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn contato;
        private Button BtnPesquisar;
        private Button BtnDesativar;
    }
}