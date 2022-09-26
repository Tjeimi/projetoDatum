namespace CadastroOngs
{
    partial class FormCadastroOngs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroOngs));
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbContatoOng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEnderecoOng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeOng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGravarOng = new System.Windows.Forms.Button();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idOng = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "RS"});
            this.cbEstado.Location = new System.Drawing.Point(250, 225);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(67, 23);
            this.cbEstado.TabIndex = 3;
            // 
            // tbContatoOng
            // 
            this.tbContatoOng.Location = new System.Drawing.Point(25, 133);
            this.tbContatoOng.Name = "tbContatoOng";
            this.tbContatoOng.Size = new System.Drawing.Size(292, 23);
            this.tbContatoOng.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Contato";
            // 
            // tbEnderecoOng
            // 
            this.tbEnderecoOng.Location = new System.Drawing.Point(25, 87);
            this.tbEnderecoOng.Name = "tbEnderecoOng";
            this.tbEnderecoOng.Size = new System.Drawing.Size(292, 23);
            this.tbEnderecoOng.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Endereço";
            // 
            // tbNomeOng
            // 
            this.tbNomeOng.Location = new System.Drawing.Point(25, 41);
            this.tbNomeOng.Name = "tbNomeOng";
            this.tbNomeOng.Size = new System.Drawing.Size(292, 23);
            this.tbNomeOng.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome da ONG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(250, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "UF";
            // 
            // BtnGravarOng
            // 
            this.BtnGravarOng.BackColor = System.Drawing.Color.Transparent;
            this.BtnGravarOng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGravarOng.Image = global::CadastroOngs.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarOng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarOng.Location = new System.Drawing.Point(284, 253);
            this.BtnGravarOng.Name = "BtnGravarOng";
            this.BtnGravarOng.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarOng.TabIndex = 24;
            this.BtnGravarOng.UseVisualStyleBackColor = false;
            this.BtnGravarOng.Click += new System.EventHandler(this.BtnGravarOng_Click);
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Items.AddRange(new object[] {
            "Aceguá",
            "Água Santa",
            "Agudo",
            "Ajuricaba",
            "Alecrim",
            "Alegrete",
            "Alegria",
            "Almirante Tamandaré do Sul",
            "Alpestre",
            "Alto Alegre",
            "Alto Feliz",
            "Alvorada",
            "Amaral Ferrador",
            "Ametista do Sul",
            "André da Rocha",
            "Anta Gorda",
            "Antônio Prado",
            "Arambaré",
            "Araricá",
            "Aratiba",
            "Arroio do Meio",
            "Arroio do Padre",
            "Arroio do Sal",
            "Arroio do Tigre",
            "Arroio dos Ratos",
            "Arroio Grande",
            "Arvorezinha",
            "Augusto Pestana",
            "Áurea",
            "Bagé",
            "Balneário Pinhal",
            "Barão",
            "Barão de Cotegipe",
            "Barão do Triunfo",
            "Barra do Guarita",
            "Barra do Quaraí",
            "Barra do Ribeiro",
            "Barra do Rio Azul",
            "Barra Funda",
            "Barracão",
            "Barros Cassal",
            "Benjamin Constant do Sul",
            "Bento Gonçalves",
            "Boa Vista das Missões",
            "Boa Vista do Buricá",
            "Boa Vista do Cadeado",
            "Boa Vista do Incra",
            "Boa Vista do Sul",
            "Bom Jesus",
            "Bom Princípio",
            "Bom Progresso",
            "Bom Retiro do Sul",
            "Boqueirão do Leão",
            "Bossoroca",
            "Bozano",
            "Braga",
            "Brochier",
            "Butiá",
            "Caçapava do Sul",
            "Cacequi",
            "Cachoeira do Sul",
            "Cachoeirinha",
            "Cacique Doble",
            "Caibaté",
            "Caiçara",
            "Camaquã",
            "Camargo",
            "Cambará do Sul",
            "Campestre da Serra",
            "Campina das Missões",
            "Campinas do Sul",
            "Campo Bom",
            "Campo Novo",
            "Campos Borges",
            "Candelária",
            "Cândido Godói",
            "Candiota",
            "Canela",
            "Canguçu",
            "Canoas",
            "Canudos do Vale",
            "Capão Bonito do Sul",
            "Capão da Canoa",
            "Capão do Cipó",
            "Capão do Leão",
            "Capela de Santana",
            "Capitão",
            "Capivari do Sul",
            "Caraá",
            "Carazinho",
            "Carlos Barbosa",
            "Carlos Gomes",
            "Casca",
            "Caseiros",
            "Catuípe",
            "Caxias do Sul",
            "Centenário",
            "Cerrito",
            "Cerro Branco",
            "Cerro Grande",
            "Cerro Grande do Sul",
            "Cerro Largo",
            "Chapada",
            "Charqueadas",
            "Charrua",
            "Chiapetta",
            "Chuí",
            "Chuvisca",
            "Cidreira",
            "Ciríaco",
            "Colinas",
            "Colorado",
            "Condor",
            "Constantina",
            "Coqueiro Baixo",
            "Coqueiros do Sul",
            "Coronel Barros",
            "Coronel Bicaco",
            "Coronel Pilar",
            "Cotiporã",
            "Coxilha",
            "Crissiumal",
            "Cristal",
            "Cristal do Sul",
            "Cruz Alta",
            "Cruzaltense",
            "Cruzeiro do Sul",
            "David Canabarro",
            "Derrubadas",
            "Dezesseis de Novembro",
            "Dilermando de Aguiar",
            "Dois Irmãos",
            "Dois Irmãos das Missões",
            "Dois Lajeados",
            "Dom Feliciano",
            "Dom Pedrito",
            "Dom Pedro de Alcântara",
            "Dona Francisca",
            "Doutor Maurício Cardoso",
            "Doutor Ricardo",
            "Eldorado do Sul",
            "Encantado",
            "Encruzilhada do Sul",
            "Engenho Velho",
            "Entre Rios do Sul",
            "Entre-Ijuís",
            "Erebango",
            "Erechim",
            "Ernestina",
            "Erval Grande",
            "Erval Seco",
            "Esmeralda",
            "Esperança do Sul",
            "Espumoso",
            "Estação",
            "Estância Velha",
            "Esteio",
            "Estrela",
            "Estrela Velha",
            "Eugênio de Castro",
            "Fagundes Varela",
            "Farroupilha",
            "Faxinal do Soturno",
            "Faxinalzinho",
            "Fazenda Vilanova",
            "Feliz",
            "Flores da Cunha",
            "Floriano Peixoto",
            "Fontoura Xavier",
            "Formigueiro",
            "Forquetinha",
            "Fortaleza dos Valos",
            "Frederico Westphalen",
            "Garibaldi",
            "Garruchos",
            "Gaurama",
            "General Câmara",
            "Gentil",
            "Getúlio Vargas",
            "Giruá",
            "Glorinha",
            "Gramado",
            "Gramado dos Loureiros",
            "Gramado Xavier",
            "Gravataí",
            "Guabiju",
            "Guaíba",
            "Guaporé",
            "Guarani das Missões",
            "Harmonia",
            "Herval",
            "Herveiras",
            "Horizontina",
            "Hulha Negra",
            "Humaitá",
            "Ibarama",
            "Ibiaçá",
            "Ibiraiaras",
            "Ibirapuitã",
            "Ibirubá",
            "Igrejinha",
            "Ijuí",
            "Ilópolis",
            "Imbé",
            "Imigrante",
            "Independência",
            "Inhacorá",
            "Ipê",
            "Ipiranga do Sul",
            "Iraí",
            "Itaara",
            "Itacurubi",
            "Itapuca",
            "Itaqui",
            "Itati",
            "Itatiba do Sul",
            "Ivorá",
            "Ivoti",
            "Jaboticaba",
            "Jacuizinho",
            "Jacutinga",
            "Jaguarão",
            "Jaguari",
            "Jaquirana",
            "Jari",
            "Jóia",
            "Júlio de Castilhos",
            "Lagoa Bonita do Sul",
            "Lagoa dos Três Cantos",
            "Lagoa Vermelha",
            "Lagoão",
            "Lajeado",
            "Lajeado do Bugre",
            "Lavras do Sul",
            "Liberato Salzano",
            "Lindolfo Collor",
            "Linha Nova",
            "Maçambará",
            "Machadinho",
            "Mampituba",
            "Manoel Viana",
            "Maquiné",
            "Maratá",
            "Marau",
            "Marcelino Ramos",
            "Mariana Pimentel",
            "Mariano Moro",
            "Marques de Souza",
            "Mata",
            "Mato Castelhano",
            "Mato Leitão",
            "Mato Queimado",
            "Maximiliano de Almeida",
            "Minas do Leão",
            "Miraguaí",
            "Montauri",
            "Monte Alegre dos Campos",
            "Monte Belo do Sul",
            "Montenegro",
            "Mormaço",
            "Morrinhos do Sul",
            "Morro Redondo",
            "Morro Reuter",
            "Mostardas",
            "Muçum",
            "Muitos Capões",
            "Muliterno",
            "Não-Me-Toque",
            "Nicolau Vergueiro",
            "Nonoai",
            "Nova Alvorada",
            "Nova Araçá",
            "Nova Bassano",
            "Nova Boa Vista",
            "Nova Bréscia",
            "Nova Candelária",
            "Nova Esperança do Sul",
            "Nova Hartz",
            "Nova Pádua",
            "Nova Palma",
            "Nova Petrópolis",
            "Nova Prata",
            "Nova Ramada",
            "Nova Roma do Sul",
            "Nova Santa Rita",
            "Novo Barreiro",
            "Novo Cabrais",
            "Novo Hamburgo",
            "Novo Machado",
            "Novo Tiradentes",
            "Novo Xingu",
            "Osório",
            "Paim Filho",
            "Palmares do Sul",
            "Palmeira das Missões",
            "Palmitinho",
            "Panambi",
            "Pantano Grande",
            "Paraí",
            "Paraíso do Sul",
            "Pareci Novo",
            "Parobé",
            "Passa Sete",
            "Passo do Sobrado",
            "Passo Fundo",
            "Paulo Bento",
            "Paverama",
            "Pedras Altas",
            "Pedro Osório",
            "Pejuçara",
            "Pelotas",
            "Picada Café",
            "Pinhal",
            "Pinhal da Serra",
            "Pinhal Grande",
            "Pinheirinho do Vale",
            "Pinheiro Machado",
            "Pinto Bandeira",
            "Pirapó",
            "Piratini",
            "Planalto",
            "Poço das Antas",
            "Pontão",
            "Ponte Preta",
            "Portão",
            "Porto Alegre",
            "Porto Lucena",
            "Porto Mauá",
            "Porto Vera Cruz",
            "Porto Xavier",
            "Pouso Novo",
            "Presidente Lucena",
            "Progresso",
            "Protásio Alves",
            "Putinga",
            "Quaraí",
            "Quatro Irmãos",
            "Quevedos",
            "Quinze de Novembro",
            "Redentora",
            "Relvado",
            "Restinga Sêca",
            "Rio dos Índios",
            "Rio Grande",
            "Rio Pardo",
            "Riozinho",
            "Roca Sales",
            "Rodeio Bonito",
            "Rolador",
            "Rolante",
            "Ronda Alta",
            "Rondinha",
            "Roque Gonzales",
            "Rosário do Sul",
            "Sagrada Família",
            "Saldanha Marinho",
            "Salto do Jacuí",
            "Salvador das Missões",
            "Salvador do Sul",
            "Sananduva",
            "Santa Bárbara do Sul",
            "Santa Cecília do Sul",
            "Santa Clara do Sul",
            "Santa Cruz do Sul",
            "Santa Margarida do Sul",
            "Santa Maria",
            "Santa Maria do Herval",
            "Santa Rosa",
            "Santa Tereza",
            "Santa Vitória do Palmar",
            "Santana da Boa Vista",
            "Sant\'Ana do Livramento",
            "Santiago",
            "Santo Ângelo",
            "Santo Antônio da Patrulha",
            "Santo Antônio das Missões",
            "Santo Antônio do Palma",
            "Santo Antônio do Planalto",
            "Santo Augusto",
            "Santo Cristo",
            "Santo Expedito do Sul",
            "São Borja",
            "São Domingos do Sul",
            "São Francisco de Assis",
            "São Francisco de Paula",
            "São Gabriel",
            "São Jerônimo",
            "São João da Urtiga",
            "São João do Polêsine",
            "São Jorge",
            "São José das Missões",
            "São José do Herval",
            "São José do Hortêncio",
            "São José do Inhacorá",
            "São José do Norte",
            "São José do Ouro",
            "São José do Sul",
            "São José dos Ausentes",
            "São Leopoldo",
            "São Lourenço do Sul",
            "São Luiz Gonzaga",
            "São Marcos",
            "São Martinho",
            "São Martinho da Serra",
            "São Miguel das Missões",
            "São Nicolau",
            "São Paulo das Missões",
            "São Pedro da Serra",
            "São Pedro das Missões",
            "São Pedro do Butiá",
            "São Pedro do Sul",
            "São Sebastião do Caí",
            "São Sepé",
            "São Valentim",
            "São Valentim do Sul",
            "São Valério do Sul",
            "São Vendelino",
            "São Vicente do Sul",
            "Sapiranga",
            "Sapucaia do Sul",
            "Sarandi",
            "Seberi",
            "Sede Nova",
            "Segredo",
            "Selbach",
            "Senador Salgado Filho",
            "Sentinela do Sul",
            "Serafina Corrêa",
            "Sério",
            "Sertão",
            "Sertão Santana",
            "Sete de Setembro",
            "Severiano de Almeida",
            "Silveira Martins",
            "Sinimbu",
            "Sobradinho",
            "Soledade",
            "Tabaí",
            "Tapejara",
            "Tapera",
            "Tapes",
            "Taquara",
            "Taquari",
            "Taquaruçu do Sul",
            "Tavares",
            "Tenente Portela",
            "Terra de Areia",
            "Teutônia",
            "Tio Hugo",
            "Tiradentes do Sul",
            "Toropi",
            "Torres",
            "Tramandaí",
            "Travesseiro",
            "Três Arroios",
            "Três Cachoeiras",
            "Três Coroas",
            "Três de Maio",
            "Três Forquilhas",
            "Três Palmeiras",
            "Três Passos",
            "Trindade do Sul",
            "Triunfo",
            "Tucunduva",
            "Tunas",
            "Tupanci do Sul",
            "Tupanciretã",
            "Tupandi",
            "Tuparendi",
            "Turuçu",
            "Ubiretama",
            "União da Serra",
            "Unistalda",
            "Uruguaiana",
            "Vacaria",
            "Vale do Sol",
            "Vale Real",
            "Vale Verde",
            "Vanini",
            "Venâncio Aires",
            "Vera Cruz",
            "Veranópolis",
            "Vespasiano Corrêa",
            "Viadutos",
            "Viamão",
            "Vicente Dutra",
            "Victor Graeff",
            "Vila Flores",
            "Vila Lângaro",
            "Vila Maria",
            "Vila Nova do Sul",
            "Vista Alegre",
            "Vista Alegre do Prata",
            "Vista Gaúcha",
            "Vitória das Missões",
            "Westfália",
            "Xangri-lá"});
            this.cbCidade.Location = new System.Drawing.Point(25, 225);
            this.cbCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(219, 23);
            this.cbCidade.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cidade";
            // 
            // idOng
            // 
            this.idOng.Enabled = false;
            this.idOng.Location = new System.Drawing.Point(273, 12);
            this.idOng.Name = "idOng";
            this.idOng.Size = new System.Drawing.Size(44, 23);
            this.idOng.TabIndex = 27;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(25, 180);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(292, 23);
            this.tbEmail.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "E-mail";
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
            // FormCadastroOngs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idOng);
            this.Controls.Add(this.BtnGravarOng);
            this.Controls.Add(this.tbContatoOng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEnderecoOng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomeOng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbCidade);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroOngs";
            this.Text = "Cadastro da ONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbEstado;
        private TextBox tbContatoOng;
        private Label label1;
        private TextBox tbEnderecoOng;
        private Label label3;
        private TextBox tbNomeOng;
        private Label label2;
        private Label label4;
        private Button BtnGravarOng;
        private TextBox txtDadosOng;
        private Label label5;
        private ComboBox cbCidade;
        private Label label7;
        private TextBox idOng;
        private TextBox tbEmail;
        private Label label8;
        private TextBox tbResultado;
    }
}