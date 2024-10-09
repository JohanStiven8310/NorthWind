using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;

IUserActionWriter writer= default;

Applogger Logger = new Applogger(writer);
Logger.WriteLog("Application Started.");


