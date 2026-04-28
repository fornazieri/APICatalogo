using APICatalogo.Context;
using APICatalogo.Extensions;
using APICatalogo.Filters;
using APICatalogo.Logging;
using APICatalogo.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//configurando o serviço de controle para ignorar referências cíclicas
builder.Services.AddControllers()
      .AddJsonOptions(options =>
         options.JsonSerializerOptions
            .ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//lendo a string de conexão do arquivo de configuração
string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

//lendo valores do arquivo de configuração
var valor1 = builder.Configuration["chave1"];
var valor2 = builder.Configuration["secao1:chave2"];

//adicionando o serviço de contexto do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseMySql(mySqlConnection,
                    ServerVersion.AutoDetect(mySqlConnection)));

//adicionando o serviço de injeção de dependência
builder.Services.AddTransient<IMeuServico, MeuServico>();

//adicionando filtro de log para as APIs
builder.Services.AddScoped<ApiLoggingFilter>();

//adocionando o provedor de log personalizado
builder.Logging.AddProvider(new CustomLoggerProvider(new CustomLoggerProviderConfiguration
{
    //definindo o nível de log para o provedor personalizado
    LogLevel = LogLevel.Information
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //adicionando o middleware de tratamento global de exceções
    app.ConfigureExceptionHandler();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
