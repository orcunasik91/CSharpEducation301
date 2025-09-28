using CSharpEducation301.Business.Abstracts;
using CSharpEducation301.Business.Concretes;
using CSharpEducation301.DataAccess.Abstracts;
using CSharpEducation301.DataAccess.Context;
using CSharpEducation301.DataAccess.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CSharpEducation301.Presentation;
internal static class Program
{
    public static IConfiguration Configuration { get; private set; }
    [STAThread]
    static void Main()
    {
        #region Configurations
         Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        var services = new ServiceCollection();
        services.AddDbContext<AppEducationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IProductDal, EfProductDal>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<FormCategory>();
        services.AddScoped<FormProduct>();
        #endregion
        ApplicationConfiguration.Initialize();
        using (var serviceProvider = services.BuildServiceProvider())
        {
            var mainForm = serviceProvider.GetRequiredService<FormProduct>();
            Application.Run(mainForm);

        }
    }
}