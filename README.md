[![](https://img.shields.io/nuget/v/soenneker.utils.libphonenumber.timezonesmapper.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.libphonenumber.timezonesmapper/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.libphonenumber.timezonesmapper/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.libphonenumber.timezonesmapper/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.libphonenumber.timezonesmapper.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.libphonenumber.timezonesmapper/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.libphonenumber.timezonesmapper/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.libphonenumber.timezonesmapper/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.Libphonenumber.TimeZonesMapper
An async thread-safe singleton for a libphonenumber-csharp PhoneNumberToTimeZonesMapper instance.

## Installation

```bash
dotnet add package Soenneker.Utils.Libphonenumber.TimeZonesMapper
```

## Quick start

```csharp
using Soenneker.Utils.Libphonenumber.TimeZonesMapper.Registrars;

services.AddPhoneNumberToTimeZonesMapperUtilAsSingleton();
```

Then inject `IPhoneNumberToTimeZonesMapperUtil` wherever you need it.

## Map a parsed number

```csharp
using PhoneNumbers;

PhoneNumber number = PhoneNumberUtil.GetInstance().Parse("+1 212 555 0100", null);
PhoneNumberToTimeZonesMapper mapper = await mapperUtil.Get(cancellationToken);

IList<string> timeZoneIds = mapper.GetTimeZonesForNumber(number);
```

The mapper accepts a parsed `PhoneNumber`, not raw text. Use `PhoneNumberUtil.Parse` first and
validate the number when the result will drive application behavior.

A number can map to multiple time-zone IDs because numbering regions and area codes can span
zones. The result is geographic metadata, not the subscriber's live location. Unsupported or
insufficiently specific numbers can produce the library's unknown-zone result, so callers should
not assume the collection contains one usable local system time zone.

`Get` lazily returns the shared `PhoneNumberToTimeZonesMapper` supplied by
libphonenumber-csharp. The cancellation token applies while obtaining the lazy value; mapping is
synchronous after that. The scoped registrar changes the wrapper lifetime but does not create a
separate underlying mapper. Let dependency injection dispose the wrapper; callers do not own the
returned mapper.
