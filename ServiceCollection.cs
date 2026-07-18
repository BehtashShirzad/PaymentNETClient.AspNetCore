using PaymentNETClient.AspNetCore.Contracts;

namespace PaymentNETClient.AspNetCore;

public static class ServiceCollection
{
    public static IServiceCollection AddPaymentClientAspNetCore<THandler>(
        this IServiceCollection services)
        where THandler : class, IPaymentVerificationHandler
    {
        services.AddScoped<IPaymentVerificationHandler, THandler>();

        return services;
    }
}