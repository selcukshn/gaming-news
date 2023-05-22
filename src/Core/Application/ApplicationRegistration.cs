using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using FluentValidation;

namespace Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection service)
        {
            var assembly = Assembly.GetExecutingAssembly();
            service
                .AddAutoMapper(assembly)
                .AddMediatR(assembly)
                .AddValidatorsFromAssembly(assembly);
            return service;
        }
    }
}