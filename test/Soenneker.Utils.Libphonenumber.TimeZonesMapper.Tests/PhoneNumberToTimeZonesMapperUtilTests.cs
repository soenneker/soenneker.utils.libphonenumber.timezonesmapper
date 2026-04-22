using Soenneker.Utils.Libphonenumber.TimeZonesMapper.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Utils.Libphonenumber.TimeZonesMapper.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PhoneNumberToTimeZonesMapperUtilTests : HostedUnitTest
{
    private readonly IPhoneNumberToTimeZonesMapperUtil _util;

    public PhoneNumberToTimeZonesMapperUtilTests(Host host) : base(host)
    {
        _util = Resolve<IPhoneNumberToTimeZonesMapperUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
