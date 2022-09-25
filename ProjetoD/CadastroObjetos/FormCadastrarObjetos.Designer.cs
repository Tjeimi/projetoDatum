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
            this.tbIdPessoa = new System.Windows.Forms.TextBox();
            this.tbIdObjeto = new System.Windows.Forms.TextBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.dgvObjHistorico = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.necessidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.tbIdOng = new System.Windows.Forms.TextBox();
            this.chbDoado = new System.Windows.Forms.CheckBox();
            this.rbDoacao = new System.Windows.Forms.RadioButton();
            this.rbNecessidade = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjHistorico)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(192, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Histórico de objetos da pessoa";
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
            this.BtnGravarObjeto.Location = new System.Drawing.Point(233, 239);
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
            // tbIdPessoa
            // 
            this.tbIdPessoa.Enabled = false;
            this.tbIdPessoa.Location = new System.Drawing.Point(297, 15);
            this.tbIdPessoa.Name = "tbIdPessoa";
            this.tbIdPessoa.Size = new System.Drawing.Size(42, 23);
            this.tbIdPessoa.TabIndex = 27;
            // 
            // tbIdObjeto
            // 
            this.tbIdObjeto.Enabled = false;
            this.tbIdObjeto.Location = new System.Drawing.Point(249, 15);
            this.tbIdObjeto.Name = "tbIdObjeto";
            this.tbIdObjeto.Size = new System.Drawing.Size(42, 23);
            this.tbIdObjeto.TabIndex = 32;
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(345, 44);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(183, 120);
            this.pbImagem.TabIndex = 34;
            this.pbImagem.TabStop = false;
            // 
            // dgvObjHistorico
            // 
            this.dgvObjHistorico.AllowUserToAddRows = false;
            this.dgvObjHistorico.AllowUserToDeleteRows = false;
            this.dgvObjHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idPessoa,
            this.idOng,
            this.objeto,
            this.categoria,
            this.descricao,
            this.doado,
            this.doacao,
            this.necessidade,
            this.imagem});
            this.dgvObjHistorico.Location = new System.Drawing.Point(534, 44);
            this.dgvObjHistorico.Name = "dgvObjHistorico";
            this.dgvObjHistorico.ReadOnly = true;
            this.dgvObjHistorico.RowHeadersVisible = false;
            this.dgvObjHistorico.RowTemplate.Height = 25;
            this.dgvObjHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjHistorico.Size = new System.Drawing.Size(240, 159);
            this.dgvObjHistorico.TabIndex = 35;
            this.dgvObjHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjHistorico_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idPessoa
            // 
            this.idPessoa.HeaderText = "idPessoa";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Visible = false;
            // 
            // idOng
            // 
            this.idOng.HeaderText = "idOng";
            this.idOng.Name = "idOng";
            this.idOng.ReadOnly = true;
            this.idOng.Visible = false;
            // 
            // objeto
            // 
            this.objeto.HeaderText = "objeto";
            this.objeto.Name = "objeto";
            this.objeto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Visible = false;
            // 
            // doado
            // 
            this.doado.HeaderText = "doado";
            this.doado.Name = "doado";
            this.doado.ReadOnly = true;
            this.doado.Visible = false;
            // 
            // doacao
            // 
            this.doacao.HeaderText = "doacao";
            this.doacao.Name = "doacao";
            this.doacao.ReadOnly = true;
            this.doacao.Visible = false;
            // 
            // necessidade
            // 
            this.necessidade.HeaderText = "necessidade";
            this.necessidade.Name = "necessidade";
            this.necessidade.ReadOnly = true;
            this.necessidade.Visible = false;
            // 
            // imagem
            // 
            this.imagem.HeaderText = "imagem";
            this.imagem.Name = "imagem";
            this.imagem.ReadOnly = true;
            this.imagem.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(345, 24);
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
            // tbIdOng
            // 
            this.tbIdOng.Enabled = false;
            this.tbIdOng.Location = new System.Drawing.Point(201, 15);
            this.tbIdOng.Name = "tbIdOng";
            this.tbIdOng.Size = new System.Drawing.Size(42, 23);
            this.tbIdOng.TabIndex = 32;
            // 
            // chbDoado
            // 
            this.chbDoado.AutoSize = true;
            this.chbDoado.BackColor = System.Drawing.Color.Transparent;
            this.chbDoado.Location = new System.Drawing.Point(26, 2);
            this.chbDoado.Name = "chbDoado";
            this.chbDoado.Size = new System.Drawing.Size(61, 19);
            this.chbDoado.TabIndex = 30;
            this.chbDoado.Text = "Doado";
            this.chbDoado.UseVisualStyleBackColor = false;
            // 
            // rbDoacao
            // 
            this.rbDoacao.AutoSize = true;
            this.rbDoacao.Location = new System.Drawing.Point(6, 14);
            this.rbDoacao.Name = "rbDoacao";
            this.rbDoacao.Size = new System.Drawing.Size(65, 19);
            this.rbDoacao.TabIndex = 38;
            this.rbDoacao.TabStop = true;
            this.rbDoacao.Text = "Doação";
            this.rbDoacao.UseVisualStyleBackColor = true;
            // 
            // rbNecessidade
            // 
            this.rbNecessidade.AutoSize = true;
            this.rbNecessidade.Location = new System.Drawing.Point(77, 14);
            this.rbNecessidade.Name = "rbNecessidade";
            this.rbNecessidade.Size = new System.Drawing.Size(91, 19);
            this.rbNecessidade.TabIndex = 38;
            this.rbNecessidade.TabStop = true;
            this.rbNecessidade.Text = "Necessidade";
            this.rbNecessidade.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbDoacao);
            this.groupBox1.Controls.Add(this.rbNecessidade);
            this.groupBox1.Location = new System.Drawing.Point(26, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 40);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btNovo.Image = global::CadastroObjetos.Properties.Resources.icons8_arquivo_20;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(272, 239);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(67, 33);
            this.btNovo.TabIndex = 40;
            this.btNovo.Text = "Novo";
            this.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCadastrarObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroObjetos.Properties.Resources._5254e7f0_1af9_4b25_8b98_904cfd551103__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvObjHistorico);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.tbIdOng);
            this.Controls.Add(this.tbIdObjeto);
            this.Controls.Add(this.chbDoado);
            this.Controls.Add(this.tbObjeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIdPessoa);
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
            this.Load += new System.EventHandler(this.FormCadastrarObjetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjHistorico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private TextBox tbIdPessoa;
        private TextBox tbIdObjeto;
        private PictureBox pbImagem;
        private DataGridView dgvObjHistorico;
        private Label label5;
        private TextBox tbResultado;
        private TextBox tbIdOng;
        private CheckBox chbDoado;
        private DataGridViewTextBoxColumn objeto;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn doado;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn doacao;
        private DataGridViewTextBoxColumn necessidade;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn imagem;
        private RadioButton rbDoacao;
        private RadioButton rbNecessidade;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn idPessoa;
        private DataGridViewTextBoxColumn idOng;
        private Button btNovo;
    }
}