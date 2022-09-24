using Npgsql;
using System.Data;
using System.Reflection;
using System.Text.Json;
using static serverUtils.Utils;

internal class Program {
    static void Main(string[] args) {
        var dt = Select("SELECT * FROM pessoas LIMIT 100");
        foreach(DataRow row in dt.Rows) {
            Console.WriteLine(row["nome"]);
        }
    }

    //Pega um registro pelo id
    public static DataTable Select(string query) {
        DataTable dt = new DataTable();

        var parms = ReadParms();
        string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
        using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
            try {
                //Abre a conexão com o PgSQL                  
                pgsqlConnection.Open();
                //string s = $"SELECT * FROM {GetTableName(dt)} WHERE id = " + id + " LIMIT 100";
                Console.WriteLine(query);

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(query, pgsqlConnection)) {
                    Adpt.Fill(dt);
                }

            } catch (NpgsqlException ex) {
                throw ex;
            } finally {
                pgsqlConnection.Close();
            }
        }
        return dt;
    }

    static string GetTableName(object obj) {
        //busca todas as propriedades do objeto passado e busca o que tiver o nome "tablename"
        var tableNameProperty = obj.GetType().GetProperties().FirstOrDefault(x => x.Name == "tablename");

        //verifica se existe mesmo o tablename no objeto, se não existe volta string em branco
        if (tableNameProperty == null || tableNameProperty.GetValue(obj, null) == null)
            return "";

        // retorna o nome da tabela (o valor de tablename)
        return tableNameProperty.GetValue(obj, null)!.ToString()!;
    }


}