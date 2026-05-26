namespace Account.API.Features.Health
{
    public static class HealthEndpoint
    {
        public static void MapHealthEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapHealthChecks("/health");
        }
    }
}
                                                                        