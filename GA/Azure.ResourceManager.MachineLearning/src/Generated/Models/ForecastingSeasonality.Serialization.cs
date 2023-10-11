// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ForecastingSeasonality : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static ForecastingSeasonality DeserializeForecastingSeasonality(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mode", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Auto": return AutoSeasonality.DeserializeAutoSeasonality(element);
                    case "Custom": return CustomSeasonality.DeserializeCustomSeasonality(element);
                }
            }
            return UnknownSeasonality.DeserializeUnknownSeasonality(element);
        }
    }
}
