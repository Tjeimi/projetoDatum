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
        CreateInsertQuery(p);
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
        if (!withId) {
            listProperties.RemoveAt(0);
        }
        //retorna a lista de propriedades em formato de array para poder formatar
        return listProperties.ToArray();
    }

}