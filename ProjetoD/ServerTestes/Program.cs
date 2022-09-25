using Models;
using Npgsql;
using System.Data;
using System.Reflection;
using System.Text.Json;
using static serverUtils.Utils;

internal class Program {
    static void Main(string[] args) {
        List<PessoasModel?> pessoasList = new();
        pessoasList = (List<PessoasModel?>)Select<PessoasModel?>();
        

    }

    //Pega um registro pelo id
    public static object Select<tipo>() {
        DataTable dt = new DataTable();

        var parms = ReadParms();
        string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
        using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
            try {
                //Abre a conexão com o PgSQL                  
                pgsqlConnection.Open();
                object? objeto = new();
                string query = $"SELECT * FROM {(tipo)objeto.GetType().GetProperties()[0].GetValue(objeto)!} LIMIT 1000";
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
        List<object?> resultados = new();
        foreach (DataRow row in dt.Rows) {
            object? objeto = new();
            foreach (var prop in ((tipo)objeto).GetType().GetProperties()) {
                if (prop.Name == "tablename")
                    continue;
                if (row[prop.Name].GetType() == typeof(DBNull)) {
                    prop.SetValue(objeto, null);
                    continue;
                }
                prop.SetValue(objeto, row[prop.Name]);
            }
            resultados.Add(objeto);
        }
        return resultados;
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