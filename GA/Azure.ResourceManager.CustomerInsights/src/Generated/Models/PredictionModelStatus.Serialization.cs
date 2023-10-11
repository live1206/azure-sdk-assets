// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionModelStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WriteEndObject();
        }

        internal static PredictionModelStatus DeserializePredictionModelStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> tenantId = default;
            Optional<string> predictionName = default;
            Optional<string> predictionGuidId = default;
            PredictionModelLifeCycle status = default;
            Optional<string> message = default;
            Optional<int> trainingSetCount = default;
            Optional<int> testSetCount = default;
            Optional<int> validationSetCount = default;
            Optional<decimal> trainingAccuracy = default;
            Optional<int> signalsUsed = default;
            Optional<string> modelVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("predictionName"u8))
                {
                    predictionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("predictionGuidId"u8))
                {
                    predictionGuidId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new PredictionModelLifeCycle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trainingSetCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainingSetCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("testSetCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testSetCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationSetCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationSetCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trainingAccuracy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainingAccuracy = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("signalsUsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signalsUsed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
            }
            return new PredictionModelStatus(Optional.ToNullable(tenantId), predictionName.Value, predictionGuidId.Value, status, message.Value, Optional.ToNullable(trainingSetCount), Optional.ToNullable(testSetCount), Optional.ToNullable(validationSetCount), Optional.ToNullable(trainingAccuracy), Optional.ToNullable(signalsUsed), modelVersion.Value);
        }
    }
}