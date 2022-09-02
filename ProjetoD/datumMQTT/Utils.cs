using System;
using System.Text;
using System.Text.Json;
using MQTTnet;
using MQTTnet.Client;
using System.Diagnostics;

namespace datumMQTT {
    public class Utils {
        public static async Task EscutaIssoAsync(string topic, Action<string> eventoMensagemRecebida) {
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
        public static async Task PublicaIssoAsync(string topic, string mensagem) {
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