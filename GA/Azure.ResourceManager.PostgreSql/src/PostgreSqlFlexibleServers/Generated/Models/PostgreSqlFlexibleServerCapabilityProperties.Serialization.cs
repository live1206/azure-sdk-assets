// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerCapabilityProperties
    {
        internal static PostgreSqlFlexibleServerCapabilityProperties DeserializePostgreSqlFlexibleServerCapabilityProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerEditionCapability>> supportedServerEditions = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerServerVersionCapability>> supportedServerVersions = default;
            Optional<PostgreSqlFlexibleServerFastProvisioningSupported> fastProvisioningSupported = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerFastProvisioningEditionCapability>> supportedFastProvisioningEditions = default;
            Optional<PostgreSqlFlexibleServerGeoBackupSupported> geoBackupSupported = default;
            Optional<PostgreSqlFlexibleServerZoneRedundantHaSupported> zoneRedundantHaSupported = default;
            Optional<PostgreSqlFlexibleServerZoneRedundantHaAndGeoBackupSupported> zoneRedundantHaAndGeoBackupSupported = default;
            Optional<PostgreSqlFlexibleServerStorageAutoGrowthSupported> storageAutoGrowthSupported = default;
            Optional<PostgreSqlFlexibleServerOnlineResizeSupported> onlineResizeSupported = default;
            Optional<PostgreSqlFlexibleServerZoneRedundantRestricted> restricted = default;
            Optional<PostgreSqlFlexbileServerCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedServerEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerEditionCapability> array = new List<PostgreSqlFlexibleServerEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerEditionCapability.DeserializePostgreSqlFlexibleServerEditionCapability(item));
                    }
                    supportedServerEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedServerVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerServerVersionCapability> array = new List<PostgreSqlFlexibleServerServerVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerServerVersionCapability.DeserializePostgreSqlFlexibleServerServerVersionCapability(item));
                    }
                    supportedServerVersions = array;
                    continue;
                }
                if (property.NameEquals("fastProvisioningSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fastProvisioningSupported = new PostgreSqlFlexibleServerFastProvisioningSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportedFastProvisioningEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerFastProvisioningEditionCapability> array = new List<PostgreSqlFlexibleServerFastProvisioningEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerFastProvisioningEditionCapability.DeserializePostgreSqlFlexibleServerFastProvisioningEditionCapability(item));
                    }
                    supportedFastProvisioningEditions = array;
                    continue;
                }
                if (property.NameEquals("geoBackupSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupSupported = new PostgreSqlFlexibleServerGeoBackupSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zoneRedundantHaSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundantHaSupported = new PostgreSqlFlexibleServerZoneRedundantHaSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zoneRedundantHaAndGeoBackupSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundantHaAndGeoBackupSupported = new PostgreSqlFlexibleServerZoneRedundantHaAndGeoBackupSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAutoGrowthSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAutoGrowthSupported = new PostgreSqlFlexibleServerStorageAutoGrowthSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onlineResizeSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlineResizeSupported = new PostgreSqlFlexibleServerOnlineResizeSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restricted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restricted = new PostgreSqlFlexibleServerZoneRedundantRestricted(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerCapabilityProperties(Optional.ToNullable(status), reason.Value, name.Value, Optional.ToList(supportedServerEditions), Optional.ToList(supportedServerVersions), Optional.ToNullable(fastProvisioningSupported), Optional.ToList(supportedFastProvisioningEditions), Optional.ToNullable(geoBackupSupported), Optional.ToNullable(zoneRedundantHaSupported), Optional.ToNullable(zoneRedundantHaAndGeoBackupSupported), Optional.ToNullable(storageAutoGrowthSupported), Optional.ToNullable(onlineResizeSupported), Optional.ToNullable(restricted));
        }
    }
}