﻿namespace CadastroObjetos
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
            this.tbImagens = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.BtnGravarObjeto = new System.Windows.Forms.Button();
            this.BtnImagens = new System.Windows.Forms.Button();
            this.BtnApagarImagem = new System.Windows.Forms.Button();
            this.idPessoa = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descrição";
            // 
            // tbImagens
            // 
            this.tbImagens.Location = new System.Drawing.Point(355, 44);
            this.tbImagens.Multiline = true;
            this.tbImagens.Name = "tbImagens";
            this.tbImagens.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbImagens.Size = new System.Drawing.Size(420, 186);
            this.tbImagens.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(355, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Carregar imagens";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(26, 90);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescricao.Size = new System.Drawing.Size(313, 140);
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
            // 
            // BtnImagens
            // 
            this.BtnImagens.BackColor = System.Drawing.Color.Transparent;
            this.BtnImagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnImagens.Image = global::CadastroObjetos.Properties.Resources.icons8_add_image_20px;
            this.BtnImagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImagens.Location = new System.Drawing.Point(356, 45);
            this.BtnImagens.Name = "BtnImagens";
            this.BtnImagens.Size = new System.Drawing.Size(33, 33);
            this.BtnImagens.TabIndex = 25;
            this.BtnImagens.UseVisualStyleBackColor = false;
            // 
            // BtnApagarImagem
            // 
            this.BtnApagarImagem.BackColor = System.Drawing.Color.Transparent;
            this.BtnApagarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnApagarImagem.Image = global::CadastroObjetos.Properties.Resources.icons8_delete_trash_20px;
            this.BtnApagarImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApagarImagem.Location = new System.Drawing.Point(742, 236);
            this.BtnApagarImagem.Name = "BtnApagarImagem";
            this.BtnApagarImagem.Size = new System.Drawing.Size(33, 33);
            this.BtnApagarImagem.TabIndex = 26;
            this.BtnApagarImagem.UseVisualStyleBackColor = false;
            // 
            // idPessoa
            // 
            this.idPessoa.Location = new System.Drawing.Point(297, 15);
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.Size = new System.Drawing.Size(42, 23);
            this.idPessoa.TabIndex = 27;
            // 
            // FormCadastrarObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroObjetos.Properties.Resources._5254e7f0_1af9_4b25_8b98_904cfd551103__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idPessoa);
            this.Controls.Add(this.BtnApagarImagem);
            this.Controls.Add(this.BtnImagens);
            this.Controls.Add(this.BtnGravarObjeto);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbImagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastrarObjetos";
            this.Text = "Cadastro de Objetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCategorias;
        private Label label2;
        private Label label1;
        private TextBox tbImagens;
        private Label label3;
        private TextBox tbDescricao;
        private Button BtnGravarObjeto;
        private Button BtnImagens;
        private Button BtnApagarImagem;
        private TextBox idPessoa;
    }
}