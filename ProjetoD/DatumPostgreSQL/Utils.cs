using Npgsql;
using System.Data;
using System.Reflection.Emit;
using System.Text.Json;
using static serverUtils.Utils;

namespace DatumPostgreSQL {
    public class Utils {


        public static long? InserirRegistro(object obj) {
            var parms = ReadParms();
            string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
                //Abre a conexão com o PgSQL                  
                try {
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(CreateInsertQuery(obj), pgsqlConnection)) {
                        pgsqlConnection.Open();
                        var ColumnsAndValues = GetColumnsAndValues(obj);
                        foreach (var ColumnAndValue in ColumnsAndValues) {
                            pgsqlcommand.Parameters.AddWithValue(ColumnAndValue.Key, ColumnAndValue.Value ?? DBNull.Value);
                        }
                        pgsqlcommand.Prepare();
                        var res = pgsqlcommand.ExecuteScalar();
                        return Convert.ToInt64(res);
                    }
                } catch (NpgsqlException ex) {
                    Console.WriteLine(ex);
                    throw ex;
                } finally {
                    pgsqlConnection.Close();
                }
            }
        }

        public static void UpdateRegistro(object obj) {
            var parms = ReadParms();
            string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
                //Abre a conexão com o PgSQL                  
                try {
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(CreateUpdateQuery(obj), pgsqlConnection)) {
                        pgsqlConnection.Open();
                        var ColumnsAndValues = GetColumnsAndValues(obj);
                        foreach (var ColumnAndValue in ColumnsAndValues) {
                            pgsqlcommand.Parameters.AddWithValue(ColumnAndValue.Key, ColumnAndValue.Value ?? DBNull.Value);
                        }
                        pgsqlcommand.Prepare();
                        pgsqlcommand.ExecuteNonQuery();
                    }
                } catch (NpgsqlException ex) {
                    Console.WriteLine(ex);
                    throw ex;
                } finally {
                    pgsqlConnection.Close();
                }
            }
        }

        public static List<T> BuscarUltimosMil<T>(string tablename) {
            DataTable dt = new DataTable();

            var parms = ReadParms();
            string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
                try {
                    //Abre a conexão com o PgSQL                  
                    pgsqlConnection.Open();
                    string query = $"SELECT * FROM {tablename} ORDER BY id DESC LIMIT 1000";
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

        public static List<T> QueryLivre<T>(string query) {
            DataTable dt = new DataTable();

            var parms = ReadParms();
            string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
                try {
                    //Abre a conexão com o PgSQL                  
                    pgsqlConnection.Open();
                    //string query = $"SELECT * FROM {tablename} ORDER BY id DESC LIMIT 1000";
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


        static Dictionary<string, object?> GetColumnsAndValues(object obj) {
            //cria um dicionario contendo como chave uma string (onde fica o nome da coluna/nome da propriedade do objeto)
            //e também contendo no valor outra string, essa sendo o nosso valor da propriedade do objeto
            var ColumnsAndValues = new Dictionary<string, object?>();
            //busca a lista de propriedades do objeto
            var props = obj.GetType().GetProperties();
            //itera através da lista de propriedades
            foreach (var prop in props) {
                //adiciona cada propriedade e seu valor ao dicionario
                ColumnsAndValues.Add(prop.Name, prop.GetValue(obj, null));
            }
            //remove o nome da tabela do dicionario
            ColumnsAndValues.Remove("tablename");
            //remove o id do dicionario
            ColumnsAndValues.Remove("id");
            foreach (var col in ColumnsAndValues)
                Console.WriteLine(col.Key + col.Value);
            //retorna o dicionario contendo o nome das propriedades e as colunas
            return ColumnsAndValues;
        }

        public static string CreateInsertQuery(object obj) {
            string s = ($"INSERT INTO {GetTableName(obj)}"
                                + $"({GetColumns(obj, false, false, false)}) "
                          + $"VALUES ({GetColumns(obj, true, false, false)}) RETURNING id");

            Console.WriteLine(s);
            return s;
        }

        public static string CreateUpdateQuery(object obj) {
            string s = (@$"UPDATE {GetTableName(obj)} SET {GetColumns(obj, false, false, true)} WHERE ID = {GetId(obj)}");

            Console.WriteLine(s);
            return s;
        }

        public static string CreateDeleteQuery(object obj) {
            string s = (@$"DELETE FROM {GetTableName(obj)} WHERE ID = {GetId(obj)}");

            Console.WriteLine(s);
            return s;
        }

        static string GetId(object obj) {
            //busca todas as propriedades do objeto passado e busca o que tiver o nome "id"
            var idProperty = obj.GetType().GetProperties().FirstOrDefault(x => x.Name == "id");

            //verifica se existe mesmo o id no objeto, se não existe volta string em branco
            if (idProperty == null || idProperty.GetValue(obj, null) == null)
                return "";

            // retorna o id (o valor de id)
            return idProperty.GetValue(obj, null)!.ToString()!;
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

        static string GetColumns(object obj, bool forValue, bool withId, bool forUpdate) {
            //cria uma variavel contendo todas as propriedades do objeto passado por parâmetro
            var properties = obj.GetType().GetProperties();
            List<string> listProperties = new();

            //adiciona o nome das properties em uma lista
            //caso seja para a parte com os values, adiciona o @ no começo do nome de cada campo
            if (forValue) {
                foreach (var prop in properties) {
                    listProperties.Add($"@{prop.Name}");
                }
            }

            //se não for para os values
            if (!forValue) {
                foreach (var prop in properties) {
                    listProperties.Add(prop.Name);
                }
            }

            //se for para o update
            if (forUpdate) {
                foreach (var prop in properties) {
                    listProperties.RemoveAt(0);
                    listProperties.Add($"{prop.Name} = @{prop.Name}");
                }
            }


            //remove o nome da tabela
            listProperties.RemoveAt(0);

            //se for com id ja retorna a lista
            if (withId) {
                return string.Join(",", listProperties.ToArray());
            }

            //remove o id
            listProperties.RemoveAt(0);

            //retorna a lista de propriedades em formato de array para poder formatar com a virgula
            return string.Join(", ", listProperties.ToArray());
        }

    }
}