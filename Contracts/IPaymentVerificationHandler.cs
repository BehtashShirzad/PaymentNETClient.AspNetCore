namespace PaymentNETClient.AspNetCore.Contracts;

public interface IPaymentVerificationHandler
{
    Task<bool> HandleAsync(
        object result,
        CancellationToken cancellationToken = default);
}