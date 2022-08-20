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
            this.cbCidadesParceiras = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtContatoOng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoOng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeOng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGravarOng = new System.Windows.Forms.Button();
            this.txtDadosOng = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEditarOng = new System.Windows.Forms.Button();
            this.DgvParceiras = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGravarParceira = new System.Windows.Forms.Button();
            this.BtnApagarParceira = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvParceiras)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCidadesParceiras
            // 
            this.cbCidadesParceiras.FormattingEnabled = true;
            this.cbCidadesParceiras.Items.AddRange(new object[] {
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
            this.cbCidadesParceiras.Location = new System.Drawing.Point(569, 41);
            this.cbCidadesParceiras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCidadesParceiras.Name = "cbCidadesParceiras";
            this.cbCidadesParceiras.Size = new System.Drawing.Size(219, 23);
            this.cbCidadesParceiras.TabIndex = 2;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "RS"});
            this.cbEstado.Location = new System.Drawing.Point(250, 178);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(67, 23);
            this.cbEstado.TabIndex = 3;
            // 
            // txtContatoOng
            // 
            this.txtContatoOng.Location = new System.Drawing.Point(25, 133);
            this.txtContatoOng.Name = "txtContatoOng";
            this.txtContatoOng.Size = new System.Drawing.Size(292, 23);
            this.txtContatoOng.TabIndex = 23;
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
            // txtEnderecoOng
            // 
            this.txtEnderecoOng.Location = new System.Drawing.Point(25, 87);
            this.txtEnderecoOng.Name = "txtEnderecoOng";
            this.txtEnderecoOng.Size = new System.Drawing.Size(292, 23);
            this.txtEnderecoOng.TabIndex = 21;
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
            // txtNomeOng
            // 
            this.txtNomeOng.Location = new System.Drawing.Point(25, 41);
            this.txtNomeOng.Name = "txtNomeOng";
            this.txtNomeOng.Size = new System.Drawing.Size(292, 23);
            this.txtNomeOng.TabIndex = 19;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(569, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cidades Parceiras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(250, 159);
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
            this.BtnGravarOng.Location = new System.Drawing.Point(284, 206);
            this.BtnGravarOng.Name = "BtnGravarOng";
            this.BtnGravarOng.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarOng.TabIndex = 24;
            this.BtnGravarOng.UseVisualStyleBackColor = false;
            // 
            // txtDadosOng
            // 
            this.txtDadosOng.Location = new System.Drawing.Point(323, 41);
            this.txtDadosOng.Multiline = true;
            this.txtDadosOng.Name = "txtDadosOng";
            this.txtDadosOng.Size = new System.Drawing.Size(240, 198);
            this.txtDadosOng.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(323, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dados da Ong";
            // 
            // BtnEditarOng
            // 
            this.BtnEditarOng.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditarOng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEditarOng.Image = global::CadastroOngs.Properties.Resources.icons8_pencil_drawing_20px;
            this.BtnEditarOng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarOng.Location = new System.Drawing.Point(530, 242);
            this.BtnEditarOng.Name = "BtnEditarOng";
            this.BtnEditarOng.Size = new System.Drawing.Size(33, 33);
            this.BtnEditarOng.TabIndex = 24;
            this.BtnEditarOng.UseVisualStyleBackColor = false;
            // 
            // DgvParceiras
            // 
            this.DgvParceiras.AllowUserToAddRows = false;
            this.DgvParceiras.AllowUserToDeleteRows = false;
            this.DgvParceiras.AllowUserToOrderColumns = true;
            this.DgvParceiras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvParceiras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoa,
            this.cidade});
            this.DgvParceiras.Location = new System.Drawing.Point(569, 69);
            this.DgvParceiras.Name = "DgvParceiras";
            this.DgvParceiras.ReadOnly = true;
            this.DgvParceiras.RowHeadersVisible = false;
            this.DgvParceiras.RowTemplate.Height = 25;
            this.DgvParceiras.Size = new System.Drawing.Size(219, 170);
            this.DgvParceiras.TabIndex = 26;
            // 
            // idPessoa
            // 
            this.idPessoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPessoa.HeaderText = "idP";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Visible = false;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cidade.FillWeight = 150F;
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
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
            this.cbCidade.Location = new System.Drawing.Point(25, 178);
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
            this.label7.Location = new System.Drawing.Point(25, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cidade";
            // 
            // BtnGravarParceira
            // 
            this.BtnGravarParceira.BackColor = System.Drawing.Color.Transparent;
            this.BtnGravarParceira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGravarParceira.Image = global::CadastroOngs.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarParceira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarParceira.Location = new System.Drawing.Point(755, 242);
            this.BtnGravarParceira.Name = "BtnGravarParceira";
            this.BtnGravarParceira.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarParceira.TabIndex = 24;
            this.BtnGravarParceira.UseVisualStyleBackColor = false;
            // 
            // BtnApagarParceira
            // 
            this.BtnApagarParceira.BackColor = System.Drawing.Color.Transparent;
            this.BtnApagarParceira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnApagarParceira.Image = global::CadastroOngs.Properties.Resources.icons8_delete_trash_20px;
            this.BtnApagarParceira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApagarParceira.Location = new System.Drawing.Point(716, 242);
            this.BtnApagarParceira.Name = "BtnApagarParceira";
            this.BtnApagarParceira.Size = new System.Drawing.Size(33, 33);
            this.BtnApagarParceira.TabIndex = 24;
            this.BtnApagarParceira.UseVisualStyleBackColor = false;
            // 
            // FormCadastroOngs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvParceiras);
            this.Controls.Add(this.txtDadosOng);
            this.Controls.Add(this.BtnEditarOng);
            this.Controls.Add(this.BtnApagarParceira);
            this.Controls.Add(this.BtnGravarParceira);
            this.Controls.Add(this.BtnGravarOng);
            this.Controls.Add(this.txtContatoOng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnderecoOng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeOng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.cbCidadesParceiras);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroOngs";
            this.Text = "Cadastro da ONG";
            ((System.ComponentModel.ISupportInitialize)(this.DgvParceiras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbCidadesParceiras;
        private ComboBox cbEstado;
        private TextBox txtContatoOng;
        private Label label1;
        private TextBox txtEnderecoOng;
        private Label label3;
        private TextBox txtNomeOng;
        private Label label2;
        private Label label6;
        private Label label4;
        private Button BtnGravarOng;
        private TextBox txtDadosOng;
        private Label label5;
        private Button BtnEditarOng;
        private DataGridView DgvParceiras;
        private DataGridViewTextBoxColumn idPessoa;
        private DataGridViewTextBoxColumn cidade;
        private ComboBox cbCidade;
        private Label label7;
        private Button BtnGravarParceira;
        private Button BtnApagarParceira;
    }
}