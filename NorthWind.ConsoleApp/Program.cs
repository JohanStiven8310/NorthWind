using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

HostApplicationBuilder Builder =  Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<Applogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();



Applogger Logger = AppHost.Services.GetRequiredService<Applogger>();
Logger.WriteLog("Application Started.");


ProductService service = AppHost.Services.GetRequiredService<ProductService>();
service.Add("Demo", "Azucar refinada");

/*
 * AppLogger y los Writers: Responsabilidad unica
 * AppLogger : Abierto pero cerrado
 * Applogger : Inversio de dependencias, los modulos 
 * de alto nivel son independientes de los detalles de implementacion
 * 
 * */



