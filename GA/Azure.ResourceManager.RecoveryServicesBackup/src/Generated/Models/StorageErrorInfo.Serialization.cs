// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class StorageErrorInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (Optional.IsDefined(ErrorString))
            {
                writer.WritePropertyName("errorString"u8);
                writer.WriteStringValue(ErrorString);
            }
            if (Optional.IsCollectionDefined(Recommendations))
            {
                writer.WritePropertyName("recommendations"u8);
                writer.WriteStartArray();
                foreach (var item in Recommendations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static StorageErrorInfo DeserializeStorageErrorInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> errorCode = default;
            Optional<string> errorString = default;
            Optional<IList<string>> recommendations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorString"u8))
                {
                    errorString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendations"u8))
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
                    recommendations = array;
                    continue;
                }
            }
            return new StorageErrorInfo(Optional.ToNullable(errorCode), errorString.Value, Optional.ToList(recommendations));
        }
    }
}