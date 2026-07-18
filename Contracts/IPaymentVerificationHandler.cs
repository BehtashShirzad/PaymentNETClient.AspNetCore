namespace PaymentNET.AspNetCore.Contracts;

public interface IPaymentVerificationHandler
{
    Task<bool> HandleAsync(
        object result,
        CancellationToken cancellationToken = default);
}