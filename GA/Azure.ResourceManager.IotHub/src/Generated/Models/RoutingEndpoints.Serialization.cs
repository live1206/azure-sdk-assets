// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingEndpoints : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ServiceBusQueues))
            {
                writer.WritePropertyName("serviceBusQueues"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBusQueues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceBusTopics))
            {
                writer.WritePropertyName("serviceBusTopics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBusTopics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EventHubs))
            {
                writer.WritePropertyName("eventHubs"u8);
                writer.WriteStartArray();
                foreach (var item in EventHubs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StorageContainers))
            {
                writer.WritePropertyName("storageContainers"u8);
                writer.WriteStartArray();
                foreach (var item in StorageContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CosmosDBSqlContainers))
            {
                writer.WritePropertyName("cosmosDBSqlContainers"u8);
                writer.WriteStartArray();
                foreach (var item in CosmosDBSqlContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RoutingEndpoints DeserializeRoutingEndpoints(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<RoutingServiceBusQueueEndpointProperties>> serviceBusQueues = default;
            Optional<IList<RoutingServiceBusTopicEndpointProperties>> serviceBusTopics = default;
            Optional<IList<RoutingEventHubProperties>> eventHubs = default;
            Optional<IList<RoutingStorageContainerProperties>> storageContainers = default;
            Optional<IList<RoutingCosmosDBSqlApiProperties>> cosmosDBSqlContainers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceBusQueues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingServiceBusQueueEndpointProperties> array = new List<RoutingServiceBusQueueEndpointProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingServiceBusQueueEndpointProperties.DeserializeRoutingServiceBusQueueEndpointProperties(item));
                    }
                    serviceBusQueues = array;
                    continue;
                }
                if (property.NameEquals("serviceBusTopics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingServiceBusTopicEndpointProperties> array = new List<RoutingServiceBusTopicEndpointProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingServiceBusTopicEndpointProperties.DeserializeRoutingServiceBusTopicEndpointProperties(item));
                    }
                    serviceBusTopics = array;
                    continue;
                }
                if (property.NameEquals("eventHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingEventHubProperties> array = new List<RoutingEventHubProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingEventHubProperties.DeserializeRoutingEventHubProperties(item));
                    }
                    eventHubs = array;
                    continue;
                }
                if (property.NameEquals("storageContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingStorageContainerProperties> array = new List<RoutingStorageContainerProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingStorageContainerProperties.DeserializeRoutingStorageContainerProperties(item));
                    }
                    storageContainers = array;
                    continue;
                }
                if (property.NameEquals("cosmosDBSqlContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingCosmosDBSqlApiProperties> array = new List<RoutingCosmosDBSqlApiProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingCosmosDBSqlApiProperties.DeserializeRoutingCosmosDBSqlApiProperties(item));
                    }
                    cosmosDBSqlContainers = array;
                    continue;
                }
            }
            return new RoutingEndpoints(Optional.ToList(serviceBusQueues), Optional.ToList(serviceBusTopics), Optional.ToList(eventHubs), Optional.ToList(storageContainers), Optional.ToList(cosmosDBSqlContainers));
        }
    }
}