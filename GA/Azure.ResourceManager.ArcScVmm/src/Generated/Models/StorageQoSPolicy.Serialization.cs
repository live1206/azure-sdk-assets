// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class StorageQoSPolicy
    {
        internal static StorageQoSPolicy DeserializeStorageQoSPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<long> iopsMaximum = default;
            Optional<long> iopsMinimum = default;
            Optional<long> bandwidthLimit = default;
            Optional<string> policyId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iopsMaximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iopsMaximum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("iopsMinimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iopsMinimum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("bandwidthLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bandwidthLimit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
            }
            return new StorageQoSPolicy(name.Value, id.Value, Optional.ToNullable(iopsMaximum), Optional.ToNullable(iopsMinimum), Optional.ToNullable(bandwidthLimit), policyId.Value);
        }
    }
}
