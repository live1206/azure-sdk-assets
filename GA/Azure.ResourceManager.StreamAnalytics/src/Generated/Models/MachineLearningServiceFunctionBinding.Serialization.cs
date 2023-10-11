// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class MachineLearningServiceFunctionBinding : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionBindingType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Optional.IsDefined(NumberOfParallelRequests))
            {
                writer.WritePropertyName("numberOfParallelRequests"u8);
                writer.WriteNumberValue(NumberOfParallelRequests.Value);
            }
            if (Optional.IsDefined(InputRequestName))
            {
                writer.WritePropertyName("inputRequestName"u8);
                writer.WriteStringValue(InputRequestName);
            }
            if (Optional.IsDefined(OutputResponseName))
            {
                writer.WritePropertyName("outputResponseName"u8);
                writer.WriteStringValue(OutputResponseName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MachineLearningServiceFunctionBinding DeserializeMachineLearningServiceFunctionBinding(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> endpoint = default;
            Optional<string> apiKey = default;
            Optional<IList<MachineLearningServiceInputColumn>> inputs = default;
            Optional<IList<MachineLearningServiceOutputColumn>> outputs = default;
            Optional<int> batchSize = default;
            Optional<int> numberOfParallelRequests = default;
            Optional<string> inputRequestName = default;
            Optional<string> outputResponseName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiKey"u8))
                        {
                            apiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineLearningServiceInputColumn> array = new List<MachineLearningServiceInputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineLearningServiceInputColumn.DeserializeMachineLearningServiceInputColumn(item));
                            }
                            inputs = array;
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineLearningServiceOutputColumn> array = new List<MachineLearningServiceOutputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineLearningServiceOutputColumn.DeserializeMachineLearningServiceOutputColumn(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("batchSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            batchSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfParallelRequests"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfParallelRequests = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("inputRequestName"u8))
                        {
                            inputRequestName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outputResponseName"u8))
                        {
                            outputResponseName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MachineLearningServiceFunctionBinding(type, endpoint.Value, apiKey.Value, Optional.ToList(inputs), Optional.ToList(outputs), Optional.ToNullable(batchSize), Optional.ToNullable(numberOfParallelRequests), inputRequestName.Value, outputResponseName.Value);
        }
    }
}