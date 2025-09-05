 namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            // Add API-specific services here, e.g., controllers, Swagger, CORS, etc.
            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
            // Configure the HTTP request pipeline here, e.g., app.UseSwagger(), app.UseCors(), etc.

            // app.MapCarter();

            return app;
        }
    }
}
