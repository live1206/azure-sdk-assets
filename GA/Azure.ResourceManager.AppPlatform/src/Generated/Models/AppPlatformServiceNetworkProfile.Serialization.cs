// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformServiceNetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceRuntimeSubnetId))
            {
                writer.WritePropertyName("serviceRuntimeSubnetId"u8);
                writer.WriteStringValue(ServiceRuntimeSubnetId);
            }
            if (Optional.IsDefined(AppSubnetId))
            {
                writer.WritePropertyName("appSubnetId"u8);
                writer.WriteStringValue(AppSubnetId);
            }
            if (Optional.IsDefined(ServiceCidr))
            {
                writer.WritePropertyName("serviceCidr"u8);
                writer.WriteStringValue(ServiceCidr);
            }
            if (Optional.IsDefined(ServiceRuntimeNetworkResourceGroup))
            {
                writer.WritePropertyName("serviceRuntimeNetworkResourceGroup"u8);
                writer.WriteStringValue(ServiceRuntimeNetworkResourceGroup);
            }
            if (Optional.IsDefined(AppNetworkResourceGroup))
            {
                writer.WritePropertyName("appNetworkResourceGroup"u8);
                writer.WriteStringValue(AppNetworkResourceGroup);
            }
            if (Optional.IsDefined(IngressConfig))
            {
                writer.WritePropertyName("ingressConfig"u8);
                writer.WriteObjectValue(IngressConfig);
            }
            if (Optional.IsDefined(OutboundType))
            {
                writer.WritePropertyName("outboundType"u8);
                writer.WriteStringValue(OutboundType);
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformServiceNetworkProfile DeserializeAppPlatformServiceNetworkProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> serviceRuntimeSubnetId = default;
            Optional<ResourceIdentifier> appSubnetId = default;
            Optional<string> serviceCidr = default;
            Optional<string> serviceRuntimeNetworkResourceGroup = default;
            Optional<string> appNetworkResourceGroup = default;
            Optional<NetworkProfileOutboundIPs> outboundIPs = default;
            Optional<IReadOnlyList<AppPlatformServiceRequiredTraffic>> requiredTraffics = default;
            Optional<IngressConfig> ingressConfig = default;
            Optional<string> outboundType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceRuntimeSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceRuntimeSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceCidr"u8))
                {
                    serviceCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceRuntimeNetworkResourceGroup"u8))
                {
                    serviceRuntimeNetworkResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appNetworkResourceGroup"u8))
                {
                    appNetworkResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPs = NetworkProfileOutboundIPs.DeserializeNetworkProfileOutboundIPs(property.Value);
                    continue;
                }
                if (property.NameEquals("requiredTraffics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformServiceRequiredTraffic> array = new List<AppPlatformServiceRequiredTraffic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformServiceRequiredTraffic.DeserializeAppPlatformServiceRequiredTraffic(item));
                    }
                    requiredTraffics = array;
                    continue;
                }
                if (property.NameEquals("ingressConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressConfig = IngressConfig.DeserializeIngressConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("outboundType"u8))
                {
                    outboundType = property.Value.GetString();
                    continue;
                }
            }
            return new AppPlatformServiceNetworkProfile(serviceRuntimeSubnetId.Value, appSubnetId.Value, serviceCidr.Value, serviceRuntimeNetworkResourceGroup.Value, appNetworkResourceGroup.Value, outboundIPs.Value, Optional.ToList(requiredTraffics), ingressConfig.Value, outboundType.Value);
        }
    }
}