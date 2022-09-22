using Npgsql;
using System.Data;
using System.Reflection.Emit;
using System.Text.Json;

namespace DatumPostgreSQL {
    public class Utils {

        //Inserir registros
        public static void InserirRegistro(object obj) {
            //var parms = serverUtils.Utils.ReadParms();
            //string connString = $"Server={parms.pgServerName};Port={parms.pgPort};User Id={parms.pgUserName};Password={parms.pgPassword};Database={parms.pgDatabaseName};";
            string connString = "";
            try {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString)) {
                    //Abre a conexão com o PgSQL                  
                    pgsqlConnection.Open();
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(CreateInsertQuery(obj), pgsqlConnection)) {
                        var ColumnsAndValues = GetColumnsAndValues(obj);
                        foreach (var ColumnAndValue in ColumnsAndValues) {
                            pgsqlcommand.Parameters.AddWithValue(ColumnAndValue.Key, ColumnAndValue.Value ?? DBNull.Value);
                        }
                        pgsqlcommand.Prepare();
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            } catch (NpgsqlException ex) {
                throw ex;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public static string CreateInsertQuery(object obj) {
            string s = (@$"INSERT INTO {GetTableName(obj)}({string.Join(",", GetColumns(obj, false, false))}) VALUES({string.Join(",", GetColumns(obj, true, false))})");

            Console.WriteLine(s);
            return s;
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

        static string[] GetColumns(object obj, bool forValue, bool withId) {
            //cria uma variavel contendo todas as propriedades do objeto passado por parâmetro
            var properties = obj.GetType().GetProperties();
            List<string> listProperties = new();

            //adiciona o nome das properties em uma lista
            //caso seja para a parte com os values, adiciona o @ no começo do nome de cada campo
            if (!forValue) {
                foreach (var prop in properties) {
                    listProperties.Add(prop.Name);
                }
            } else {
                foreach (var prop in properties) {
                    listProperties.Add($"@{prop.Name}");
                }
            }


            listProperties.RemoveAt(0);
            //retorna a lista de propriedades em formato de array para poder formatar
            return listProperties.ToArray();
        }


        static Dictionary<string, object?> GetColumnsAndValues(object obj) {
            //cria um dicionario contendo como chave uma string (onde fica o nome da coluna/nome da propriedade do objeto)
            //e também contendo no valor outra string, essa sendo o nosso valor da propriedade do objeto
            var ColumnsAndValues = new Dictionary<string, object?>();
            //busca a lista de propriedades do objeto
            var props = obj.GetType().GetProperties();
            //itera através da lista de propriedades
            foreach (var prop in props) {
                //verifica se o nome da prop é id e se ela é NULL, coloca o valor como DEFAULT porque o postgres é burro
                if(prop.Name == "id" && prop.GetValue(obj, null) == null) {
                    continue;
                }
                //adiciona cada propriedade e seu valor ao dicionario
                ColumnsAndValues.Add(prop.Name, prop.GetValue(obj, null));
            }
            //remove o nome da tabela do dicionario
            ColumnsAndValues.Remove("tablename");
            //retorna o dicionario contendo o nome das propriedades e as colunas
            return ColumnsAndValues;
        }

    }
}