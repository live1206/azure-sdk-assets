// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CloningInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId.Value);
            }
            if (Optional.IsDefined(CanOverwrite))
            {
                writer.WritePropertyName("overwrite"u8);
                writer.WriteBooleanValue(CanOverwrite.Value);
            }
            if (Optional.IsDefined(CloneCustomHostNames))
            {
                writer.WritePropertyName("cloneCustomHostNames"u8);
                writer.WriteBooleanValue(CloneCustomHostNames.Value);
            }
            if (Optional.IsDefined(CloneSourceControl))
            {
                writer.WritePropertyName("cloneSourceControl"u8);
                writer.WriteBooleanValue(CloneSourceControl.Value);
            }
            writer.WritePropertyName("sourceWebAppId"u8);
            writer.WriteStringValue(SourceWebAppId);
            if (Optional.IsDefined(SourceWebAppLocation))
            {
                writer.WritePropertyName("sourceWebAppLocation"u8);
                writer.WriteStringValue(SourceWebAppLocation.Value);
            }
            if (Optional.IsDefined(HostingEnvironment))
            {
                writer.WritePropertyName("hostingEnvironment"u8);
                writer.WriteStringValue(HostingEnvironment);
            }
            if (Optional.IsCollectionDefined(AppSettingsOverrides))
            {
                writer.WritePropertyName("appSettingsOverrides"u8);
                writer.WriteStartObject();
                foreach (var item in AppSettingsOverrides)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ConfigureLoadBalancing))
            {
                writer.WritePropertyName("configureLoadBalancing"u8);
                writer.WriteBooleanValue(ConfigureLoadBalancing.Value);
            }
            if (Optional.IsDefined(TrafficManagerProfileId))
            {
                writer.WritePropertyName("trafficManagerProfileId"u8);
                writer.WriteStringValue(TrafficManagerProfileId);
            }
            if (Optional.IsDefined(TrafficManagerProfileName))
            {
                writer.WritePropertyName("trafficManagerProfileName"u8);
                writer.WriteStringValue(TrafficManagerProfileName);
            }
            writer.WriteEndObject();
        }

        internal static CloningInfo DeserializeCloningInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> correlationId = default;
            Optional<bool> overwrite = default;
            Optional<bool> cloneCustomHostNames = default;
            Optional<bool> cloneSourceControl = default;
            ResourceIdentifier sourceWebAppId = default;
            Optional<AzureLocation> sourceWebAppLocation = default;
            Optional<string> hostingEnvironment = default;
            Optional<IDictionary<string, string>> appSettingsOverrides = default;
            Optional<bool> configureLoadBalancing = default;
            Optional<ResourceIdentifier> trafficManagerProfileId = default;
            Optional<string> trafficManagerProfileName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("correlationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    correlationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("overwrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overwrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloneCustomHostNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloneCustomHostNames = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloneSourceControl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloneSourceControl = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceWebAppId"u8))
                {
                    sourceWebAppId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceWebAppLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceWebAppLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostingEnvironment"u8))
                {
                    hostingEnvironment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appSettingsOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    appSettingsOverrides = dictionary;
                    continue;
                }
                if (property.NameEquals("configureLoadBalancing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configureLoadBalancing = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trafficManagerProfileId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficManagerProfileId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trafficManagerProfileName"u8))
                {
                    trafficManagerProfileName = property.Value.GetString();
                    continue;
                }
            }
            return new CloningInfo(Optional.ToNullable(correlationId), Optional.ToNullable(overwrite), Optional.ToNullable(cloneCustomHostNames), Optional.ToNullable(cloneSourceControl), sourceWebAppId, Optional.ToNullable(sourceWebAppLocation), hostingEnvironment.Value, Optional.ToDictionary(appSettingsOverrides), Optional.ToNullable(configureLoadBalancing), trafficManagerProfileId.Value, trafficManagerProfileName.Value);
        }
    }
}