// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class LogAnalyticsConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId"u8);
                writer.WriteStringValue(CustomerId);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            writer.WriteEndObject();
        }

        internal static LogAnalyticsConfiguration DeserializeLogAnalyticsConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> customerId = default;
            Optional<string> sharedKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customerId"u8))
                {
                    customerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sharedKey"u8))
                {
                    sharedKey = property.Value.GetString();
                    continue;
                }
            }
            return new LogAnalyticsConfiguration(customerId.Value, sharedKey.Value);
        }
    }
}
