// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineHardwareProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize.Value.ToString());
            }
            if (Optional.IsDefined(VmSizeProperties))
            {
                writer.WritePropertyName("vmSizeProperties"u8);
                writer.WriteObjectValue(VmSizeProperties);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineHardwareProfile DeserializeVirtualMachineHardwareProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualMachineSizeType> vmSize = default;
            Optional<VirtualMachineSizeProperties> vmSizeProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmSize = new VirtualMachineSizeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmSizeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmSizeProperties = VirtualMachineSizeProperties.DeserializeVirtualMachineSizeProperties(property.Value);
                    continue;
                }
            }
            return new VirtualMachineHardwareProfile(Optional.ToNullable(vmSize), vmSizeProperties.Value);
        }
    }
}