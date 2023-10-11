// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class DiskPoolIscsiTargetPortalGroupAcl : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("initiatorIqn"u8);
            writer.WriteStringValue(InitiatorIqn);
            writer.WritePropertyName("mappedLuns"u8);
            writer.WriteStartArray();
            foreach (var item in MappedLuns)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static DiskPoolIscsiTargetPortalGroupAcl DeserializeDiskPoolIscsiTargetPortalGroupAcl(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string initiatorIqn = default;
            IList<string> mappedLuns = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initiatorIqn"u8))
                {
                    initiatorIqn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mappedLuns"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    mappedLuns = array;
                    continue;
                }
            }
            return new DiskPoolIscsiTargetPortalGroupAcl(initiatorIqn, mappedLuns);
        }
    }
}