// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    internal partial class UnknownPartitionSchemeDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownPartitionSchemeDescription DeserializeUnknownPartitionSchemeDescription(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApplicationPartitionScheme partitionScheme = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new ApplicationPartitionScheme(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownPartitionSchemeDescription(partitionScheme);
        }
    }
}