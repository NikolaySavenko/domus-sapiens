using IoTControlService.ServiceBusMessaging;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHostedService<IoTQueueConsumer>();
builder.Services.AddHostedService<HighLevelCommendsConsumer>();
builder.Services.AddSingleton<IProcessData, ProcessData>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.Run();
