
using System;
using System.Data;
using Npgsql;

internal class Program {
    static string serverName = "127.0.0.1";  //localhost
    static string port = "5434";             //porta
    static string userName = "postgres";     //nome do administrador
    static string password = "1";            //senha do administrador
    static string databaseName = "datum";    //nome do banco de dados
    NpgsqlConnection pgsqlConnection = null;
    string connString = null;

    public Program(){
    connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                        serverName, port, userName, password, databaseName);
}

    
    //Inserir registros
    public void InserirRegistros()//(string nome)
    {

        try
        {
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
            {
                //Abra a conexão com o PgSQL                  
                pgsqlConnection.Open();

                string cmdInserir = String.Format("INSERT INTO pessoa (id, idong, nome, ativa) VALUES(3, 3, 'teste', FALSE)");

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
            }
        }
        catch (NpgsqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            pgsqlConnection.Close();
        }
    }


    private static void Main(string[] args) {

        Program program = new Program();
        program.InserirRegistros();

    }
}