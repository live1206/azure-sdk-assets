// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceEditionCapability
    {
        internal static ManagedInstanceEditionCapability DeserializeManagedInstanceEditionCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<ManagedInstanceFamilyCapability>> supportedFamilies = default;
            Optional<IReadOnlyList<StorageCapability>> supportedStorageCapabilities = default;
            Optional<bool> zoneRedundant = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedFamilies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceFamilyCapability> array = new List<ManagedInstanceFamilyCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceFamilyCapability.DeserializeManagedInstanceFamilyCapability(item));
                    }
                    supportedFamilies = array;
                    continue;
                }
                if (property.NameEquals("supportedStorageCapabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageCapability> array = new List<StorageCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageCapability.DeserializeStorageCapability(item));
                    }
                    supportedStorageCapabilities = array;
                    continue;
                }
                if (property.NameEquals("zoneRedundant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedInstanceEditionCapability(name.Value, Optional.ToList(supportedFamilies), Optional.ToList(supportedStorageCapabilities), Optional.ToNullable(zoneRedundant), Optional.ToNullable(status), reason.Value);
        }
    }
}
