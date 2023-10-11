// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountTrackingEvent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("eventLevel"u8);
            writer.WriteStringValue(EventLevel.ToSerialString());
            writer.WritePropertyName("eventTime"u8);
            writer.WriteStringValue(EventOn, "O");
            writer.WritePropertyName("recordType"u8);
            writer.WriteStringValue(RecordType.ToString());
            if (Optional.IsDefined(Record))
            {
                writer.WritePropertyName("record"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Record);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Record.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            writer.WriteEndObject();
        }
    }
}
