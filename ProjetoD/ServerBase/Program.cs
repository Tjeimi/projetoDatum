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
        await EscutarAsync("datum/server", StartProcess);
        Console.WriteLine("Servidor iniciado, você pode minimizar essa janela agora :)");
        Console.WriteLine("Clique em qualquer tecla para encerrar o servidor");
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

    static void StartProcess(string pacote) {
        try {
            var pkt = JsonSerializer.Deserialize<BasePacket>(pacote);
            var startInfo = new ProcessStartInfo($"{pkt!.serverName}.exe");
            startInfo.Arguments = $"{pkt.action} {pkt.responseTopic} \"{Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(pkt.dados)))}\"";
            Process.Start(startInfo);
        } catch(Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

}