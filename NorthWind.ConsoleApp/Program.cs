using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

var Builder =  Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<Applogger>();
Builder.Services.AddSingleton<ProductService>();
using var AppHost = Builder.Build();




IUserActionWriter Writer = new ConsoleWriter();

Applogger Logger = new Applogger(Writer);
Logger.WriteLog("Application Started.");


ProductService service = new ProductService(Writer);
service.Add("Demo", "Azucar refinada");

/*
 * AppLogger y los Writers: Responsabilidad unica
 * AppLogger : Abierto pero cerrado
 * Applogger : Inversio de dependencias, los modulos 
 * de alto nivel son independientes de los detalles de implementacion
 * 
 * */
