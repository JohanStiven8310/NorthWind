namespace NorthWind.ConsoleApp.Services
{
    internal class Applogger (IUserActionWriter writer)
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
          writer.Write(Log);


        }
    }
}
