namespace CadastroUsuarios
{
    partial class FormCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuarios));
            this.DgvPessoas = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGravarPessoa = new System.Windows.Forms.Button();
            this.txtContatoPessoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnderecoPessoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInativar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPessoas)).BeginInit();
            this.SuspendLayout();
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
            this.DgvPessoas.TabIndex = 22;
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
            // BtnGravarPessoa
            // 
            this.BtnGravarPessoa.BackColor = System.Drawing.Color.Transparent;
            this.BtnGravarPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGravarPessoa.Image = global::CadastroUsuarios.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarPessoa.Location = new System.Drawing.Point(208, 177);
            this.BtnGravarPessoa.Name = "BtnGravarPessoa";
            this.BtnGravarPessoa.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarPessoa.TabIndex = 20;
            this.BtnGravarPessoa.UseVisualStyleBackColor = false;
            // 
            // txtContatoPessoa
            // 
            this.txtContatoPessoa.Location = new System.Drawing.Point(27, 148);
            this.txtContatoPessoa.Name = "txtContatoPessoa";
            this.txtContatoPessoa.Size = new System.Drawing.Size(292, 23);
            this.txtContatoPessoa.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contato";
            // 
            // txtEnderecoPessoa
            // 
            this.txtEnderecoPessoa.Location = new System.Drawing.Point(27, 96);
            this.txtEnderecoPessoa.Name = "txtEnderecoPessoa";
            this.txtEnderecoPessoa.Size = new System.Drawing.Size(292, 23);
            this.txtEnderecoPessoa.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Endereço";
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(27, 46);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(292, 23);
            this.txtNomePessoa.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEditar.Image = global::CadastroUsuarios.Properties.Resources.icons8_pencil_drawing_20px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(247, 177);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(33, 33);
            this.BtnEditar.TabIndex = 20;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnInativar
            // 
            this.BtnInativar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnInativar.Image = global::CadastroUsuarios.Properties.Resources.icons8_unavailable_20px;
            this.BtnInativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInativar.Location = new System.Drawing.Point(286, 177);
            this.BtnInativar.Name = "BtnInativar";
            this.BtnInativar.Size = new System.Drawing.Size(33, 33);
            this.BtnInativar.TabIndex = 20;
            this.BtnInativar.UseVisualStyleBackColor = false;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.Image = global::CadastroUsuarios.Properties.Resources.icons8_search_client_20px;
            this.BtnPesquisar.Location = new System.Drawing.Point(321, 46);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(27, 25);
            this.BtnPesquisar.TabIndex = 23;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // FormCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.DgvPessoas);
            this.Controls.Add(this.BtnInativar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGravarPessoa);
            this.Controls.Add(this.txtContatoPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnderecoPessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroUsuarios";
            this.Text = "Cadastro de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView DgvPessoas;
        private DataGridViewTextBoxColumn idPessoa;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn contato;
        private Button BtnGravarPessoa;
        private TextBox txtContatoPessoa;
        private Label label4;
        private TextBox txtEnderecoPessoa;
        private Label label3;
        private TextBox txtNomePessoa;
        private Label label1;
        private Button BtnEditar;
        private Button BtnInativar;
        private Button BtnPesquisar;
    }
}