// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticDetectorResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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
            if (Optional.IsDefined(IssueDetected))
            {
                writer.WritePropertyName("issueDetected"u8);
                writer.WriteBooleanValue(IssueDetected.Value);
            }
            if (Optional.IsDefined(DetectorDefinition))
            {
                writer.WritePropertyName("detectorDefinition"u8);
                writer.WriteObjectValue(DetectorDefinition);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AbnormalTimePeriods))
            {
                writer.WritePropertyName("abnormalTimePeriods"u8);
                writer.WriteStartArray();
                foreach (var item in AbnormalTimePeriods)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResponseMetaData))
            {
                writer.WritePropertyName("responseMetaData"u8);
                writer.WriteObjectValue(ResponseMetaData);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DiagnosticDetectorResponse DeserializeDiagnosticDetectorResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<bool> issueDetected = default;
            Optional<DetectorDefinition> detectorDefinition = default;
            Optional<IList<DiagnosticMetricSet>> metrics = default;
            Optional<IList<DetectorAbnormalTimePeriod>> abnormalTimePeriods = default;
            Optional<IList<IList<AppServiceNameValuePair>>> data = default;
            Optional<DetectorMetadata> responseMetaData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("issueDetected"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            issueDetected = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("detectorDefinition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detectorDefinition = DetectorDefinition.DeserializeDetectorDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DiagnosticMetricSet> array = new List<DiagnosticMetricSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiagnosticMetricSet.DeserializeDiagnosticMetricSet(item));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("abnormalTimePeriods"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DetectorAbnormalTimePeriod> array = new List<DetectorAbnormalTimePeriod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DetectorAbnormalTimePeriod.DeserializeDetectorAbnormalTimePeriod(item));
                            }
                            abnormalTimePeriods = array;
                            continue;
                        }
                        if (property0.NameEquals("data"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IList<AppServiceNameValuePair>> array = new List<IList<AppServiceNameValuePair>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    List<AppServiceNameValuePair> array0 = new List<AppServiceNameValuePair>();
                                    foreach (var item0 in item.EnumerateArray())
                                    {
                                        array0.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item0));
                                    }
                                    array.Add(array0);
                                }
                            }
                            data = array;
                            continue;
                        }
                        if (property0.NameEquals("responseMetaData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            responseMetaData = DetectorMetadata.DeserializeDetectorMetadata(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DiagnosticDetectorResponse(id, name, type, systemData.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(issueDetected), detectorDefinition.Value, Optional.ToList(metrics), Optional.ToList(abnormalTimePeriods), Optional.ToList(data), responseMetaData.Value, kind.Value);
        }
    }
}