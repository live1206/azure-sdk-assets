// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeActionContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Nodes))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsForced))
            {
                writer.WritePropertyName("force"u8);
                writer.WriteBooleanValue(IsForced.Value);
            }
            if (Optional.IsDefined(UpdateType))
            {
                writer.WritePropertyName("updateType"u8);
                writer.WriteStringValue(UpdateType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}