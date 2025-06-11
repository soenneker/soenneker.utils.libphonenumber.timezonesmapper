using Soenneker.Utils.Libphonenumber.TimeZonesMapper.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Utils.Libphonenumber.TimeZonesMapper.Tests;

[Collection("Collection")]
public sealed class PhoneNumberToTimeZonesMapperUtilTests : FixturedUnitTest
{
    private readonly IPhoneNumberToTimeZonesMapperUtil _util;

    public PhoneNumberToTimeZonesMapperUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IPhoneNumberToTimeZonesMapperUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
