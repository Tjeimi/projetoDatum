namespace Main
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblNomeOng = new System.Windows.Forms.Label();
            this.BtnOng = new System.Windows.Forms.Button();
            this.btnPessoas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnObjetos = new System.Windows.Forms.Button();
            this.btnDoacoes = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeOng
            // 
            this.lblNomeOng.AutoSize = true;
            this.lblNomeOng.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeOng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeOng.Location = new System.Drawing.Point(231, 92);
            this.lblNomeOng.Name = "lblNomeOng";
            this.lblNomeOng.Size = new System.Drawing.Size(126, 24);
            this.lblNomeOng.TabIndex = 0;
            this.lblNomeOng.Text = "[NOME ONG]";
            // 
            // BtnOng
            // 
            this.BtnOng.Image = global::Main.Properties.Resources.icons8_welfare_50px;
            this.BtnOng.Location = new System.Drawing.Point(125, 147);
            this.BtnOng.Name = "BtnOng";
            this.BtnOng.Size = new System.Drawing.Size(90, 90);
            this.BtnOng.TabIndex = 1;
            this.BtnOng.Text = "ONG";
            this.BtnOng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnOng.UseVisualStyleBackColor = true;
            // 
            // btnPessoas
            // 
            this.btnPessoas.Image = global::Main.Properties.Resources.icons8_people_50px;
            this.btnPessoas.Location = new System.Drawing.Point(242, 263);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Size = new System.Drawing.Size(90, 90);
            this.btnPessoas.TabIndex = 1;
            this.btnPessoas.Text = "PESSOAS";
            this.btnPessoas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPessoas.UseVisualStyleBackColor = true;
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = global::Main.Properties.Resources.icons8_male_user_50px;
            this.btnUsuarios.Location = new System.Drawing.Point(125, 263);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(90, 90);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "USUÁRIOS";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnObjetos
            // 
            this.btnObjetos.Image = global::Main.Properties.Resources.icons8_worldwide_delivery_50px;
            this.btnObjetos.Location = new System.Drawing.Point(242, 147);
            this.btnObjetos.Name = "btnObjetos";
            this.btnObjetos.Size = new System.Drawing.Size(90, 90);
            this.btnObjetos.TabIndex = 1;
            this.btnObjetos.Text = "OBJETOS";
            this.btnObjetos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnObjetos.UseVisualStyleBackColor = true;
            // 
            // btnDoacoes
            // 
            this.btnDoacoes.Image = global::Main.Properties.Resources.icons8_trust_50px;
            this.btnDoacoes.Location = new System.Drawing.Point(360, 147);
            this.btnDoacoes.Name = "btnDoacoes";
            this.btnDoacoes.Size = new System.Drawing.Size(90, 90);
            this.btnDoacoes.TabIndex = 1;
            this.btnDoacoes.Text = "DOAÇÕES";
            this.btnDoacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoacoes.UseVisualStyleBackColor = true;
            // 
            // btnChat
            // 
            this.btnChat.Image = global::Main.Properties.Resources.icons8_bate_papo_cheio_50;
            this.btnChat.Location = new System.Drawing.Point(360, 263);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(90, 90);
            this.btnChat.TabIndex = 1;
            this.btnChat.Text = "CHAT";
            this.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Main.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoacoes);
            this.Controls.Add(this.btnObjetos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnPessoas);
            this.Controls.Add(this.BtnOng);
            this.Controls.Add(this.lblNomeOng);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeOng;
        private Button BtnOng;
        private Button btnPessoas;
        private Button btnUsuarios;
        private Button btnObjetos;
        private Button btnDoacoes;
        private Button btnChat;
    }
}