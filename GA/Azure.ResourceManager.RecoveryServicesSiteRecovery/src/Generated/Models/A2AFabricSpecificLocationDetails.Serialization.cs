// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AFabricSpecificLocationDetails
    {
        internal static A2AFabricSpecificLocationDetails DeserializeA2AFabricSpecificLocationDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> initialPrimaryZone = default;
            Optional<string> initialRecoveryZone = default;
            Optional<SiteRecoveryExtendedLocation> initialPrimaryExtendedLocation = default;
            Optional<SiteRecoveryExtendedLocation> initialRecoveryExtendedLocation = default;
            Optional<AzureLocation> initialPrimaryFabricLocation = default;
            Optional<AzureLocation> initialRecoveryFabricLocation = default;
            Optional<string> primaryZone = default;
            Optional<string> recoveryZone = default;
            Optional<SiteRecoveryExtendedLocation> primaryExtendedLocation = default;
            Optional<SiteRecoveryExtendedLocation> recoveryExtendedLocation = default;
            Optional<AzureLocation> primaryFabricLocation = default;
            Optional<AzureLocation> recoveryFabricLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initialPrimaryZone"u8))
                {
                    initialPrimaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialRecoveryZone"u8))
                {
                    initialRecoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialPrimaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("initialRecoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("initialPrimaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialRecoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryZone"u8))
                {
                    primaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryZone"u8))
                {
                    recoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
            }
            return new A2AFabricSpecificLocationDetails(initialPrimaryZone.Value, initialRecoveryZone.Value, initialPrimaryExtendedLocation.Value, initialRecoveryExtendedLocation.Value, Optional.ToNullable(initialPrimaryFabricLocation), Optional.ToNullable(initialRecoveryFabricLocation), primaryZone.Value, recoveryZone.Value, primaryExtendedLocation.Value, recoveryExtendedLocation.Value, Optional.ToNullable(primaryFabricLocation), Optional.ToNullable(recoveryFabricLocation));
        }
    }
}