using System;
using MailSystem.Application;
using MailSystem.Domain;
using MailSystem.Persistence.Ef;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration
{
    public static class MailBootstrapper
    {
        public static void Wireup(IServiceCollection services)
        {
            services.AddTransient<IMailRepository, MailRepository>();
            services.AddTransient<IMailApplication, MailApplication>();
        }
    }
}
