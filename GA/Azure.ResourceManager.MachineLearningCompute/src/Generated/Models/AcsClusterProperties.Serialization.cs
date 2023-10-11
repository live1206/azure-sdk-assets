// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AcsClusterProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("orchestratorType"u8);
            writer.WriteStringValue(OrchestratorType.ToString());
            if (Optional.IsDefined(OrchestratorProperties))
            {
                writer.WritePropertyName("orchestratorProperties"u8);
                writer.WriteObjectValue(OrchestratorProperties);
            }
            if (Optional.IsCollectionDefined(SystemServices))
            {
                writer.WritePropertyName("systemServices"u8);
                writer.WriteStartArray();
                foreach (var item in SystemServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MasterCount))
            {
                writer.WritePropertyName("masterCount"u8);
                writer.WriteNumberValue(MasterCount.Value);
            }
            if (Optional.IsDefined(AgentCount))
            {
                writer.WritePropertyName("agentCount"u8);
                writer.WriteNumberValue(AgentCount.Value);
            }
            if (Optional.IsDefined(AgentVmSize))
            {
                writer.WritePropertyName("agentVmSize"u8);
                writer.WriteStringValue(AgentVmSize.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AcsClusterProperties DeserializeAcsClusterProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clusterFqdn = default;
            OrchestratorType orchestratorType = default;
            Optional<KubernetesClusterProperties> orchestratorProperties = default;
            Optional<IList<SystemService>> systemServices = default;
            Optional<int> masterCount = default;
            Optional<int> agentCount = default;
            Optional<AgentVmSizeType> agentVmSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFqdn"u8))
                {
                    clusterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orchestratorType"u8))
                {
                    orchestratorType = new OrchestratorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orchestratorProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orchestratorProperties = KubernetesClusterProperties.DeserializeKubernetesClusterProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("systemServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SystemService> array = new List<SystemService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SystemService.DeserializeSystemService(item));
                    }
                    systemServices = array;
                    continue;
                }
                if (property.NameEquals("masterCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    masterCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentVmSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVmSize = new AgentVmSizeType(property.Value.GetString());
                    continue;
                }
            }
            return new AcsClusterProperties(clusterFqdn.Value, orchestratorType, orchestratorProperties.Value, Optional.ToList(systemServices), Optional.ToNullable(masterCount), Optional.ToNullable(agentCount), Optional.ToNullable(agentVmSize));
        }
    }
}