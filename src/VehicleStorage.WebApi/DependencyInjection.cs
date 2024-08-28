using Serilog;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
    {

        // var logFilePathFormat = configuration["Serilog:WriteTo:0:Args:pathFormat"] ?? "";
        // var logFilePath = logFilePathFormat.Replace("{Date}", DateTime.Now.ToString("yyyy-MM-dd"));

        // Log.Logger = new LoggerConfiguration()
        // .WriteTo.Console()
        //     .WriteTo.File(
        //         path: logFilePath,
        //         outputTemplate: configuration["Serilog:WriteTo:0:Args:outputTemplate"] ?? "")
        //     .Enrich.FromLogContext()
        //     .CreateLogger();

        services.AddControllers();
        services.AddEndpointsApiExplorer();

        services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.MaxDepth = 1024;
        });

        return services;
    }
}
