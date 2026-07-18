namespace PaymentNET.AspNetCore.Middleware;

public static class EndpointExtension
{
    public static IEndpointRouteBuilder MapPaymentCore(
        this IEndpointRouteBuilder app)
    {
        app.MapPaymentVerificationEndpoint();

        return app;
    }
}