// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricAccessControlListPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConfigurationType))
            {
                writer.WritePropertyName("configurationType"u8);
                writer.WriteStringValue(ConfigurationType.Value.ToString());
            }
            if (Optional.IsDefined(AclsUri))
            {
                writer.WritePropertyName("aclsUrl"u8);
                writer.WriteStringValue(AclsUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MatchConfigurations))
            {
                writer.WritePropertyName("matchConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in MatchConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DynamicMatchConfigurations))
            {
                writer.WritePropertyName("dynamicMatchConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in DynamicMatchConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}