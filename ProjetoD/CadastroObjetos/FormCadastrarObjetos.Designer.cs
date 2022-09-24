namespace CadastroObjetos
{
    partial class FormCadastrarObjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarObjetos));
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.BtnGravarObjeto = new System.Windows.Forms.Button();
            this.BtnCarregarImagem = new System.Windows.Forms.Button();
            this.BtnApagarImagem = new System.Windows.Forms.Button();
            this.tbObjeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbNecessidade = new System.Windows.Forms.CheckBox();
            this.chbDoação = new System.Windows.Forms.CheckBox();
            this.idPessoa = new System.Windows.Forms.TextBox();
            this.idObjeto = new System.Windows.Forms.TextBox();
            this.idUsuario = new System.Windows.Forms.TextBox();
            this.tbImagens = new System.Windows.Forms.PictureBox();
            this.dgvObjHistorico = new System.Windows.Forms.DataGridView();
            this.objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbImagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Items.AddRange(new object[] {
            "Móveis sala",
            "Móveis cozinha",
            "Móveis quarto",
            "Utensílios domésticos",
            "Roupas infantis Fem",
            "Roupas infantis Masc",
            "Roupas adultos Fem",
            "Roupas adultos Masc",
            "Material escolar",
            "Alimentos",
            "Produtos de limpeza e higiene",
            "Cobertores",
            "Ração",
            "Equipamentos",
            "Ferramentas",
            "Material de construção"});
            this.cbCategorias.Location = new System.Drawing.Point(26, 44);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(313, 23);
            this.cbCategorias.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Categoria do objeto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(534, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Histórico de objetos";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(26, 136);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescricao.Size = new System.Drawing.Size(313, 94);
            this.tbDescricao.TabIndex = 20;
            // 
            // BtnGravarObjeto
            // 
            this.BtnGravarObjeto.BackColor = System.Drawing.Color.Transparent;
            this.BtnGravarObjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGravarObjeto.Image = global::CadastroObjetos.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarObjeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarObjeto.Location = new System.Drawing.Point(306, 236);
            this.BtnGravarObjeto.Name = "BtnGravarObjeto";
            this.BtnGravarObjeto.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarObjeto.TabIndex = 25;
            this.BtnGravarObjeto.UseVisualStyleBackColor = false;
            this.BtnGravarObjeto.Click += new System.EventHandler(this.BtnGravarObjeto_Click);
            // 
            // BtnCarregarImagem
            // 
            this.BtnCarregarImagem.BackColor = System.Drawing.Color.Transparent;
            this.BtnCarregarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCarregarImagem.Image = global::CadastroObjetos.Properties.Resources.icons8_add_image_20px;
            this.BtnCarregarImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarregarImagem.Location = new System.Drawing.Point(456, 170);
            this.BtnCarregarImagem.Name = "BtnCarregarImagem";
            this.BtnCarregarImagem.Size = new System.Drawing.Size(33, 33);
            this.BtnCarregarImagem.TabIndex = 25;
            this.BtnCarregarImagem.UseVisualStyleBackColor = false;
            this.BtnCarregarImagem.Click += new System.EventHandler(this.BtnCarregarImagem_Click);
            // 
            // BtnApagarImagem
            // 
            this.BtnApagarImagem.BackColor = System.Drawing.Color.Transparent;
            this.BtnApagarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnApagarImagem.Image = global::CadastroObjetos.Properties.Resources.icons8_delete_trash_20px;
            this.BtnApagarImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApagarImagem.Location = new System.Drawing.Point(495, 170);
            this.BtnApagarImagem.Name = "BtnApagarImagem";
            this.BtnApagarImagem.Size = new System.Drawing.Size(33, 33);
            this.BtnApagarImagem.TabIndex = 26;
            this.BtnApagarImagem.UseVisualStyleBackColor = false;
            this.BtnApagarImagem.Click += new System.EventHandler(this.BtnApagarImagem_Click);
            // 
            // tbObjeto
            // 
            this.tbObjeto.Location = new System.Drawing.Point(26, 90);
            this.tbObjeto.Name = "tbObjeto";
            this.tbObjeto.Size = new System.Drawing.Size(313, 23);
            this.tbObjeto.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Objeto";
            // 
            // chbNecessidade
            // 
            this.chbNecessidade.AutoSize = true;
            this.chbNecessidade.Location = new System.Drawing.Point(97, 236);
            this.chbNecessidade.Name = "chbNecessidade";
            this.chbNecessidade.Size = new System.Drawing.Size(92, 19);
            this.chbNecessidade.TabIndex = 30;
            this.chbNecessidade.Text = "Necessidade";
            this.chbNecessidade.UseVisualStyleBackColor = true;
            // 
            // chbDoação
            // 
            this.chbDoação.AutoSize = true;
            this.chbDoação.Location = new System.Drawing.Point(26, 236);
            this.chbDoação.Name = "chbDoação";
            this.chbDoação.Size = new System.Drawing.Size(66, 19);
            this.chbDoação.TabIndex = 31;
            this.chbDoação.Text = "Doação";
            this.chbDoação.UseVisualStyleBackColor = true;
            // 
            // idPessoa
            // 
            this.idPessoa.Enabled = false;
            this.idPessoa.Location = new System.Drawing.Point(297, 15);
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.Size = new System.Drawing.Size(42, 23);
            this.idPessoa.TabIndex = 27;
            // 
            // idObjeto
            // 
            this.idObjeto.Enabled = false;
            this.idObjeto.Location = new System.Drawing.Point(249, 15);
            this.idObjeto.Name = "idObjeto";
            this.idObjeto.Size = new System.Drawing.Size(42, 23);
            this.idObjeto.TabIndex = 32;
            // 
            // idUsuario
            // 
            this.idUsuario.Enabled = false;
            this.idUsuario.Location = new System.Drawing.Point(201, 15);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(42, 23);
            this.idUsuario.TabIndex = 33;
            // 
            // tbImagens
            // 
            this.tbImagens.Location = new System.Drawing.Point(355, 44);
            this.tbImagens.Name = "tbImagens";
            this.tbImagens.Size = new System.Drawing.Size(173, 120);
            this.tbImagens.TabIndex = 34;
            this.tbImagens.TabStop = false;
            // 
            // dgvObjHistorico
            // 
            this.dgvObjHistorico.AllowUserToAddRows = false;
            this.dgvObjHistorico.AllowUserToDeleteRows = false;
            this.dgvObjHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objeto,
            this.tipo});
            this.dgvObjHistorico.Location = new System.Drawing.Point(534, 44);
            this.dgvObjHistorico.Name = "dgvObjHistorico";
            this.dgvObjHistorico.ReadOnly = true;
            this.dgvObjHistorico.RowHeadersVisible = false;
            this.dgvObjHistorico.RowTemplate.Height = 25;
            this.dgvObjHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjHistorico.Size = new System.Drawing.Size(240, 150);
            this.dgvObjHistorico.TabIndex = 35;
            // 
            // objeto
            // 
            this.objeto.HeaderText = "objeto";
            this.objeto.Name = "objeto";
            this.objeto.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(355, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Carregar imagem";
            // 
            // tbResultado
            // 
            this.tbResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbResultado.ForeColor = System.Drawing.Color.White;
            this.tbResultado.Location = new System.Drawing.Point(0, 427);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(785, 23);
            this.tbResultado.TabIndex = 37;
            // 
            // FormCadastrarObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroObjetos.Properties.Resources._5254e7f0_1af9_4b25_8b98_904cfd551103__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvObjHistorico);
            this.Controls.Add(this.tbImagens);
            this.Controls.Add(this.idUsuario);
            this.Controls.Add(this.idObjeto);
            this.Controls.Add(this.chbNecessidade);
            this.Controls.Add(this.chbDoação);
            this.Controls.Add(this.tbObjeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idPessoa);
            this.Controls.Add(this.BtnApagarImagem);
            this.Controls.Add(this.BtnCarregarImagem);
            this.Controls.Add(this.BtnGravarObjeto);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastrarObjetos";
            this.Text = "Cadastro de Objetos";
            ((System.ComponentModel.ISupportInitialize)(this.tbImagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCategorias;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox tbDescricao;
        private Button BtnGravarObjeto;
        private Button BtnCarregarImagem;
        private Button BtnApagarImagem;
        private TextBox tbObjeto;
        private Label label4;
        private CheckBox chbNecessidade;
        private CheckBox chbDoação;
        private TextBox idPessoa;
        private TextBox idObjeto;
        private TextBox idUsuario;
        private PictureBox tbImagens;
        private DataGridView dgvObjHistorico;
        private DataGridViewTextBoxColumn objeto;
        private DataGridViewTextBoxColumn tipo;
        private Label label5;
        private TextBox tbResultado;
    }
}