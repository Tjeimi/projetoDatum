namespace Chat {
    partial class FormChat {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbMensagemEnvio = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChat.BackColor = System.Drawing.SystemColors.Window;
            this.tbChat.Location = new System.Drawing.Point(12, 12);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.ReadOnly = true;
            this.tbChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChat.Size = new System.Drawing.Size(359, 263);
            this.tbChat.TabIndex = 0;
            this.tbChat.TabStop = false;
            // 
            // tbMensagemEnvio
            // 
            this.tbMensagemEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMensagemEnvio.Location = new System.Drawing.Point(12, 281);
            this.tbMensagemEnvio.Name = "tbMensagemEnvio";
            this.tbMensagemEnvio.Size = new System.Drawing.Size(278, 23);
            this.tbMensagemEnvio.TabIndex = 1;
            this.tbMensagemEnvio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMensagemEnvio_KeyDown);
            // 
            // btEnviar
            // 
            this.btEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEnviar.Location = new System.Drawing.Point(296, 280);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 2;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_ClickAsync);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 310);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.tbMensagemEnvio);
            this.Controls.Add(this.tbChat);
            this.Name = "FormChat";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormChat_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbChat;
        private TextBox tbMensagemEnvio;
        private Button btEnviar;
    }
}