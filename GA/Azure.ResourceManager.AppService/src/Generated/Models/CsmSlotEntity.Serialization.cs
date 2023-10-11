// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CsmSlotEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetSlot"u8);
            writer.WriteStringValue(TargetSlot);
            writer.WritePropertyName("preserveVnet"u8);
            writer.WriteBooleanValue(PreserveVnet);
            writer.WriteEndObject();
        }
    }
}