using Microsoft.Extensions.Configuration;

namespace CSharpEducation301.EFDbFirst;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        IConfiguration configuration = builder.Build();
        string connectionString = configuration.GetConnectionString("SqlConnection");
        ApplicationConfiguration.Initialize();
        Application.Run(new FormLocation());
    }
}