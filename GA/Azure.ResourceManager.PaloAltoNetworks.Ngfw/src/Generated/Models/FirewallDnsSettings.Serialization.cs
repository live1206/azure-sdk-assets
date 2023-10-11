// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallDnsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableDnsProxy))
            {
                writer.WritePropertyName("enableDnsProxy"u8);
                writer.WriteStringValue(EnableDnsProxy.Value.ToString());
            }
            if (Optional.IsDefined(EnabledDnsType))
            {
                writer.WritePropertyName("enabledDnsType"u8);
                writer.WriteStringValue(EnabledDnsType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallDnsSettings DeserializeFirewallDnsSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AllowDnsProxyType> enableDnsProxy = default;
            Optional<EnabledDnsType> enabledDnsType = default;
            Optional<IList<IPAddressInfo>> dnsServers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDnsProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnsProxy = new AllowDnsProxyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enabledDnsType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledDnsType = new EnabledDnsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddressInfo> array = new List<IPAddressInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item));
                    }
                    dnsServers = array;
                    continue;
                }
            }
            return new FirewallDnsSettings(Optional.ToNullable(enableDnsProxy), Optional.ToNullable(enabledDnsType), Optional.ToList(dnsServers));
        }
    }
}