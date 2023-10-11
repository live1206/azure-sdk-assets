// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class EncoderPresetConfigurations : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Complexity))
            {
                writer.WritePropertyName("complexity"u8);
                writer.WriteStringValue(Complexity.Value.ToString());
            }
            if (Optional.IsDefined(InterleaveOutput))
            {
                writer.WritePropertyName("interleaveOutput"u8);
                writer.WriteStringValue(InterleaveOutput.Value.ToString());
            }
            if (Optional.IsDefined(KeyFrameIntervalInSeconds))
            {
                writer.WritePropertyName("keyFrameIntervalInSeconds"u8);
                writer.WriteNumberValue(KeyFrameIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(MaxBitrateBps))
            {
                writer.WritePropertyName("maxBitrateBps"u8);
                writer.WriteNumberValue(MaxBitrateBps.Value);
            }
            if (Optional.IsDefined(MaxHeight))
            {
                writer.WritePropertyName("maxHeight"u8);
                writer.WriteNumberValue(MaxHeight.Value);
            }
            if (Optional.IsDefined(MaxLayers))
            {
                writer.WritePropertyName("maxLayers"u8);
                writer.WriteNumberValue(MaxLayers.Value);
            }
            if (Optional.IsDefined(MinBitrateBps))
            {
                writer.WritePropertyName("minBitrateBps"u8);
                writer.WriteNumberValue(MinBitrateBps.Value);
            }
            if (Optional.IsDefined(MinHeight))
            {
                writer.WritePropertyName("minHeight"u8);
                writer.WriteNumberValue(MinHeight.Value);
            }
            writer.WriteEndObject();
        }

        internal static EncoderPresetConfigurations DeserializeEncoderPresetConfigurations(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EncodingComplexity> complexity = default;
            Optional<InterleaveOutput> interleaveOutput = default;
            Optional<float> keyFrameIntervalInSeconds = default;
            Optional<int> maxBitrateBps = default;
            Optional<int> maxHeight = default;
            Optional<int> maxLayers = default;
            Optional<int> minBitrateBps = default;
            Optional<int> minHeight = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complexity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complexity = new EncodingComplexity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("interleaveOutput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interleaveOutput = new InterleaveOutput(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyFrameIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyFrameIntervalInSeconds = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("maxBitrateBps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBitrateBps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxHeight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxHeight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLayers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLayers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBitrateBps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBitrateBps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minHeight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minHeight = property.Value.GetInt32();
                    continue;
                }
            }
            return new EncoderPresetConfigurations(Optional.ToNullable(complexity), Optional.ToNullable(interleaveOutput), Optional.ToNullable(keyFrameIntervalInSeconds), Optional.ToNullable(maxBitrateBps), Optional.ToNullable(maxHeight), Optional.ToNullable(maxLayers), Optional.ToNullable(minBitrateBps), Optional.ToNullable(minHeight));
        }
    }
}