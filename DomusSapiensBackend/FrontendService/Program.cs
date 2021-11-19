using FrontendService.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new() { Title = "FrontendService", Version = "v1" });
});
builder.Services.AddDbContext<PostgresContext>(options =>
		options.UseNpgsql(Environment.GetEnvironmentVariable("PostgreSQL")));

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll", builder =>
	{
		 builder
		 .AllowAnyOrigin() 
		 .AllowAnyMethod()
		 .AllowAnyHeader();
     });
});

var app = builder.Build();
app.UseExceptionHandler(errorApp =>
{
	errorApp.Run(async context =>
	{
		context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
		context.Response.ContentType = "application/json";
		await context.Response.WriteAsync(@"{""error"": {""message"": ""Я упал""}}");
	});
});
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FrontendService v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
