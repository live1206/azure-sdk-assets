// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesRoleResources : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteObjectValue(Storage);
            }
            writer.WritePropertyName("compute"u8);
            writer.WriteObjectValue(Compute);
            writer.WriteEndObject();
        }

        internal static EdgeKubernetesRoleResources DeserializeEdgeKubernetesRoleResources(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeKubernetesRoleStorage> storage = default;
            EdgeKubernetesRoleCompute compute = default;
            Optional<EdgeKubernetesRoleNetwork> network = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storage = EdgeKubernetesRoleStorage.DeserializeEdgeKubernetesRoleStorage(property.Value);
                    continue;
                }
                if (property.NameEquals("compute"u8))
                {
                    compute = EdgeKubernetesRoleCompute.DeserializeEdgeKubernetesRoleCompute(property.Value);
                    continue;
                }
                if (property.NameEquals("network"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    network = EdgeKubernetesRoleNetwork.DeserializeEdgeKubernetesRoleNetwork(property.Value);
                    continue;
                }
            }
            return new EdgeKubernetesRoleResources(storage.Value, compute, network.Value);
        }
    }
}