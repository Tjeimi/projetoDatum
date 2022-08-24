internal class Program {
    private static void Main(string[] args) {
        string currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
        Console.WriteLine("Iniciando PostgreSQL");
        if (!Directory.Exists($"{currentDirectory}\\PostgreSQL\\14\\data")) {
            Console.WriteLine("Teste");
        }
    }
}