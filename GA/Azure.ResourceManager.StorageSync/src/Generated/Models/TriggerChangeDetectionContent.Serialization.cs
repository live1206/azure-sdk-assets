// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class TriggerChangeDetectionContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DirectoryPath))
            {
                writer.WritePropertyName("directoryPath"u8);
                writer.WriteStringValue(DirectoryPath);
            }
            if (Optional.IsDefined(ChangeDetectionMode))
            {
                writer.WritePropertyName("changeDetectionMode"u8);
                writer.WriteStringValue(ChangeDetectionMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Paths))
            {
                writer.WritePropertyName("paths"u8);
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}