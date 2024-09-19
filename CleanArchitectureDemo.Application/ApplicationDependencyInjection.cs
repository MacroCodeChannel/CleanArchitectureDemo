using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var valassembly = typeof(DependencyInjectionExtensions).Assembly;
            services.AddValidatorsFromAssembly(valassembly);

            return services;
        }
    }
}
