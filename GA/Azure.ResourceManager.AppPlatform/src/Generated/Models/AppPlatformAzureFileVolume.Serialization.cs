// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformAzureFileVolume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("shareName"u8);
            writer.WriteStringValue(ShareName);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UnderlyingResourceType.ToString());
            writer.WritePropertyName("mountPath"u8);
            writer.WriteStringValue(MountPath);
            if (Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("readOnly"u8);
                writer.WriteBooleanValue(IsReadOnly.Value);
            }
            if (Optional.IsCollectionDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStartArray();
                foreach (var item in MountOptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformAzureFileVolume DeserializeAppPlatformAzureFileVolume(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string shareName = default;
            UnderlyingResourceType type = default;
            string mountPath = default;
            Optional<bool> readOnly = default;
            Optional<IList<string>> mountOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareName"u8))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new UnderlyingResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    mountOptions = array;
                    continue;
                }
            }
            return new AppPlatformAzureFileVolume(type, mountPath, Optional.ToNullable(readOnly), Optional.ToList(mountOptions), shareName);
        }
    }
}