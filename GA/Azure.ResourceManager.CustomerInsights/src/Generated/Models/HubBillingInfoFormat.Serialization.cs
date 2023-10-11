// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class HubBillingInfoFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SkuName))
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
            }
            if (Optional.IsDefined(MinUnits))
            {
                writer.WritePropertyName("minUnits"u8);
                writer.WriteNumberValue(MinUnits.Value);
            }
            if (Optional.IsDefined(MaxUnits))
            {
                writer.WritePropertyName("maxUnits"u8);
                writer.WriteNumberValue(MaxUnits.Value);
            }
            writer.WriteEndObject();
        }

        internal static HubBillingInfoFormat DeserializeHubBillingInfoFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> skuName = default;
            Optional<int> minUnits = default;
            Optional<int> maxUnits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skuName"u8))
                {
                    skuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minUnits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnits = property.Value.GetInt32();
                    continue;
                }
            }
            return new HubBillingInfoFormat(skuName.Value, Optional.ToNullable(minUnits), Optional.ToNullable(maxUnits));
        }
    }
}