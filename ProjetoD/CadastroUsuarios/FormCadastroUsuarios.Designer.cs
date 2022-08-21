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
            this.BtnGravarUsuario = new System.Windows.Forms.Button();
            this.tbContatoUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEnderecoUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditarUsuario = new System.Windows.Forms.Button();
            this.BtnInativarUsuario = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
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
            // BtnGravarUsuario
            // 
            this.BtnGravarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnGravarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGravarUsuario.Image = global::CadastroUsuarios.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarUsuario.Location = new System.Drawing.Point(208, 216);
            this.BtnGravarUsuario.Name = "BtnGravarUsuario";
            this.BtnGravarUsuario.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarUsuario.TabIndex = 20;
            this.BtnGravarUsuario.UseVisualStyleBackColor = false;
            // 
            // tbContatoUsuario
            // 
            this.tbContatoUsuario.Location = new System.Drawing.Point(27, 140);
            this.tbContatoUsuario.Name = "tbContatoUsuario";
            this.tbContatoUsuario.Size = new System.Drawing.Size(292, 23);
            this.tbContatoUsuario.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contato";
            // 
            // tbEnderecoUsuario
            // 
            this.tbEnderecoUsuario.Location = new System.Drawing.Point(27, 93);
            this.tbEnderecoUsuario.Name = "tbEnderecoUsuario";
            this.tbEnderecoUsuario.Size = new System.Drawing.Size(292, 23);
            this.tbEnderecoUsuario.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Endereço";
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(27, 46);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(292, 23);
            this.tbNomeUsuario.TabIndex = 13;
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
            // BtnEditarUsuario
            // 
            this.BtnEditarUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEditarUsuario.Image = global::CadastroUsuarios.Properties.Resources.icons8_pencil_drawing_20px;
            this.BtnEditarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarUsuario.Location = new System.Drawing.Point(247, 216);
            this.BtnEditarUsuario.Name = "BtnEditarUsuario";
            this.BtnEditarUsuario.Size = new System.Drawing.Size(33, 33);
            this.BtnEditarUsuario.TabIndex = 20;
            this.BtnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // BtnInativarUsuario
            // 
            this.BtnInativarUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnInativarUsuario.Image = global::CadastroUsuarios.Properties.Resources.icons8_denied_20px;
            this.BtnInativarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInativarUsuario.Location = new System.Drawing.Point(286, 216);
            this.BtnInativarUsuario.Name = "BtnInativarUsuario";
            this.BtnInativarUsuario.Size = new System.Drawing.Size(33, 33);
            this.BtnInativarUsuario.TabIndex = 20;
            this.BtnInativarUsuario.UseVisualStyleBackColor = false;
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
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(27, 187);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(158, 23);
            this.tbUsername.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(191, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(191, 187);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(128, 23);
            this.tbSenha.TabIndex = 25;
            // 
            // FormCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.DgvPessoas);
            this.Controls.Add(this.BtnInativarUsuario);
            this.Controls.Add(this.BtnEditarUsuario);
            this.Controls.Add(this.BtnGravarUsuario);
            this.Controls.Add(this.tbContatoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEnderecoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomeUsuario);
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
        private Button BtnGravarUsuario;
        private TextBox tbContatoUsuario;
        private Label label4;
        private TextBox tbEnderecoUsuario;
        private Label label3;
        private TextBox tbNomeUsuario;
        private Label label1;
        private Button BtnEditarUsuario;
        private Button BtnInativarUsuario;
        private Button BtnPesquisar;
        private TextBox tbUsername;
        private Label label2;
        private Label label5;
        private TextBox tbSenha;
    }
}