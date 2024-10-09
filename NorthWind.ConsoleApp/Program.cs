using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new DebugWriter();

Applogger Logger = new Applogger(Writer);
Logger.WriteLog("Application Started.");


ProductService service = new ProductService(Writer);
service.Add("Demo", "Azucar refinada");
