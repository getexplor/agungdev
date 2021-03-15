using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agungdev.Service;
using Microsoft.Extensions.DependencyInjection;

namespace agungdev
{
    public static class DepedencyInjection
    {
        public static void AddServiceDepedency(this IServiceCollection services)
        {
            services.AddTransient<IAboutService, AboutService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IPortfolioService, PortfolioService>();
        }
    }
}
