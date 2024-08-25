using Serilog;
using Serilog.Events;

namespace WebApplication5
{
    public static class DependencyEx
    {
        public static IServiceCollection addSerilog1(this IServiceCollection services)
        {
            Log.Logger = new LoggerConfiguration().
            MinimumLevel.Debug()
           .WriteTo.Console()
           .WriteTo.File("logs/myapp.txt")
           .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
           .MinimumLevel.Override("Microsoft.Extensions.Hosting", LogEventLevel.Information)
           .MinimumLevel.Override("Microsoft.Hosting", LogEventLevel.Information)
           .CreateLogger();

            Log.Information("This is serilog logging");
            services.AddSerilog();
            return services;
        }

    }    
}
