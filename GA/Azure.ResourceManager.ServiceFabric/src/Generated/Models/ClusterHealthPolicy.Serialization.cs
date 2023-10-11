// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterHealthPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxPercentUnhealthyNodes))
            {
                writer.WritePropertyName("maxPercentUnhealthyNodes"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyNodes.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyApplications))
            {
                writer.WritePropertyName("maxPercentUnhealthyApplications"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyApplications.Value);
            }
            if (Optional.IsCollectionDefined(ApplicationHealthPolicies))
            {
                writer.WritePropertyName("applicationHealthPolicies"u8);
                writer.WriteStartObject();
                foreach (var item in ApplicationHealthPolicies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ClusterHealthPolicy DeserializeClusterHealthPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxPercentUnhealthyNodes = default;
            Optional<int> maxPercentUnhealthyApplications = default;
            Optional<IDictionary<string, ApplicationHealthPolicy>> applicationHealthPolicies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentUnhealthyNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyApplications = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("applicationHealthPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ApplicationHealthPolicy> dictionary = new Dictionary<string, ApplicationHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ApplicationHealthPolicy.DeserializeApplicationHealthPolicy(property0.Value));
                    }
                    applicationHealthPolicies = dictionary;
                    continue;
                }
            }
            return new ClusterHealthPolicy(Optional.ToNullable(maxPercentUnhealthyNodes), Optional.ToNullable(maxPercentUnhealthyApplications), Optional.ToDictionary(applicationHealthPolicies));
        }
    }
}
