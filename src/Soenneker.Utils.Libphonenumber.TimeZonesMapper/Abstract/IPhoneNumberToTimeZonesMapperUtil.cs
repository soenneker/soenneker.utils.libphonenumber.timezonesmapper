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
    /// Gets the value.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<PhoneNumberToTimeZonesMapper> Get(CancellationToken cancellationToken = default);
}
