// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class NodeMonitoringData
    {
        internal static NodeMonitoringData DeserializeNodeMonitoringData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalProperties = default;
            Optional<string> nodeName = default;
            Optional<int> availableMemoryInMB = default;
            Optional<int> cpuUtilization = default;
            Optional<int> concurrentJobsLimit = default;
            Optional<int> concurrentJobsRunning = default;
            Optional<int> maxConcurrentJobs = default;
            Optional<double> sentBytes = default;
            Optional<double> receivedBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    additionalProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableMemoryInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuUtilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUtilization = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsRunning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsRunning = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sentBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sentBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("receivedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    receivedBytes = property.Value.GetDouble();
                    continue;
                }
            }
            return new NodeMonitoringData(Optional.ToDictionary(additionalProperties), nodeName.Value, Optional.ToNullable(availableMemoryInMB), Optional.ToNullable(cpuUtilization), Optional.ToNullable(concurrentJobsLimit), Optional.ToNullable(concurrentJobsRunning), Optional.ToNullable(maxConcurrentJobs), Optional.ToNullable(sentBytes), Optional.ToNullable(receivedBytes));
        }
    }
}