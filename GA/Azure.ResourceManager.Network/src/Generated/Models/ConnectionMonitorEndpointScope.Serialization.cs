// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpointScope : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Include))
            {
                writer.WritePropertyName("include"u8);
                writer.WriteStartArray();
                foreach (var item in Include)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Exclude))
            {
                writer.WritePropertyName("exclude"u8);
                writer.WriteStartArray();
                foreach (var item in Exclude)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorEndpointScope DeserializeConnectionMonitorEndpointScope(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ConnectionMonitorEndpointScopeItem>> include = default;
            Optional<IList<ConnectionMonitorEndpointScopeItem>> exclude = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionMonitorEndpointScopeItem> array = new List<ConnectionMonitorEndpointScopeItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorEndpointScopeItem.DeserializeConnectionMonitorEndpointScopeItem(item));
                    }
                    include = array;
                    continue;
                }
                if (property.NameEquals("exclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionMonitorEndpointScopeItem> array = new List<ConnectionMonitorEndpointScopeItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorEndpointScopeItem.DeserializeConnectionMonitorEndpointScopeItem(item));
                    }
                    exclude = array;
                    continue;
                }
            }
            return new ConnectionMonitorEndpointScope(Optional.ToList(include), Optional.ToList(exclude));
        }
    }
}