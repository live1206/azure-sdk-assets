// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql
{
    public partial class MySqlQueryStatisticData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(QueryId))
            {
                writer.WritePropertyName("queryId"u8);
                writer.WriteStringValue(QueryId);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(AggregationFunction))
            {
                writer.WritePropertyName("aggregationFunction"u8);
                writer.WriteStringValue(AggregationFunction);
            }
            if (Optional.IsCollectionDefined(DatabaseNames))
            {
                writer.WritePropertyName("databaseNames"u8);
                writer.WriteStartArray();
                foreach (var item in DatabaseNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(QueryExecutionCount))
            {
                writer.WritePropertyName("queryExecutionCount"u8);
                writer.WriteNumberValue(QueryExecutionCount.Value);
            }
            if (Optional.IsDefined(MetricName))
            {
                writer.WritePropertyName("metricName"u8);
                writer.WriteStringValue(MetricName);
            }
            if (Optional.IsDefined(MetricDisplayName))
            {
                writer.WritePropertyName("metricDisplayName"u8);
                writer.WriteStringValue(MetricDisplayName);
            }
            if (Optional.IsDefined(MetricValue))
            {
                writer.WritePropertyName("metricValue"u8);
                writer.WriteNumberValue(MetricValue.Value);
            }
            if (Optional.IsDefined(MetricValueUnit))
            {
                writer.WritePropertyName("metricValueUnit"u8);
                writer.WriteStringValue(MetricValueUnit);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MySqlQueryStatisticData DeserializeMySqlQueryStatisticData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> queryId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> aggregationFunction = default;
            Optional<IList<string>> databaseNames = default;
            Optional<long> queryExecutionCount = default;
            Optional<string> metricName = default;
            Optional<string> metricDisplayName = default;
            Optional<double> metricValue = default;
            Optional<string> metricValueUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("queryId"u8))
                        {
                            queryId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("aggregationFunction"u8))
                        {
                            aggregationFunction = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            databaseNames = array;
                            continue;
                        }
                        if (property0.NameEquals("queryExecutionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryExecutionCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("metricName"u8))
                        {
                            metricName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricDisplayName"u8))
                        {
                            metricDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricValue"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metricValue = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("metricValueUnit"u8))
                        {
                            metricValueUnit = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MySqlQueryStatisticData(id, name, type, systemData.Value, queryId.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), aggregationFunction.Value, Optional.ToList(databaseNames), Optional.ToNullable(queryExecutionCount), metricName.Value, metricDisplayName.Value, Optional.ToNullable(metricValue), metricValueUnit.Value);
        }
    }
}