// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class SingletonPartitionScheme : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
            writer.WriteEndObject();
        }

        internal static SingletonPartitionScheme DeserializeSingletonPartitionScheme(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartitionScheme partitionScheme = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
            }
            return new SingletonPartitionScheme(partitionScheme);
        }
    }
}