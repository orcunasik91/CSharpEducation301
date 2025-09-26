using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CSharpEducation301.DataAccess.Context;

public class AppEducationDbContextFactory : IDesignTimeDbContextFactory<AppEducationDbContext>
{
    public AppEducationDbContext CreateDbContext(string[] args)
    {
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), @"..", "CSharpEducation301.Presentation");
        var configuraiton = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        var optionsBuilder = new DbContextOptionsBuilder<AppEducationDbContext>();
        optionsBuilder.UseSqlServer(configuraiton.GetConnectionString("DefaultConnection"));
        return new AppEducationDbContext(optionsBuilder.Options);
    }
}