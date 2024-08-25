using Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Repository
{
    
    [ExcludeFromCodeCoverage]
    public static class DependencyInjection
    {
        public static IServiceCollection AddRespositorys(this IServiceCollection services)
        {
            services.AddTransient<IDespesaRepository, DespesaRepository>();
            services.AddTransient<ITipoGastoRepository, TipoGastoRepository>(); 

            return services;

        }
    }
}
