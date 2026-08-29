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

## Common operations

- `Get()` - Gets the value.
- `Dispose()` - Releases resources used by the current instance.
- `DisposeAsync()` - Asynchronously releases resources owned by the timezone mapper; await it when the mapper's lifetime ends.
