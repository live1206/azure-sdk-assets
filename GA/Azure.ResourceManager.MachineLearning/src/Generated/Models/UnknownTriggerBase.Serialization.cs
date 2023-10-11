// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownTriggerBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EndTime))
            {
                if (EndTime != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndTime);
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (Optional.IsDefined(StartTime))
            {
                if (StartTime != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartTime);
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            writer.WritePropertyName("triggerType"u8);
            writer.WriteStringValue(TriggerType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownTriggerBase DeserializeUnknownTriggerBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> endTime = default;
            Optional<string> startTime = default;
            Optional<string> timeZone = default;
            MachineLearningTriggerType triggerType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"u8))
                {
                    triggerType = new MachineLearningTriggerType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownTriggerBase(endTime.Value, startTime.Value, timeZone.Value, triggerType);
        }
    }
}