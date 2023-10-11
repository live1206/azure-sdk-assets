// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchFileShareConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("azureFileUrl"u8);
            writer.WriteStringValue(FileUri.AbsoluteUri);
            writer.WritePropertyName("accountKey"u8);
            writer.WriteStringValue(AccountKey);
            writer.WritePropertyName("relativeMountPath"u8);
            writer.WriteStringValue(RelativeMountPath);
            if (Optional.IsDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStringValue(MountOptions);
            }
            writer.WriteEndObject();
        }

        internal static BatchFileShareConfiguration DeserializeBatchFileShareConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            Uri azureFileUrl = default;
            string accountKey = default;
            string relativeMountPath = default;
            Optional<string> mountOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFileUrl"u8))
                {
                    azureFileUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"u8))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    mountOptions = property.Value.GetString();
                    continue;
                }
            }
            return new BatchFileShareConfiguration(accountName, azureFileUrl, accountKey, relativeMountPath, mountOptions.Value);
        }
    }
}