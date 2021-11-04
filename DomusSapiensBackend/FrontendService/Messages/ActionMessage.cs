﻿using FrontendService.Model;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging.Abstractions;

namespace FrontendService.Messages
{
	public class ActionMessage : IMessage
	{
		private readonly ActionActivity _action;
		private string _connectionString = "<NAMESPACE CONNECTION STRING>";

		public string QueueName { get; init; } = "<QUEUE NAME>";
		public ServiceBusMessage Message { get; init; }

		public ILogger Logger { get; init; }

		public ActionMessage(ActionActivity action) : this(action,  NullLogger.Instance) { }

		public ActionMessage(ActionActivity action, ILogger logger)
		{
			_action = action;
			Message = new ServiceBusMessage(_action.ToString());
			Logger = logger;
		}

		public async Task<bool> TrySendAsync()
		{
			await using var client = new ServiceBusClient(_connectionString);
			await using var sender = client.CreateSender(QueueName);
			using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
			if (messageBatch.TryAddMessage(Message))
			{
				Logger.LogInformation($"Message {Message.MessageId} to {Message.To} succesfully added");
				try
				{
					Logger.LogInformation($"Try send {Message.MessageId} to {Message.To}");
					await sender.SendMessageAsync(Message);
					return true;
				}
				catch (Exception)
				{
					Logger.LogError($"Failed send {Message.MessageId} to {Message.To} with content {Message}");
					return false;
				}
			} 
			else
			{
				Logger.LogError($"Message {Message.MessageId} to {Message.To} with content {Message} not added added");
			}
			return false;
		}
	}
}
