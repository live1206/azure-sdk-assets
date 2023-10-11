// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallNetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VnetConfiguration))
            {
                writer.WritePropertyName("vnetConfiguration"u8);
                writer.WriteObjectValue(VnetConfiguration);
            }
            if (Optional.IsDefined(VwanConfiguration))
            {
                writer.WritePropertyName("vwanConfiguration"u8);
                writer.WriteObjectValue(VwanConfiguration);
            }
            writer.WritePropertyName("networkType"u8);
            writer.WriteStringValue(NetworkType.ToString());
            writer.WritePropertyName("publicIps"u8);
            writer.WriteStartArray();
            foreach (var item in PublicIPs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("enableEgressNat"u8);
            writer.WriteStringValue(EnableEgressNat.ToString());
            if (Optional.IsCollectionDefined(EgressNatIP))
            {
                writer.WritePropertyName("egressNatIp"u8);
                writer.WriteStartArray();
                foreach (var item in EgressNatIP)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallNetworkProfile DeserializeFirewallNetworkProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FirewallVnetConfiguration> vnetConfiguration = default;
            Optional<FirewallVwanConfiguration> vwanConfiguration = default;
            FirewallNetworkType networkType = default;
            IList<IPAddressInfo> publicIPs = default;
            AllowEgressNatType enableEgressNat = default;
            Optional<IList<IPAddressInfo>> egressNatIP = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetConfiguration = FirewallVnetConfiguration.DeserializeFirewallVnetConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("vwanConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vwanConfiguration = FirewallVwanConfiguration.DeserializeFirewallVwanConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("networkType"u8))
                {
                    networkType = new FirewallNetworkType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIps"u8))
                {
                    List<IPAddressInfo> array = new List<IPAddressInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item));
                    }
                    publicIPs = array;
                    continue;
                }
                if (property.NameEquals("enableEgressNat"u8))
                {
                    enableEgressNat = new AllowEgressNatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("egressNatIp"u8))
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
                    egressNatIP = array;
                    continue;
                }
            }
            return new FirewallNetworkProfile(vnetConfiguration.Value, vwanConfiguration.Value, networkType, publicIPs, enableEgressNat, Optional.ToList(egressNatIP));
        }
    }
}