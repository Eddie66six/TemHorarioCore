using Microsoft.Extensions.DependencyInjection;
using TemHorario.Core;
using TemHorario.Core.Applications.Client;
using TemHorario.Core.Domain;
using TemHorario.Core.Domain.Client.Interfaces.Applications;
using TemHorario.Core.Domain.Client.Interfaces.Repositories;
using TemHorario.Repository;
using TemHorario.Repository.Repositories.Client;

namespace TemHorario.SharedApi
{
    public static class DependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            RegisterApplication(services);
            RegisterRepository(services);
            RegisterOthers(services);
        }

        private static void RegisterApplication(IServiceCollection services)
        {
            services.AddScoped<IClientApplication, ClientApplication>();
        }

        private static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<Context>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClientRepository, ClientRepository>();
        }

        private static void RegisterOthers(IServiceCollection services)
        {
            services.AddScoped<ErrorEvent>();
        }
    }
}
