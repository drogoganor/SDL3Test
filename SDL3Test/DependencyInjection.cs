using Microsoft.Extensions.DependencyInjection;
using SDL3Test.Providers;

namespace SDL3Test
{
    internal static class DependencyInjection
    {
        public static ServiceCollection Build()
        {
            var services = new ServiceCollection();

            services.AddSingleton<Sdl3WindowProvider>();
            services.AddSingleton<ClientProvider>();

            return services;
        }
    }
}
