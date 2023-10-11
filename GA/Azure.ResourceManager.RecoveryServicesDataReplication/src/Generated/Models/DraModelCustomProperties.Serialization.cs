// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DraModelCustomProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }

        internal static DraModelCustomProperties DeserializeDraModelCustomProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DraModelCustomProperties": return GeneralDraModelCustomProperties.DeserializeGeneralDraModelCustomProperties(element);
                    case "VMware": return VMwareDraModelCustomProperties.DeserializeVMwareDraModelCustomProperties(element);
                }
            }
            return UnknownDraModelCustomProperties.DeserializeUnknownDraModelCustomProperties(element);
        }
    }
}