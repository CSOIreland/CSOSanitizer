using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CSO.Sanitizer
{
    public class SanitizerServicesHelper
    {

        public static IConfiguration Configuration { get; set; }
        public static ServiceProvider ServiceProvider { get; set; }


        public static ISanitizer Sanitizer;

        public static ICleanser Cleanser;

    }
}