// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class VirtualScsiController
    {
        internal static VirtualScsiController DeserializeVirtualScsiController(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ScsiControllerType> type = default;
            Optional<int> controllerKey = default;
            Optional<int> busNumber = default;
            Optional<int> scsiCtlrUnitNumber = default;
            Optional<VirtualScsiSharing> sharing = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ScsiControllerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controllerKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controllerKey = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("busNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    busNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scsiCtlrUnitNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scsiCtlrUnitNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sharing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharing = new VirtualScsiSharing(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualScsiController(Optional.ToNullable(type), Optional.ToNullable(controllerKey), Optional.ToNullable(busNumber), Optional.ToNullable(scsiCtlrUnitNumber), Optional.ToNullable(sharing));
        }
    }
}