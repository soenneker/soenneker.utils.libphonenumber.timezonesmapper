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

    public PhoneNumberToTimeZonesMapperUtil(ILogger<PhoneNumberToTimeZonesMapperUtil> logger)
    {
        _client = new AsyncSingleton<PhoneNumberToTimeZonesMapper>(() =>
        {
            logger.LogDebug("Instantiating libphonenumber (PhoneNumberUtil)...");

            return PhoneNumberToTimeZonesMapper.GetInstance();
        });
    }

    public ValueTask<PhoneNumberToTimeZonesMapper> Get(CancellationToken cancellationToken = default)
    {
        return _client.Get(cancellationToken);
    }

    public void Dispose()
    {
        _client.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        return _client.DisposeAsync();
    }
}