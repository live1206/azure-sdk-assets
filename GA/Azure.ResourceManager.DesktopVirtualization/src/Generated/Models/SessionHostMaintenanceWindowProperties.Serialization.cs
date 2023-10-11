// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class SessionHostMaintenanceWindowProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Hour))
            {
                writer.WritePropertyName("hour"u8);
                writer.WriteNumberValue(Hour.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteStringValue(DayOfWeek.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static SessionHostMaintenanceWindowProperties DeserializeSessionHostMaintenanceWindowProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> hour = default;
            Optional<DesktopVirtualizationDayOfWeek> dayOfWeek = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hour"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetString().ToDesktopVirtualizationDayOfWeek();
                    continue;
                }
            }
            return new SessionHostMaintenanceWindowProperties(Optional.ToNullable(hour), Optional.ToNullable(dayOfWeek));
        }
    }
}