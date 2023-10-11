// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class SharedPrivateLinkResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLink))
            {
                writer.WritePropertyName("privateLink"u8);
                JsonSerializer.Serialize(writer, PrivateLink);
            }
            if (Optional.IsDefined(PrivateLinkLocation))
            {
                writer.WritePropertyName("privateLinkLocation"u8);
                writer.WriteStringValue(PrivateLinkLocation);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage"u8);
                writer.WriteStringValue(RequestMessage);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static SharedPrivateLinkResourceProperties DeserializeSharedPrivateLinkResourceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> privateLink = default;
            Optional<string> privateLinkLocation = default;
            Optional<string> groupId = default;
            Optional<string> requestMessage = default;
            Optional<SharedPrivateLinkResourceStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLink = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkLocation"u8))
                {
                    privateLinkLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestMessage"u8))
                {
                    requestMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSharedPrivateLinkResourceStatus();
                    continue;
                }
            }
            return new SharedPrivateLinkResourceProperties(privateLink, privateLinkLocation.Value, groupId.Value, requestMessage.Value, Optional.ToNullable(status));
        }
    }
}