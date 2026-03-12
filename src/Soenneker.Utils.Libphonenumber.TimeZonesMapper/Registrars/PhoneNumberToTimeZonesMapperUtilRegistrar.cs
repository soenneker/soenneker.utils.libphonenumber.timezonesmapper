using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Utils.Libphonenumber.TimeZonesMapper.Abstract;

namespace Soenneker.Utils.Libphonenumber.TimeZonesMapper.Registrars;

/// <summary>
/// An async thread-safe singleton for a libphonenumber-csharp PhoneNumberToTimeZonesMapper instance
/// </summary>
public static class PhoneNumberToTimeZonesMapperUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IPhoneNumberToTimeZonesMapperUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddPhoneNumberToTimeZonesMapperUtilAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IPhoneNumberToTimeZonesMapperUtil, PhoneNumberToTimeZonesMapperUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IPhoneNumberToTimeZonesMapperUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddPhoneNumberToTimeZonesMapperUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IPhoneNumberToTimeZonesMapperUtil, PhoneNumberToTimeZonesMapperUtil>();

        return services;
    }
}
