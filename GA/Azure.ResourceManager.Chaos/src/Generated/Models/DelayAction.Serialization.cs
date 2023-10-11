// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class DelayAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("duration"u8);
            writer.WriteStringValue(Duration, "P");
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ActionType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static DelayAction DeserializeDelayAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan duration = default;
            string type = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new DelayAction(type, name, duration);
        }
    }
}