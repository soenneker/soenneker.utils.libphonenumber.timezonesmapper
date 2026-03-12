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
    ValueTask<PhoneNumberToTimeZonesMapper> Get(CancellationToken cancellationToken = default);
}
