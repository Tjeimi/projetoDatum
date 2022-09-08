using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using MQTTnet;
using MQTTnet.Client;
using static Program;

internal class Program {
    static void Main(string[] args) {
        var pessoaTeste = new PessoasModel();
        pessoaTeste.tablename = "pessoas";
        pessoaTeste.id = 1;
        pessoaTeste.nome = "testevalor1";
        pessoaTeste.idong = 2;
        pessoaTeste.ativo = true;
        CreateInsertQuery(pessoaTeste);
    }

    static void CreateInsertQuery(object obj) {

        Console.WriteLine("INSERT INTO "
                                  + GetTableName(obj)
                                  + $"({GetColumns(obj)}) "
                            + $"VALUES({GetColumnsForValues(obj)}) "
                            + $"ON CONFLICT (id) DO UPDATE "
                            + $"SET {GetColumnsForUpdate(obj)} ");


        Console.WriteLine("");
        var ColumnsAndValues = GetColumnsAndValues(obj);
        foreach (var ColumnAndValue in ColumnsAndValues) {
            Console.WriteLine($"Coluna: {ColumnAndValue.Key}, Valor: {ColumnAndValue.Value}");
        }
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

    static string GetColumns(object obj) {
        //cria uma variavel contendo todas as propriedades do objeto passado por parâmetro
        var tableNameProperties = obj.GetType().GetProperties();
        string columns = "";
        //adiciona todos os nomes das propriedades do objeto para dentro da string columns
        foreach (var prop in tableNameProperties) {
            columns += $", {prop.Name}";
        }
        //remove a propriedade tablename
        columns = columns.Replace(", tablename, ", "");
        //retorna as propriedades do objeto formatado para a query
        return columns;
    }

    static string GetColumnsForValues(object obj) {
        //basicamente a mesma função de cima, mas com uma formatação diferente
        //(para poder adicionar o valor por parâmetros e evitar sqli)
        var tableNameProperties = obj.GetType().GetProperties();
        string columns = "";
        foreach (var prop in tableNameProperties) {
            columns += $", @{prop.Name}";
        }
        columns = columns.Replace(", @tablename, ", "");

        return columns;
    }

    static string GetColumnsForUpdate(object obj) {
        //busca todas as propriedades do objeto
        var tableNameProperties = obj.GetType().GetProperties();
        string columns = "";
        //itera por todas as propriedades que não são o tablename e nem o id
        foreach (var prop in tableNameProperties) {
            if (prop.Name != "tablename") {
                if (prop.Name != "id") {
                    columns += $"{prop.Name} = EXCLUDED.{prop.Name}, ";
                }
            }
        }
        //adiciona o ; para caso ocorra de ficar , ; ele poder substituir por só ;
        columns += ";";
        columns = columns.Replace(", ;", ";");
        return columns;
    }


    static Dictionary<string, string?> GetColumnsAndValues(object obj) {
        //cria um dicionario contendo como chave uma string (onde fica o nome da coluna/nome da propriedade do objeto)
        //e também contendo no valor outra string, essa sendo o nosso valor da propriedade do objeto
        var ColumnsAndValues = new Dictionary<string, string?>();
        //busca a lista de propriedades do objeto
        var props = obj.GetType().GetProperties();
        //itera através da lista de propriedades
        foreach (var prop in props) {
            //adiciona cada propriedade e seu valor ao dicionario
            ColumnsAndValues.Add(prop.Name, prop.GetValue(obj, null).ToString());
        }
        //remove o nome da tabela do dicionario
        ColumnsAndValues.Remove("tablename");
        //retorna o dicionario contendo o nome das propriedades e as colunas
        return ColumnsAndValues;
    }

    public class PessoasModel {
        public string? tablename { get; set; }
        public long? id { get; set; }
        public string? nome { get; set; }
        public long? idong { get; set; }
        public bool? ativo { get; set; }
    }

}