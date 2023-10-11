// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlClientEncryptionKeyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(EncryptionAlgorithm))
            {
                writer.WritePropertyName("encryptionAlgorithm"u8);
                writer.WriteStringValue(EncryptionAlgorithm);
            }
            if (Optional.IsDefined(WrappedDataEncryptionKey))
            {
                writer.WritePropertyName("wrappedDataEncryptionKey"u8);
                writer.WriteBase64StringValue(WrappedDataEncryptionKey, "D");
            }
            if (Optional.IsDefined(KeyWrapMetadata))
            {
                writer.WritePropertyName("keyWrapMetadata"u8);
                writer.WriteObjectValue(KeyWrapMetadata);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBSqlClientEncryptionKeyProperties DeserializeCosmosDBSqlClientEncryptionKeyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            Optional<string> id = default;
            Optional<string> encryptionAlgorithm = default;
            Optional<byte[]> wrappedDataEncryptionKey = default;
            Optional<CosmosDBKeyWrapMetadata> keyWrapMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"u8))
                {
                    encryptionAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wrappedDataEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wrappedDataEncryptionKey = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("keyWrapMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyWrapMetadata = CosmosDBKeyWrapMetadata.DeserializeCosmosDBKeyWrapMetadata(property.Value);
                    continue;
                }
            }
            return new CosmosDBSqlClientEncryptionKeyProperties(id.Value, encryptionAlgorithm.Value, wrappedDataEncryptionKey.Value, keyWrapMetadata.Value, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }
    }
}