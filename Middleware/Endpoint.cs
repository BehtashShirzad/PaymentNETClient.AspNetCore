using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using PaymentNETClient.AspNetCore.Contracts;

namespace PaymentNETClient.AspNetCore.Middleware;

public static class Endpoint
{
    public static void MapPaymentVerificationEndpoint(this IEndpointRouteBuilder  app)
    {
        var group = app.MapGroup("transaction-verification");
        group.MapPost("verify", VerifyTransactionCallBack);
    }

    private static async Task VerifyTransactionCallBack([FromServices]IPaymentVerificationHandler paymentVerificationHandler,CancellationToken cancellationToken)
    {
        var resutl = await paymentVerificationHandler.HandleAsync(null,cancellationToken);
       
    }
}