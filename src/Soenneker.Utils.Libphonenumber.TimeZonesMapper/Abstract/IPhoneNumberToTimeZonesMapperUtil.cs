using PhoneNumbers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Utils.Libphonenumber.TimeZonesMapper.Abstract;

/// <summary>
/// An async thread-safe singleton for a libphonenumber-csharp PhoneNumberToTimeZonesMapper instance
/// </summary>
public interface IPhoneNumberToTimeZonesMapperUtil : IAsyncDisposable, IDisposable
{
    /// <summary>
    /// Returns the lazily initialized phone-number-to-time-zone mapper.
    /// </summary>
    /// <param name="cancellationToken">Signals that the operation should stop.</param>
    /// <returns>The shared time-zone mapper.</returns>
    ValueTask<PhoneNumberToTimeZonesMapper> Get(CancellationToken cancellationToken = default);
}
