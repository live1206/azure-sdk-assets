// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningOnlineScaleSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("scaleType"u8);
            writer.WriteStringValue(ScaleType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningOnlineScaleSettings DeserializeMachineLearningOnlineScaleSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("scaleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Default": return MachineLearningDefaultScaleSettings.DeserializeMachineLearningDefaultScaleSettings(element);
                    case "TargetUtilization": return MachineLearningTargetUtilizationScaleSettings.DeserializeMachineLearningTargetUtilizationScaleSettings(element);
                }
            }
            return UnknownOnlineScaleSettings.DeserializeUnknownOnlineScaleSettings(element);
        }
    }
}