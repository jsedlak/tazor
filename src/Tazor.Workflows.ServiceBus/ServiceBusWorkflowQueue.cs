using Azure.Messaging.ServiceBus;
using Tazor.Serialization;

namespace Tazor.Workflows
{
    public class ServiceBusWorkflowQueue
    {
        private readonly ServiceBusClient _client;
        private readonly ISerializer _serializer;

        public ServiceBusWorkflowQueue(ISerializer serializer, string connectionString)
        {
            _client = new ServiceBusClient(connectionString);
            _serializer = serializer;
        }

        public async Task Enqueue(Guid templateId, object? data = null, string? customQueueName = null)
        {
            var request = new WorkflowRequest
            {
                TemplateId = templateId,
                Data = data
            };

            var msg = new ServiceBusMessage(
                _serializer.Serialize(request)
            );

            var sender = _client.CreateSender(customQueueName ?? DefaultQueueName);
            await sender.SendMessageAsync(msg);
        }

        public string DefaultQueueName { get; set; } = "workflows";
    }
}
