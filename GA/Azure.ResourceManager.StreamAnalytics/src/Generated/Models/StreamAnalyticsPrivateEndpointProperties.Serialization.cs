// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsPrivateEndpointProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ManualPrivateLinkServiceConnections))
            {
                writer.WritePropertyName("manualPrivateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in ManualPrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static StreamAnalyticsPrivateEndpointProperties DeserializeStreamAnalyticsPrivateEndpointProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> createdDate = default;
            Optional<IList<StreamAnalyticsPrivateLinkServiceConnection>> manualPrivateLinkServiceConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("manualPrivateLinkServiceConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamAnalyticsPrivateLinkServiceConnection> array = new List<StreamAnalyticsPrivateLinkServiceConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamAnalyticsPrivateLinkServiceConnection.DeserializeStreamAnalyticsPrivateLinkServiceConnection(item));
                    }
                    manualPrivateLinkServiceConnections = array;
                    continue;
                }
            }
            return new StreamAnalyticsPrivateEndpointProperties(Optional.ToNullable(createdDate), Optional.ToList(manualPrivateLinkServiceConnections));
        }
    }
}