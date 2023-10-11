// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    internal partial class UnknownAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownAction DeserializeUnknownAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertProcessingRuleActionType actionType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new AlertProcessingRuleActionType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAction(actionType);
        }
    }
}