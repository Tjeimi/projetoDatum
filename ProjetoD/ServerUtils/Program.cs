using System.Text.Json;

namespace serverUtils;
public class Utils {
    //public static Models.ParametersModel ReadParms() {
    //    using (StreamReader r = new StreamReader("C:\\Datum\\datum.json")) {
    //        string json = r.ReadToEnd();
    //        var parms = JsonSerializer.Deserialize<Models.ParametersModel>(json);
    //        return parms!;
    //    }
    //}

    static void Main(string[] args) {
        var p = new Models.PessoasModel();
        p.id = 1;
        CreateInsertQuery(p);
        CreateUpdateQuery(p);
        CreateDeleteQuery(p);
    }

    public static string CreateInsertQuery(object obj) {
        string s = ($"INSERT INTO {GetTableName(obj)}"
                            + $"({GetColumns(obj, false, false, false)}) "
                      + $"VALUES({GetColumns(obj, true, false, false)})");
                     // + $"PARA O UPDATE :) {GetColumns(obj, false, false, true)}");

        Console.WriteLine(s);
        return s;
    }

    public static string CreateUpdateQuery(object obj)
    {
        string s = (@$"UPDATE {GetTableName(obj)} SET {GetColumns(obj, false, false, true)} WHERE ID = {GetId(obj)}");

        Console.WriteLine(s);
        return s;
    }

    public static string CreateDeleteQuery(object obj)
    {
        string s = (@$"DELETE FROM {GetTableName(obj)} WHERE ID = {GetId(obj)}");

        Console.WriteLine(s);
        return s;
    }

    static string GetId(object obj)
    {
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