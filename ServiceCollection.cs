using PaymentNET.AspNetCore.Contracts;

namespace PaymentNET.AspNetCore;

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