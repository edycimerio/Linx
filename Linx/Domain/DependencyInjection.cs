using Domain.Interfaces.Service;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IDespesaService, DespesaService>();
            services.AddTransient<ITipoGastoService, TipoGastoService>();

            return services;

        }
    }
}
