namespace Account.API.Features.Health
{
    public static class HealthEndpoint
    {
        public static IEndpointRouteBuilder MapHealthEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapHealthChecks("/health");
            return app;
        }
    }
}
                                                                        