namespace Relatorios
{
    partial class FormRelatórios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatórios));
            this.cbTipoRelatório = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbDataDe = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbAte = new System.Windows.Forms.MaskedTextBox();
            this.BtnCarregarRelatorio = new System.Windows.Forms.Button();
            this.txtPreRelatorio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnImprimirRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTipoRelatório
            // 
            this.cbTipoRelatório.FormattingEnabled = true;
            this.cbTipoRelatório.Items.AddRange(new object[] {
            "Doadores",
            "Necessitados",
            "Doações concluídas",
            "Cidades parceiras",
            "Usuários"});
            this.cbTipoRelatório.Location = new System.Drawing.Point(26, 46);
            this.cbTipoRelatório.Name = "cbTipoRelatório";
            this.cbTipoRelatório.Size = new System.Drawing.Size(206, 23);
            this.cbTipoRelatório.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo de Retalório";
            // 
            // mtbDataDe
            // 
            this.mtbDataDe.Location = new System.Drawing.Point(26, 92);
            this.mtbDataDe.Mask = "00/00/0000";
            this.mtbDataDe.Name = "mtbDataDe";
            this.mtbDataDe.Size = new System.Drawing.Size(100, 23);
            this.mtbDataDe.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data até";
            // 
            // mtbAte
            // 
            this.mtbAte.Location = new System.Drawing.Point(132, 92);
            this.mtbAte.Mask = "00/00/0000";
            this.mtbAte.Name = "mtbAte";
            this.mtbAte.Size = new System.Drawing.Size(100, 23);
            this.mtbAte.TabIndex = 23;
            // 
            // BtnCarregarRelatorio
            // 
            this.BtnCarregarRelatorio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCarregarRelatorio.Image = global::Relatorios.Properties.Resources.icons8_open_document_20px;
            this.BtnCarregarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarregarRelatorio.Location = new System.Drawing.Point(160, 121);
            this.BtnCarregarRelatorio.Name = "BtnCarregarRelatorio";
            this.BtnCarregarRelatorio.Size = new System.Drawing.Size(33, 33);
            this.BtnCarregarRelatorio.TabIndex = 24;
            this.BtnCarregarRelatorio.UseVisualStyleBackColor = false;
            // 
            // txtPreRelatorio
            // 
            this.txtPreRelatorio.Location = new System.Drawing.Point(256, 46);
            this.txtPreRelatorio.Multiline = true;
            this.txtPreRelatorio.Name = "txtPreRelatorio";
            this.txtPreRelatorio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreRelatorio.Size = new System.Drawing.Size(532, 231);
            this.txtPreRelatorio.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(256, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pré visualização do retalório";
            // 
            // BtnImprimirRelatorio
            // 
            this.BtnImprimirRelatorio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnImprimirRelatorio.Image = global::Relatorios.Properties.Resources.icons8_print_20px;
            this.BtnImprimirRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimirRelatorio.Location = new System.Drawing.Point(199, 121);
            this.BtnImprimirRelatorio.Name = "BtnImprimirRelatorio";
            this.BtnImprimirRelatorio.Size = new System.Drawing.Size(33, 33);
            this.BtnImprimirRelatorio.TabIndex = 24;
            this.BtnImprimirRelatorio.UseVisualStyleBackColor = false;
            // 
            // FormRelatórios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Relatorios.Properties.Resources._5254e7f0_1af9_4b25_8b98_904cfd551103__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPreRelatorio);
            this.Controls.Add(this.BtnImprimirRelatorio);
            this.Controls.Add(this.BtnCarregarRelatorio);
            this.Controls.Add(this.mtbAte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbDataDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoRelatório);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatórios";
            this.Text = "Gerar Relatórios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTipoRelatório;
        private Label label2;
        private MaskedTextBox mtbDataDe;
        private Label label1;
        private Label label3;
        private MaskedTextBox mtbAte;
        private Button BtnCarregarRelatorio;
        private TextBox txtPreRelatorio;
        private Label label4;
        private Button BtnImprimirRelatorio;
    }
}