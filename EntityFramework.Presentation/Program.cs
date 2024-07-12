using Entity.UI;
using Serilog;
using Serilog.Core;
using System.Net;

namespace Entity;

public class Program
{
    public static void Main(string[] args)
    {
        ManageDepartment manageDepartment = new ManageDepartment();
        manageDepartment.Run();

        // ManageEmployee manageEmployee = new ManageEmployee();
        // manageEmployee.Run();

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File("logs/mylog.txt")
            .CreateLogger();
        Log.Information("Application Started");
        Log.Debug("This is a debug message");

        //ResponseModel --> 
    }
}