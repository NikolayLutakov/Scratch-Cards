namespace ScratchCards.WebApi.Infrastructure
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using ScratchCards.Data;
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabse(services);

            return app;
        }

        private static void MigrateDatabse(IServiceProvider services)
        {
            var data = services.GetRequiredService<ScratchCardsDbContext>();

            data.Database.Migrate();
        }
    }
}
