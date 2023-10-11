// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevSpaces.Models
{
    public partial class ListConnectionDetailsContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetContainerHostResourceId"u8);
            writer.WriteStringValue(TargetContainerHostResourceId);
            writer.WriteEndObject();
        }
    }
}
