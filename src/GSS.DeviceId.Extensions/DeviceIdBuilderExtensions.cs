using DeviceId;
using GSS.DeviceId.Extensions.Components;

namespace GSS.DeviceId.Extensions;

public static class DeviceIdBuilderExtensions
{
    /// <summary>
    /// Adds the Domain Name to the device identifier.
    /// </summary>
    /// <param name="builder">The <see cref="DeviceIdBuilder"/> to add the component to.</param>
    /// <returns>The <see cref="DeviceIdBuilder"/> instance.</returns>
    public static DeviceIdBuilder AddDomainName(this DeviceIdBuilder builder)
    {
        return builder.AddComponent("DomainName", new DomainNameDeviceIdComponent());
    }
}