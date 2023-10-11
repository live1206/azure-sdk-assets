// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class DefenderForServersGcpOfferingSubPlan : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AvailableSubPlanType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AvailableSubPlanType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DefenderForServersGcpOfferingSubPlan DeserializeDefenderForServersGcpOfferingSubPlan(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AvailableSubPlanType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AvailableSubPlanType(property.Value.GetString());
                    continue;
                }
            }
            return new DefenderForServersGcpOfferingSubPlan(Optional.ToNullable(type));
        }
    }
}