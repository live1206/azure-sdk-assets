// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class LoadBalancingSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SampleSize))
            {
                writer.WritePropertyName("sampleSize"u8);
                writer.WriteNumberValue(SampleSize.Value);
            }
            if (Optional.IsDefined(SuccessfulSamplesRequired))
            {
                writer.WritePropertyName("successfulSamplesRequired"u8);
                writer.WriteNumberValue(SuccessfulSamplesRequired.Value);
            }
            if (Optional.IsDefined(AdditionalLatencyInMilliseconds))
            {
                writer.WritePropertyName("additionalLatencyInMilliseconds"u8);
                writer.WriteNumberValue(AdditionalLatencyInMilliseconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static LoadBalancingSettings DeserializeLoadBalancingSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> sampleSize = default;
            Optional<int> successfulSamplesRequired = default;
            Optional<int> additionalLatencyInMilliseconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sampleSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sampleSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successfulSamplesRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successfulSamplesRequired = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("additionalLatencyInMilliseconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalLatencyInMilliseconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new LoadBalancingSettings(Optional.ToNullable(sampleSize), Optional.ToNullable(successfulSamplesRequired), Optional.ToNullable(additionalLatencyInMilliseconds));
        }
    }
}