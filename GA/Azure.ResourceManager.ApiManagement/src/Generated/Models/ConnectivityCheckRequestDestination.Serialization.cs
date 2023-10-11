// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityCheckRequestDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("address"u8);
            writer.WriteStringValue(Address);
            writer.WritePropertyName("port"u8);
            writer.WriteNumberValue(Port);
            writer.WriteEndObject();
        }
    }
}