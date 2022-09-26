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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGravarUsuario = new System.Windows.Forms.Button();
            this.tbContatoUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPesquisarUsuario = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            this.tbIdOng = new System.Windows.Forms.TextBox();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nome,
            this.contato,
            this.ativo});
            this.dgvUsuarios.Location = new System.Drawing.Point(385, 46);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(379, 155);
            this.dgvUsuarios.TabIndex = 10;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
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
            // ativo
            // 
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // BtnGravarUsuario
            // 
            this.BtnGravarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnGravarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGravarUsuario.Image = global::CadastroUsuarios.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarUsuario.Location = new System.Drawing.Point(286, 168);
            this.BtnGravarUsuario.Name = "BtnGravarUsuario";
            this.BtnGravarUsuario.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarUsuario.TabIndex = 8;
            this.BtnGravarUsuario.UseVisualStyleBackColor = false;
            this.BtnGravarUsuario.Click += new System.EventHandler(this.BtnGravarUsuario_Click);
            // 
            // tbContatoUsuario
            // 
            this.tbContatoUsuario.Location = new System.Drawing.Point(27, 92);
            this.tbContatoUsuario.Name = "tbContatoUsuario";
            this.tbContatoUsuario.Size = new System.Drawing.Size(292, 23);
            this.tbContatoUsuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contato";
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(27, 46);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(292, 23);
            this.tbNomeUsuario.TabIndex = 2;
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
            // BtnPesquisarUsuario
            // 
            this.BtnPesquisarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisarUsuario.Image = global::CadastroUsuarios.Properties.Resources.icons8_search_client_20px;
            this.BtnPesquisarUsuario.Location = new System.Drawing.Point(321, 46);
            this.BtnPesquisarUsuario.Name = "BtnPesquisarUsuario";
            this.BtnPesquisarUsuario.Size = new System.Drawing.Size(27, 25);
            this.BtnPesquisarUsuario.TabIndex = 3;
            this.BtnPesquisarUsuario.UseVisualStyleBackColor = false;
            this.BtnPesquisarUsuario.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(27, 139);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(158, 23);
            this.tbUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 119);
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
            this.label5.Location = new System.Drawing.Point(191, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(191, 139);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(128, 23);
            this.tbSenha.TabIndex = 6;
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Location = new System.Drawing.Point(27, 168);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(54, 19);
            this.chbAtivo.TabIndex = 7;
            this.chbAtivo.Text = "Ativo";
            this.chbAtivo.UseVisualStyleBackColor = true;
            // 
            // tbIdOng
            // 
            this.tbIdOng.Location = new System.Drawing.Point(273, 16);
            this.tbIdOng.Name = "tbIdOng";
            this.tbIdOng.Size = new System.Drawing.Size(42, 23);
            this.tbIdOng.TabIndex = 1;
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Location = new System.Drawing.Point(225, 16);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(42, 23);
            this.tbIdUsuario.TabIndex = 0;
            // 
            // tbResultado
            // 
            this.tbResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbResultado.ForeColor = System.Drawing.Color.White;
            this.tbResultado.Location = new System.Drawing.Point(0, 427);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(800, 23);
            this.tbResultado.TabIndex = 32;
            // 
            // FormCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.tbIdOng);
            this.Controls.Add(this.chbAtivo);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnPesquisarUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.BtnGravarUsuario);
            this.Controls.Add(this.tbContatoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNomeUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroUsuarios";
            this.Text = "Cadastro de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvUsuarios;
        private Button BtnGravarUsuario;
        private TextBox tbContatoUsuario;
        private Label label4;
        private TextBox tbNomeUsuario;
        private Label label1;
        private Button BtnPesquisarUsuario;
        private TextBox tbUsername;
        private Label label2;
        private Label label5;
        private TextBox tbSenha;
        private CheckBox chbAtivo;
        private TextBox tbIdOng;
        private TextBox tbIdUsuario;
        private TextBox tbResultado;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn contato;
        private DataGridViewTextBoxColumn ativo;
    }
}