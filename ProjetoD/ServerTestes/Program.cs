using Models;
using Npgsql;
using System.Data;
using System.Reflection;
using System.Text.Json;
using static serverUtils.Utils;

internal class Program {
    static void Main(string[] args) {
        List<PessoasModel> pessoasList = new();
        pessoasList = Select<PessoasModel>("pessoas");
        foreach(var p in pessoasList) {
            Console.WriteLine(p.nome);
        }

    }

    //Pega um registro pelo id
    public static List<T> Select<T>(string tablename) {
        DataTable dt = new DataTable();

        var parms = ReadParms();
        string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
        using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
            try {
                //Abre a conexão com o PgSQL                  
                pgsqlConnection.Open();
                string query = $"SELECT * FROM {tablename} LIMIT 1000";
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
        List<T> resultados = new();
        foreach (DataRow row in dt.Rows) {
            var objeto = (T)Activator.CreateInstance(typeof(T))!;
            foreach (var prop in (objeto).GetType().GetProperties()) {
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


}