// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RestorableTimeRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndOn, "O");
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            writer.WriteEndObject();
        }

        internal static RestorableTimeRange DeserializeRestorableTimeRange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            Optional<string> objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new RestorableTimeRange(startTime, endTime, objectType.Value);
        }
    }
}