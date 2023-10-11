// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterLoadBalancerProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedOutboundIPs))
            {
                writer.WritePropertyName("managedOutboundIPs"u8);
                writer.WriteObjectValue(ManagedOutboundIPs);
            }
            if (Optional.IsDefined(OutboundIPPrefixes))
            {
                writer.WritePropertyName("outboundIPPrefixes"u8);
                writer.WriteObjectValue(OutboundIPPrefixes);
            }
            if (Optional.IsDefined(OutboundIPs))
            {
                writer.WritePropertyName("outboundIPs"u8);
                writer.WriteObjectValue(OutboundIPs);
            }
            if (Optional.IsCollectionDefined(EffectiveOutboundIPs))
            {
                writer.WritePropertyName("effectiveOutboundIPs"u8);
                writer.WriteStartArray();
                foreach (var item in EffectiveOutboundIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllocatedOutboundPorts))
            {
                writer.WritePropertyName("allocatedOutboundPorts"u8);
                writer.WriteNumberValue(AllocatedOutboundPorts.Value);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(EnableMultipleStandardLoadBalancers))
            {
                writer.WritePropertyName("enableMultipleStandardLoadBalancers"u8);
                writer.WriteBooleanValue(EnableMultipleStandardLoadBalancers.Value);
            }
            if (Optional.IsDefined(BackendPoolType))
            {
                writer.WritePropertyName("backendPoolType"u8);
                writer.WriteStringValue(BackendPoolType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterLoadBalancerProfile DeserializeManagedClusterLoadBalancerProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedClusterLoadBalancerProfileManagedOutboundIPs> managedOutboundIPs = default;
            Optional<ManagedClusterLoadBalancerProfileOutboundIPPrefixes> outboundIPPrefixes = default;
            Optional<ManagedClusterLoadBalancerProfileOutboundIPs> outboundIPs = default;
            Optional<IList<WritableSubResource>> effectiveOutboundIPs = default;
            Optional<int> allocatedOutboundPorts = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<bool> enableMultipleStandardLoadBalancers = default;
            Optional<ManagedClusterLoadBalancerBackendPoolType> backendPoolType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedOutboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedOutboundIPs = ManagedClusterLoadBalancerProfileManagedOutboundIPs.DeserializeManagedClusterLoadBalancerProfileManagedOutboundIPs(property.Value);
                    continue;
                }
                if (property.NameEquals("outboundIPPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPPrefixes = ManagedClusterLoadBalancerProfileOutboundIPPrefixes.DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(property.Value);
                    continue;
                }
                if (property.NameEquals("outboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPs = ManagedClusterLoadBalancerProfileOutboundIPs.DeserializeManagedClusterLoadBalancerProfileOutboundIPs(property.Value);
                    continue;
                }
                if (property.NameEquals("effectiveOutboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    effectiveOutboundIPs = array;
                    continue;
                }
                if (property.NameEquals("allocatedOutboundPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocatedOutboundPorts = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("idleTimeoutInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    idleTimeoutInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableMultipleStandardLoadBalancers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableMultipleStandardLoadBalancers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backendPoolType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPoolType = new ManagedClusterLoadBalancerBackendPoolType(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedClusterLoadBalancerProfile(managedOutboundIPs.Value, outboundIPPrefixes.Value, outboundIPs.Value, Optional.ToList(effectiveOutboundIPs), Optional.ToNullable(allocatedOutboundPorts), Optional.ToNullable(idleTimeoutInMinutes), Optional.ToNullable(enableMultipleStandardLoadBalancers), Optional.ToNullable(backendPoolType));
        }
    }
}