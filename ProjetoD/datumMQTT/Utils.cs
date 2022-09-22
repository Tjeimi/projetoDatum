using System;
using System.Text;
using System.Text.Json;
using MQTTnet;
using MQTTnet.Client;
using System.Diagnostics;
using Models;

namespace datumMQTT {
    public class Utils {
        public static async Task EscutarAsync(string topic, Action<string> eventoMensagemRecebida) {
            var mqttFactory = new MqttFactory();
            var mqttClient = mqttFactory.CreateMqttClient();
            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithTcpServer("localhost", 1883)
                .Build();

            //mensagem recebida
            mqttClient.ApplicationMessageReceivedAsync += e => {
                eventoMensagemRecebida(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                Debug.WriteLine($"Mensagem recebida :) \r\n {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
                return Task.CompletedTask;
            };

            await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

            var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                .WithTopicFilter(f => { f.WithTopic(topic); })
                .Build();

            await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);

            Debug.WriteLine("MQTT client subscribed to topic.");

            //Console.ReadLine();
        }
        public static async Task<string> PublicarAsync(string topic, BasePacket pacote) {
            var mqttFactory = new MqttFactory();
            using (var mqttClient = mqttFactory.CreateMqttClient()) {
                var mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer("localhost", 1883)
                    .Build();

                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(f => { f.WithTopic(topic); })
                    .Build();

                await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);

                pacote.responseTopic = "resposta/" + mqttClient.Options.ClientId;

                string mensagem = JsonSerializer.Serialize(pacote);

                var applicationMessage = new MqttApplicationMessageBuilder()
                    .WithTopic(topic)
                    .WithPayload(mensagem)
                    .Build();
                await mqttClient.PublishAsync(applicationMessage, CancellationToken.None);
                Debug.WriteLine($"Mensagem publicada :) \r\n {mensagem}");
                return pacote.responseTopic;
            };
        }

        public static async Task PublicarRespostaAsync(string topic, object pacote) {
            var mqttFactory = new MqttFactory();
            using (var mqttClient = mqttFactory.CreateMqttClient()) {
                var mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer("localhost", 1883)
                    .Build();

                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                var mqttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(f => { f.WithTopic(topic); })
                    .Build();

                await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);

                string mensagem = JsonSerializer.Serialize(pacote);

                var applicationMessage = new MqttApplicationMessageBuilder()
                    .WithTopic(topic)
                    .WithPayload(mensagem)
                    .Build();
                await mqttClient.PublishAsync(applicationMessage, CancellationToken.None);
                Debug.WriteLine($"Mensagem publicada :) \r\n {mensagem}");
            };
        }

    }

}