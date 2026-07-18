namespace PaymentNETClient.AspNetCore.Middleware;

public static class EndpointExtension
{
    public static IEndpointRouteBuilder MapPaymentClient(
        this IEndpointRouteBuilder app)
    {
        app.MapPaymentVerificationEndpoint();

        return app;
    }
}