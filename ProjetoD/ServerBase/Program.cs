 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml;
using MQTTnet;
using MQTTnet.Client;
using Models;
using static datumMQTT.Utils;

internal class Program {
    static async Task Main(string[] args) {
        CheckIfConfigExists();
        await EscutaIssoAsync("datum/save", StartProcessSave);
        await EscutaIssoAsync("datum/delete", StartProcessDelete);
        await EscutaIssoAsync("datum/query", StartProcessQuery);

        //teste
        PessoasModel pessoa = new();
        pessoa.id = 1;
        pessoa.nome = "raynezitos2001";

        BasePacket bp = new();
        bp.model = pessoa;
        bp.processName = "ServerPessoa";

        string payload = JsonSerializer.Serialize(bp);
        Console.WriteLine(payload);
        await PublicaIssoAsync("datum/save",payload);
        //teste

        Console.ReadLine();
    }

    private static void CheckIfConfigExists() {
        string paramDirectoryPath = "C:\\Datum";
        string paramFilePath = "C:\\Datum\\datum.json";
        
        Directory.CreateDirectory(paramDirectoryPath);
        
        if (!File.Exists(paramFilePath)) {
            Models.ParametersModel p = new();
            p.pgServerName = "127.0.0.1";  //localhost
            p.pgPort = "5434";             //porta
            p.pgUserName = "postgres";     //nome do administrador
            p.pgPassword = "1";            //senha do administrador
            p.pgDatabaseName = "datum";    //nome do banco de dados
            string pString = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            using (StreamWriter sw = File.CreateText(paramFilePath)) {
                sw.Write(pString);
            }
        }
    }

    static void StartProcessSave(string payload) {
        try {
            var pl = JsonSerializer.Deserialize<Models.BasePacket>(payload);
            var startInfo = new ProcessStartInfo($"{pl!.processName}.exe");
            startInfo.Arguments = $"Save \"{Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(pl.model)))}\"";
            Process.Start(startInfo);
        } catch(Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
    static void StartProcessDelete(string payload) {
        Console.Write("Delete");
    }
    static void StartProcessQuery(string payload) {
        Console.Write("Query");
    }


}