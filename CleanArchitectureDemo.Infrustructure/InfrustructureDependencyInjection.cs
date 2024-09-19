
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Infrustructure
{
    public static class InfrustructureDependencyInjection
    {
        public static IServiceCollection AddInfrustructure(this IServiceCollection services)
        {
            return services;
        }
    }
}
