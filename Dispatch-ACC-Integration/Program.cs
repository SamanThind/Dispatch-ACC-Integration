using BAL;
using DAL;
using Dispatch_ACC_Integration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false)
                .AddJsonFile("secrets/appSettings.json", true, true);


IConfiguration config = builder.Build();
IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {;
        services.AddDbContext<DispatchDBContext>(options => options.UseSqlServer(config.GetConnectionString("Dispatch")));
        services.AddTransient<IEquipments, EquipmentService>();
        services.AddHostedService<StartUp>();
    })
    .Build();

host.Run();


