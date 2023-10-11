// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Orbital.Models;

namespace Azure.ResourceManager.Orbital
{
    public partial class AvailableGroundStationData
    {
        internal static AvailableGroundStationData DeserializeAvailableGroundStationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> city = default;
            Optional<string> providerName = default;
            Optional<float> longitudeDegrees = default;
            Optional<float> latitudeDegrees = default;
            Optional<float> altitudeMeters = default;
            Optional<GroundStationReleaseMode> releaseMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("city"u8))
                        {
                            city = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerName"u8))
                        {
                            providerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("longitudeDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            longitudeDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("latitudeDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            latitudeDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("altitudeMeters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            altitudeMeters = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("releaseMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            releaseMode = new GroundStationReleaseMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AvailableGroundStationData(id, name, type, systemData.Value, Optional.ToNullable(location), city.Value, providerName.Value, Optional.ToNullable(longitudeDegrees), Optional.ToNullable(latitudeDegrees), Optional.ToNullable(altitudeMeters), Optional.ToNullable(releaseMode));
        }
    }
}