using Microsoft.Extensions.Logging;
using PhoneNumbers;
using Soenneker.Utils.AsyncSingleton;
using Soenneker.Utils.Libphonenumber.TimeZonesMapper.Abstract;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Utils.Libphonenumber.TimeZonesMapper;

/// <inheritdoc cref="IPhoneNumberToTimeZonesMapperUtil"/>
public sealed class PhoneNumberToTimeZonesMapperUtil : IPhoneNumberToTimeZonesMapperUtil
{
    private readonly AsyncSingleton<PhoneNumberToTimeZonesMapper> _client;
    private readonly ILogger<PhoneNumberToTimeZonesMapperUtil> _logger;

    public PhoneNumberToTimeZonesMapperUtil(ILogger<PhoneNumberToTimeZonesMapperUtil> logger)
    {
        _logger = logger;
        _client = new AsyncSingleton<PhoneNumberToTimeZonesMapper>(CreateMapper);
    }

    private PhoneNumberToTimeZonesMapper CreateMapper()
    {
        _logger.LogDebug("Instantiating PhoneNumberToTimeZonesMapper...");

        return PhoneNumberToTimeZonesMapper.GetInstance();
    }

    public ValueTask<PhoneNumberToTimeZonesMapper> Get(CancellationToken cancellationToken = default)
    {
        return _client.Get(cancellationToken);
    }

    /// <summary>
    /// Releases resources used by the current instance.
    /// </summary>
    public void Dispose()
    {
        _client.Dispose();
    }

    /// <summary>
    /// Asynchronously releases resources used by the current instance.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public ValueTask DisposeAsync()
    {
        return _client.DisposeAsync();
    }
}