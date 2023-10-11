// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class DiskConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DiskVolumeConfigurations))
            {
                writer.WritePropertyName("diskVolumeConfigurations"u8);
                writer.WriteStartObject();
                foreach (var item in DiskVolumeConfigurations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static DiskConfiguration DeserializeDiskConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, DiskVolumeConfiguration>> diskVolumeConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskVolumeConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DiskVolumeConfiguration> dictionary = new Dictionary<string, DiskVolumeConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DiskVolumeConfiguration.DeserializeDiskVolumeConfiguration(property0.Value));
                    }
                    diskVolumeConfigurations = dictionary;
                    continue;
                }
            }
            return new DiskConfiguration(Optional.ToDictionary(diskVolumeConfigurations));
        }
    }
}