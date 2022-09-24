using Npgsql;
using System.Data;
using System.Reflection;
using System.Text.Json;

internal class Program {

    //Pega um registro pelo id
    public DataTable GetRegistroPorId(int id)
    {
        DataTable dt = new DataTable();

        try
        {
            var parms = ReadParms();
            string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
            {
                //Abre a conexão com o PgSQL                  
                pgsqlConnection.Open();
                string s = $"SELECT * FROM {GetTableName(dt)} WHERE id = " + id;
                Console.WriteLine(s);

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(s, pgsqlConnection))
                {
                    Adpt.Fill(dt);
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
        return dt;
    }

    static string GetTableName(object obj)
    {
        //busca todas as propriedades do objeto passado e busca o que tiver o nome "tablename"
        var tableNameProperty = obj.GetType().GetProperties().FirstOrDefault(x => x.Name == "tablename");

        //verifica se existe mesmo o tablename no objeto, se não existe volta string em branco
        if (tableNameProperty == null || tableNameProperty.GetValue(obj, null) == null)
            return "";

        // retorna o nome da tabela (o valor de tablename)
        return tableNameProperty.GetValue(obj, null)!.ToString()!;
    }

   
}