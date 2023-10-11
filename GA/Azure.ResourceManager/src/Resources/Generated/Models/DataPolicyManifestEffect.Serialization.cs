// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DataPolicyManifestEffect
    {
        internal static DataPolicyManifestEffect DeserializeDataPolicyManifestEffect(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<BinaryData> detailsSchema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detailsSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detailsSchema = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new DataPolicyManifestEffect(name.Value, detailsSchema.Value);
        }
    }
}
