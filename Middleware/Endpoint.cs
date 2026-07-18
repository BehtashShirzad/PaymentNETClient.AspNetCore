namespace PaymentNETClient.AspNetCore.Middleware;

public static class Endpoint
{
    public static void MapPaymentVerificationEndpoint(this IEndpointRouteBuilder  app)
    {
        var group = app.MapGroup("transaction-verification");
        group.MapPost("verify", VerifyTransactionCallBack);
    }

    private static Task VerifyTransactionCallBack()
    {
        
        return Task.CompletedTask;
    }
}