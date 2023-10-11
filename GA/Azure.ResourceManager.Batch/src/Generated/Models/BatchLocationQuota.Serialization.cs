// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchLocationQuota
    {
        internal static BatchLocationQuota DeserializeBatchLocationQuota(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> accountQuota = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountQuota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountQuota = property.Value.GetInt32();
                    continue;
                }
            }
            return new BatchLocationQuota(Optional.ToNullable(accountQuota));
        }
    }
}