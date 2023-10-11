// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class DateAfterCreation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("daysAfterCreationGreaterThan"u8);
            writer.WriteNumberValue(DaysAfterCreationGreaterThan);
            if (Optional.IsDefined(DaysAfterLastTierChangeGreaterThan))
            {
                writer.WritePropertyName("daysAfterLastTierChangeGreaterThan"u8);
                writer.WriteNumberValue(DaysAfterLastTierChangeGreaterThan.Value);
            }
            writer.WriteEndObject();
        }

        internal static DateAfterCreation DeserializeDateAfterCreation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float daysAfterCreationGreaterThan = default;
            Optional<float> daysAfterLastTierChangeGreaterThan = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysAfterCreationGreaterThan"u8))
                {
                    daysAfterCreationGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("daysAfterLastTierChangeGreaterThan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    daysAfterLastTierChangeGreaterThan = property.Value.GetSingle();
                    continue;
                }
            }
            return new DateAfterCreation(daysAfterCreationGreaterThan, Optional.ToNullable(daysAfterLastTierChangeGreaterThan));
        }
    }
}