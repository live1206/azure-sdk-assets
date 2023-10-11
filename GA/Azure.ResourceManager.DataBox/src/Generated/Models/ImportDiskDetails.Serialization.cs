// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class ImportDiskDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("manifestFile"u8);
            writer.WriteStringValue(ManifestFile);
            writer.WritePropertyName("manifestHash"u8);
            writer.WriteStringValue(ManifestHash);
            writer.WritePropertyName("bitLockerKey"u8);
            writer.WriteStringValue(BitLockerKey);
            writer.WriteEndObject();
        }

        internal static ImportDiskDetails DeserializeImportDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string manifestFile = default;
            string manifestHash = default;
            string bitLockerKey = default;
            Optional<string> backupManifestCloudPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifestFile"u8))
                {
                    manifestFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestHash"u8))
                {
                    manifestHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bitLockerKey"u8))
                {
                    bitLockerKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManifestCloudPath"u8))
                {
                    backupManifestCloudPath = property.Value.GetString();
                    continue;
                }
            }
            return new ImportDiskDetails(manifestFile, manifestHash, bitLockerKey, backupManifestCloudPath.Value);
        }
    }
}