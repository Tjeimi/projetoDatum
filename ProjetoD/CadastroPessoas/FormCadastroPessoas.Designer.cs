namespace CadastroPessoas
{
    partial class FormCadastroPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPessoas));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomePessoa = new System.Windows.Forms.TextBox();
            this.tbEnderecoPessoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContatoPessoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGravarPessoa = new System.Windows.Forms.Button();
            this.BtnAddItens = new System.Windows.Forms.Button();
            this.DgvPessoas = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.tbIdOng = new System.Windows.Forms.TextBox();
            this.chbAtivo = new System.Windows.Forms.CheckBox();
            this.tbIdPessoa = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tbNomePessoa
            // 
            this.tbNomePessoa.Location = new System.Drawing.Point(27, 46);
            this.tbNomePessoa.Name = "tbNomePessoa";
            this.tbNomePessoa.Size = new System.Drawing.Size(292, 23);
            this.tbNomePessoa.TabIndex = 1;
            // 
            // tbEnderecoPessoa
            // 
            this.tbEnderecoPessoa.Location = new System.Drawing.Point(27, 138);
            this.tbEnderecoPessoa.Name = "tbEnderecoPessoa";
            this.tbEnderecoPessoa.Size = new System.Drawing.Size(292, 23);
            this.tbEnderecoPessoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // tbContatoPessoa
            // 
            this.tbContatoPessoa.Location = new System.Drawing.Point(27, 92);
            this.tbContatoPessoa.Name = "tbContatoPessoa";
            this.tbContatoPessoa.Size = new System.Drawing.Size(292, 23);
            this.tbContatoPessoa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contato";
            // 
            // BtnGravarPessoa
            // 
            this.BtnGravarPessoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnGravarPessoa.Image = global::CadastroPessoas.Properties.Resources.icons8_save_all_20px;
            this.BtnGravarPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGravarPessoa.Location = new System.Drawing.Point(213, 211);
            this.BtnGravarPessoa.Name = "BtnGravarPessoa";
            this.BtnGravarPessoa.Size = new System.Drawing.Size(33, 33);
            this.BtnGravarPessoa.TabIndex = 8;
            this.BtnGravarPessoa.UseVisualStyleBackColor = false;
            this.BtnGravarPessoa.Click += new System.EventHandler(this.BtnGravarPessoa_Click);
            // 
            // BtnAddItens
            // 
            this.BtnAddItens.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAddItens.Enabled = false;
            this.BtnAddItens.Image = global::CadastroPessoas.Properties.Resources.icons8_welfare_20px;
            this.BtnAddItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddItens.Location = new System.Drawing.Point(27, 211);
            this.BtnAddItens.Name = "BtnAddItens";
            this.BtnAddItens.Size = new System.Drawing.Size(180, 33);
            this.BtnAddItens.TabIndex = 9;
            this.BtnAddItens.Text = "Adicionar Itens";
            this.BtnAddItens.UseVisualStyleBackColor = false;
            this.BtnAddItens.Click += new System.EventHandler(this.BtnAddItens_Click);
            // 
            // DgvPessoas
            // 
            this.DgvPessoas.AllowUserToAddRows = false;
            this.DgvPessoas.AllowUserToDeleteRows = false;
            this.DgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoa,
            this.nome,
            this.contato,
            this.cidade,
            this.endereco,
            this.estado,
            this.ativo});
            this.DgvPessoas.Location = new System.Drawing.Point(385, 46);
            this.DgvPessoas.Name = "DgvPessoas";
            this.DgvPessoas.ReadOnly = true;
            this.DgvPessoas.RowHeadersVisible = false;
            this.DgvPessoas.RowTemplate.Height = 25;
            this.DgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPessoas.Size = new System.Drawing.Size(379, 198);
            this.DgvPessoas.TabIndex = 10;
            this.DgvPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPessoas_CellDoubleClick);
            // 
            // idPessoa
            // 
            this.idPessoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPessoa.HeaderText = "idPessoa";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // contato
            // 
            this.contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contato.FillWeight = 50F;
            this.contato.HeaderText = "Contato";
            this.contato.Name = "contato";
            this.contato.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.FillWeight = 25F;
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // ativo
            // 
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.Image = global::CadastroPessoas.Properties.Resources.icons8_search_client_20px;
            this.BtnPesquisar.Location = new System.Drawing.Point(325, 45);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(27, 25);
            this.BtnPesquisar.TabIndex = 11;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(252, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cidade";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "RS"});
            this.cbEstado.Location = new System.Drawing.Point(252, 183);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(67, 23);
            this.cbEstado.TabIndex = 24;
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
            this.cbCidade.Location = new System.Drawing.Point(27, 183);
            this.cbCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(219, 23);
            this.cbCidade.TabIndex = 23;
            // 
            // tbIdOng
            // 
            this.tbIdOng.Enabled = false;
            this.tbIdOng.Location = new System.Drawing.Point(277, 12);
            this.tbIdOng.Name = "tbIdOng";
            this.tbIdOng.Size = new System.Drawing.Size(42, 23);
            this.tbIdOng.TabIndex = 28;
            // 
            // chbAtivo
            // 
            this.chbAtivo.AutoSize = true;
            this.chbAtivo.Location = new System.Drawing.Point(27, 4);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Size = new System.Drawing.Size(54, 19);
            this.chbAtivo.TabIndex = 29;
            this.chbAtivo.Text = "Ativo";
            this.chbAtivo.UseVisualStyleBackColor = true;
            // 
            // tbIdPessoa
            // 
            this.tbIdPessoa.Enabled = false;
            this.tbIdPessoa.Location = new System.Drawing.Point(229, 12);
            this.tbIdPessoa.Name = "tbIdPessoa";
            this.tbIdPessoa.Size = new System.Drawing.Size(42, 23);
            this.tbIdPessoa.TabIndex = 30;
            this.tbIdPessoa.TextChanged += new System.EventHandler(this.tbIdPessoa_TextChanged);
            // 
            // tbResultado
            // 
            this.tbResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbResultado.ForeColor = System.Drawing.Color.White;
            this.tbResultado.Location = new System.Drawing.Point(0, 427);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(800, 23);
            this.tbResultado.TabIndex = 31;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btNovo.Image = global::CadastroPessoas.Properties.Resources.icons8_arquivo_20;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(252, 211);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(67, 33);
            this.btNovo.TabIndex = 32;
            this.btNovo.Text = "Novo";
            this.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroPessoas.Properties.Resources._5254e7f0_1af9_4b25_8b98_904cfd551103__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbIdPessoa);
            this.Controls.Add(this.chbAtivo);
            this.Controls.Add(this.tbIdOng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.DgvPessoas);
            this.Controls.Add(this.BtnAddItens);
            this.Controls.Add(this.BtnGravarPessoa);
            this.Controls.Add(this.tbContatoPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEnderecoPessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomePessoa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroPessoas";
            this.Text = "Cadastro de Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbNomePessoa;
        private TextBox tbEnderecoPessoa;
        private Label label3;
        private TextBox tbContatoPessoa;
        private Label label4;
        private Button BtnGravarPessoa;
        private Button BtnAddItens;
        private DataGridView DgvPessoas;
        private Button BtnPesquisar;
        private Label label2;
        private Label label7;
        private ComboBox cbEstado;
        private ComboBox cbCidade;
        private TextBox tbIdOng;
        private CheckBox chbAtivo;
        private TextBox tbIdPessoa;
        private TextBox tbResultado;
        private Button btNovo;
        private DataGridViewTextBoxColumn idPessoa;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn contato;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn endereco;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn ativo;
    }
}