using Mapster;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using PaymentNET.AspNetCore.Contracts;

namespace PaymentNET.AspNetCore.Middleware;

public static class Endpoint
{
    public static void MapPaymentVerificationEndpoint(this IEndpointRouteBuilder  app)
    {
        var group = app.MapGroup("transaction-verification");
        group.MapGet("verify/{referenceId}", VerifyTransactionCallBack);
    }

    private static async Task VerifyTransactionCallBack([FromRoute] string referenceId ,[FromServices]IPaymentVerificationHandler paymentVerificationHandler,CancellationToken cancellationToken)
    {
         
        var resutl = await paymentVerificationHandler.HandleAsync(referenceId,cancellationToken);
       
    }
}