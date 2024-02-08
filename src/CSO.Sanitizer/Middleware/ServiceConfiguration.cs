using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CSO.Sanitizer
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddSanitizer(this IServiceCollection service, WebApplicationBuilder builder, dynamic LogObject)
        {

            service.AddSingleton<ICleanser, Cleanser>();
            service.AddSingleton<ISanitizer, Sanitizer>();

            var sp = service.BuildServiceProvider();

            SanitizerServicesHelper.ServiceProvider = sp;
            SanitizerServicesHelper.Configuration = builder.Configuration;

            SanitizerServicesHelper.Sanitizer = sp.GetRequiredService<ISanitizer>();
            SanitizerServicesHelper.Cleanser = sp.GetRequiredService<ICleanser>();


            LogObject.Info("Sanitizer setup completed");
            return service;
        }

    }
}
