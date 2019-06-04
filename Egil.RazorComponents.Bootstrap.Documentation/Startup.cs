using Egil.RazorComponents.Bootstrap.Documentation.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Egil.RazorComponents.Bootstrap.Documentation
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IExampleComponentRepository, AssemblyEmbeddedExampleComponentRepository>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
