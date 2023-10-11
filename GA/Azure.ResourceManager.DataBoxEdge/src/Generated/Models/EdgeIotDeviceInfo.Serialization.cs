// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeIotDeviceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("deviceId"u8);
            writer.WriteStringValue(DeviceId);
            writer.WritePropertyName("ioTHostHub"u8);
            writer.WriteStringValue(IotHostHub);
            if (Optional.IsDefined(IotHostHubId))
            {
                writer.WritePropertyName("ioTHostHubId"u8);
                writer.WriteStringValue(IotHostHubId);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            writer.WriteEndObject();
        }

        internal static EdgeIotDeviceInfo DeserializeEdgeIotDeviceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deviceId = default;
            string iotHostHub = default;
            Optional<ResourceIdentifier> iotHostHubId = default;
            Optional<Authentication> authentication = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ioTHostHub"u8))
                {
                    iotHostHub = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ioTHostHubId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iotHostHubId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = Authentication.DeserializeAuthentication(property.Value);
                    continue;
                }
            }
            return new EdgeIotDeviceInfo(deviceId, iotHostHub, iotHostHubId.Value, authentication.Value);
        }
    }
}