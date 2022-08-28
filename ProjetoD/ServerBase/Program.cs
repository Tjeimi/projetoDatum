using System.Text.Json;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;

internal class Program {
    static async Task Main(string[] args) {

        await EscutaIssoAqui();

        //var jsonPai = JsonSerializer.Deserialize<JsonPai>(json);
    }

    //public class JsonPai {
    //    public string? Server { get; set; }
    //    public string? JsonFilho { get; set; }
    //}

    public static async Task EscutaIssoAqui() {
        IManagedMqttClient _mqttClient = new MqttFactory().CreateManagedMqttClient();

        // Create client options object
        MqttClientOptionsBuilder builder = new MqttClientOptionsBuilder()
                                        .WithTcpServer("localhost", 1884);
        ManagedMqttClientOptions options = new ManagedMqttClientOptionsBuilder()
                        .WithAutoReconnectDelay(TimeSpan.FromSeconds(60))
                        .WithClientOptions(builder.Build())
                        .Build();


        // Set up handlers
        _mqttClient.ConnectedAsync += _mqttClient_ConnectedAsync;


        _mqttClient.DisconnectedAsync += _mqttClient_DisconnectedAsync;


        _mqttClient.ConnectingFailedAsync += _mqttClient_ConnectingFailedAsync;

        // Connect to the broker
        await _mqttClient.StartAsync(options);

        // Send a new message to the broker every second
        while (true) {
            string json = JsonSerializer.Serialize(new { message = "Hi Mqtt", sent = DateTime.UtcNow });
            await _mqttClient.EnqueueAsync("behroozbc.ir/topic/json", json);

            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        Task _mqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg) {
            Console.WriteLine("Connected");
            return Task.CompletedTask;
        };
        Task _mqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg) {
            Console.WriteLine("Disconnected");
            return Task.CompletedTask;
        };
        Task _mqttClient_ConnectingFailedAsync(ConnectingFailedEventArgs arg) {
            Console.WriteLine("Connection failed check network or broker!");
            return Task.CompletedTask;
        }
    }

}