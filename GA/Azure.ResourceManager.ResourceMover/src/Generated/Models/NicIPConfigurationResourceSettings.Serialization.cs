// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class NicIPConfigurationResourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteStringValue(PrivateIPAddress.ToString());
            }
            if (Optional.IsDefined(PrivateIPAllocationMethod))
            {
                writer.WritePropertyName("privateIpAllocationMethod"u8);
                writer.WriteStringValue(PrivateIPAllocationMethod);
            }
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteObjectValue(Subnet);
            }
            if (Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
            }
            if (Optional.IsCollectionDefined(LoadBalancerBackendAddressPools))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerNatRules))
            {
                writer.WritePropertyName("loadBalancerNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIP))
            {
                writer.WritePropertyName("publicIp"u8);
                writer.WriteObjectValue(PublicIP);
            }
            writer.WriteEndObject();
        }

        internal static NicIPConfigurationResourceSettings DeserializeNicIPConfigurationResourceSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IPAddress> privateIPAddress = default;
            Optional<string> privateIPAllocationMethod = default;
            Optional<SubnetReferenceInfo> subnet = default;
            Optional<bool> primary = default;
            Optional<IList<LoadBalancerBackendAddressPoolReferenceInfo>> loadBalancerBackendAddressPools = default;
            Optional<IList<LoadBalancerNatRuleReferenceInfo>> loadBalancerNatRules = default;
            Optional<PublicIPReferenceInfo> publicIP = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateIpAllocationMethod"u8))
                {
                    privateIPAllocationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnet = SubnetReferenceInfo.DeserializeSubnetReferenceInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("primary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("loadBalancerBackendAddressPools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancerBackendAddressPoolReferenceInfo> array = new List<LoadBalancerBackendAddressPoolReferenceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerBackendAddressPoolReferenceInfo.DeserializeLoadBalancerBackendAddressPoolReferenceInfo(item));
                    }
                    loadBalancerBackendAddressPools = array;
                    continue;
                }
                if (property.NameEquals("loadBalancerNatRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancerNatRuleReferenceInfo> array = new List<LoadBalancerNatRuleReferenceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerNatRuleReferenceInfo.DeserializeLoadBalancerNatRuleReferenceInfo(item));
                    }
                    loadBalancerNatRules = array;
                    continue;
                }
                if (property.NameEquals("publicIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIP = PublicIPReferenceInfo.DeserializePublicIPReferenceInfo(property.Value);
                    continue;
                }
            }
            return new NicIPConfigurationResourceSettings(name.Value, privateIPAddress.Value, privateIPAllocationMethod.Value, subnet.Value, Optional.ToNullable(primary), Optional.ToList(loadBalancerBackendAddressPools), Optional.ToList(loadBalancerNatRules), publicIP.Value);
        }
    }
}