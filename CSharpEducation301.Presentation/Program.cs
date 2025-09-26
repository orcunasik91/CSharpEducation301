using Microsoft.Extensions.Configuration;

namespace CSharpEducation301.Presentation;
internal static class Program
{
    public static IConfiguration Configuration { get; private set; }
    [STAThread]
    static void Main()
    {
        #region ConfigurationDb
         Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        #endregion
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}