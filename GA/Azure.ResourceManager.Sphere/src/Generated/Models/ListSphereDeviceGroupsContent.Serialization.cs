// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class ListSphereDeviceGroupsContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceGroupName))
            {
                writer.WritePropertyName("deviceGroupName"u8);
                writer.WriteStringValue(DeviceGroupName);
            }
            writer.WriteEndObject();
        }
    }
}