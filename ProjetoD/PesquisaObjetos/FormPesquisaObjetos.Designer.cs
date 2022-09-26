namespace PesquisaObjetos
{
    partial class FormPesquisaObjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaObjetos));
            this.DgvPesquisaObjetos = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.BtnPesquisarObjetos = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPesquisaObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPesquisaObjetos
            // 
            this.DgvPesquisaObjetos.AllowUserToAddRows = false;
            this.DgvPesquisaObjetos.AllowUserToDeleteRows = false;
            this.DgvPesquisaObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPesquisaObjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoa,
            this.categoriaO,
            this.descricao,
            this.tipo});
            this.DgvPesquisaObjetos.Location = new System.Drawing.Point(12, 73);
            this.DgvPesquisaObjetos.Name = "DgvPesquisaObjetos";
            this.DgvPesquisaObjetos.ReadOnly = true;
            this.DgvPesquisaObjetos.RowHeadersVisible = false;
            this.DgvPesquisaObjetos.RowTemplate.Height = 25;
            this.DgvPesquisaObjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPesquisaObjetos.Size = new System.Drawing.Size(776, 343);
            this.DgvPesquisaObjetos.TabIndex = 11;
            // 
            // idPessoa
            // 
            this.idPessoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPessoa.HeaderText = "idPessoa";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Visible = false;
            // 
            // categoriaO
            // 
            this.categoriaO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoriaO.FillWeight = 50F;
            this.categoriaO.HeaderText = "Categoria";
            this.categoriaO.Name = "categoriaO";
            this.categoriaO.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.FillWeight = 25F;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(12, 44);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(418, 23);
            this.tbDescricao.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(436, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Categoria do objeto";
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
            this.cbCategorias.Location = new System.Drawing.Point(436, 44);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(313, 23);
            this.cbCategorias.TabIndex = 20;
            // 
            // BtnPesquisarObjetos
            // 
            this.BtnPesquisarObjetos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnPesquisarObjetos.Image = global::PesquisaObjetos.Properties.Resources.icons8_search_20px;
            this.BtnPesquisarObjetos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisarObjetos.Location = new System.Drawing.Point(755, 34);
            this.BtnPesquisarObjetos.Name = "BtnPesquisarObjetos";
            this.BtnPesquisarObjetos.Size = new System.Drawing.Size(33, 33);
            this.BtnPesquisarObjetos.TabIndex = 22;
            this.BtnPesquisarObjetos.UseVisualStyleBackColor = false;
            this.BtnPesquisarObjetos.Click += new System.EventHandler(this.BtnPesquisarObjetos_Click);
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
            // FormPesquisaObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.BtnPesquisarObjetos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.DgvPesquisaObjetos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesquisaObjetos";
            this.Text = "Pesquisar objetos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPesquisaObjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvPesquisaObjetos;
        private TextBox tbDescricao;
        private Label label1;
        private Label label2;
        private ComboBox cbCategorias;
        private Button BtnPesquisarObjetos;
        private DataGridViewTextBoxColumn idPessoa;
        private DataGridViewTextBoxColumn categoriaO;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn tipo;
        private TextBox tbResultado;
    }
}