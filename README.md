# Projeto Datum

## Como iniciar o serviço do banco de dados PostgreSQL e broker MQTT local:
1. Primeiramente se certificar de estar com a última versão do projeto fazendo um pull através do git pelo Visual Studio
2. Abrir o terminar dentro do Visual Studio (**CTRL + `**)
3. Digitar "**.\BancoAndMQTT.bat**" no terminal e apertar **ENTER**
4. Tanto o **MQTT** quanto o **PostgreSQL** devem ter iniciado
5. Para encerrar, basta apertar qualquer tecla no terminal do visual studio

## Iniciar o pgAdmin para gerenciamento do banco de dados:
1. Baixar o pgAdmin [**CLICANDO AQUI**](https://drive.google.com/file/d/1aqlDl1laPODF5YSaZxoETOjHGJs4_SPN/view?usp=sharing)
2. Extrair para uma pasta de sua preferência
3. Certificar-se de estar com o serviço do PostgreSQL aberto
4. Abrir o arquivo "pgAdmin4.exe" presente dentro da pasta "...\pgAdmin 4\bin\" que você acabou de extrair
5. Senha para o pgAdmin pode ser qualquer, recomendo colocar "1" para ficar de mais fácil acesso
6. Adicionar um novo servidor, colocando um nome qualquer, no endereço de ip "127.0.0.1", na porta "5434" e clicando em "save"

![image](https://user-images.githubusercontent.com/109689901/187571213-6e88dd0f-bd89-44d0-9df1-f30792b9aa20.png)

7. Se deu tudo certo, o elefante já vai estar aparecendo na parte esquerda pronto para ser usado🐘

## Criar um DATABASE:
1. Botão direito em cima de "Databases" - Create - Database 

![image](https://user-images.githubusercontent.com/109689901/187814883-e21e2c6a-d58a-4c1b-80f7-f8062aee5e19.png)

2. Preencher no campo "Database" o nome "datum" e clicar em "Save"

![image](https://user-images.githubusercontent.com/109689901/187815037-0f84533c-4781-4e4a-b4f0-3df54885f196.png)


## Fazer backup do banco de dados:
1. Botão direito em cima do database e clicar em "Backup..."

![image](https://user-images.githubusercontent.com/109689901/187815247-53fac25a-ffb5-4dda-a0aa-68f98762f385.png)

2. Preencher a localização de onde vai ficar o arquivo .sql (clicar na pastinha ao lado de "Filename")

![image](https://user-images.githubusercontent.com/109689901/187815369-a5c77dd9-a72e-4783-b477-ca8f91af3cc1.png)


![image](https://user-images.githubusercontent.com/109689901/187815441-e1fcaeeb-c1f6-40f8-ab90-071c79c59996.png)

  obs. Coloque .sql no final do nome do arquivo antes de clicar em salvar

3. Marcar as seguintes opções na aba "Options" e clicar em "Backup"

![image](https://user-images.githubusercontent.com/109689901/187815695-730a6d3a-d873-4695-9dab-a0f94fd1399b.png)

## Fazer restore do banco de dados:
1. Recomendo dropar o database atual de vocês antes de dar restore em outro

![image](https://user-images.githubusercontent.com/109689901/187815965-9c0c89e0-1201-4e23-95d7-34648503cb50.png)

2. Criar o banco novamente, ver "Criar um DATABASE"
3. Botão direito em cima do banco vazio, clicar em "Restore"

![image](https://user-images.githubusercontent.com/109689901/187816060-47a75f18-03c6-4ab6-9d9d-1a7f910f66dd.png)

4. Selecionar o arquivo de backup (clicar na pastinha ao lado de "Filename")

![image](https://user-images.githubusercontent.com/109689901/187816106-1092151c-332e-4307-89a6-44a7e30fa0f5.png)



![image](https://user-images.githubusercontent.com/109689901/187816179-3a68efbf-3d41-482e-b81e-6e09b9eb07cb.png)


5. Clicar em "Restore"

![image](https://user-images.githubusercontent.com/109689901/187816208-92e8df36-5eb6-45a3-a973-723d557605b0.png)


## Erro "binary path":

![image](https://user-images.githubusercontent.com/109689901/187816806-3c2c3adb-a459-4dcf-8d60-c8e9c772a9cc.png)

1. File - Preferences

![image](https://user-images.githubusercontent.com/109689901/187816865-55412304-1cb1-45f5-bfc3-ad5f38526d6a.png)

2. "Binary paths"

![image](https://user-images.githubusercontent.com/109689901/187816910-34679be9-20e1-46ef-9081-16ae4e985318.png)

3. Descer até o final onde diz "PostgreSQL 14", clicar na pastinha para selecionar o caminho, selecionar a pasta "bin" do postgres e salvar
Normalmente o caminho é "C:\Users\NOMEDOSEUUSUARIOAQUI\source\repos\projetoDatum\ProjetoD\ServerBin\PostgreSQL\14\bin"

![image](https://user-images.githubusercontent.com/109689901/187816983-24783e4a-2195-4b33-a88a-32d3cfd9994f.png)

![image](https://user-images.githubusercontent.com/109689901/187817129-786522fe-a8b6-4017-9de4-996dc4ad91be.png)

![image](https://user-images.githubusercontent.com/109689901/187817309-cc610992-de7b-47dc-b312-30fc43f14f64.png)


