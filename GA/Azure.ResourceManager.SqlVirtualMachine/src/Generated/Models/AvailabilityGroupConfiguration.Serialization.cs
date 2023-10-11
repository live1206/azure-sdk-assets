// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    internal partial class AvailabilityGroupConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Replicas))
            {
                writer.WritePropertyName("replicas"u8);
                writer.WriteStartArray();
                foreach (var item in Replicas)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AvailabilityGroupConfiguration DeserializeAvailabilityGroupConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AvailabilityGroupReplica>> replicas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailabilityGroupReplica> array = new List<AvailabilityGroupReplica>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailabilityGroupReplica.DeserializeAvailabilityGroupReplica(item));
                    }
                    replicas = array;
                    continue;
                }
            }
            return new AvailabilityGroupConfiguration(Optional.ToList(replicas));
        }
    }
}