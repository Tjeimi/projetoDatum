using System;
using System.Diagnostics;
internal class Program {
    static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
    static string postgreSQlDirectory = $"{currentDirectory}\\PostgreSQL\\14";
    private static void Main(string[] args) {
        Console.WriteLine("Tentando parar o PostgreSQL caso esteja rodando..");
        StopDB();
        Console.WriteLine("Iniciando PostgreSQL");
        if (Directory.Exists($"{postgreSQlDirectory}\\data")) {
            Console.WriteLine("Inicializando o banco de dados, por favor aguarde...");
        } else {
            Console.WriteLine("Inicializando o banco de dados pela primeira vez, isso pode levar um tempo...");
        }
        StartDB();

        Console.WriteLine("Iniciando MQTT Broker");
        if(!Directory.Exists("C:\\Program Files\\mosquitto")) {
            Console.WriteLine("MQTT Broker não detectado, instalando...");
            Process.Start($"{currentDirectory}\\MQTT\\InstallMQTT.bat");
        }


        Console.WriteLine("Aperte qualquer tecla para parar o banco de dados");
        Console.ReadLine();
        StopDB();
    }

    static void StartDB() {
        ProcessStartInfo pInfo = new ProcessStartInfo();
        pInfo.UseShellExecute = false;
        pInfo.CreateNoWindow = true;
        pInfo.WindowStyle = ProcessWindowStyle.Normal;
        pInfo.FileName = $"{postgreSQlDirectory}\\StartDB.bat";
        Process.Start(pInfo);
    }
    static void StopDB() {
        ProcessStartInfo pInfo = new ProcessStartInfo();
        pInfo.UseShellExecute = false;
        pInfo.CreateNoWindow = true;
        pInfo.WindowStyle = ProcessWindowStyle.Normal;
        pInfo.FileName = $"{postgreSQlDirectory}\\StopDB.bat";
        Process.Start(pInfo);
    }

}