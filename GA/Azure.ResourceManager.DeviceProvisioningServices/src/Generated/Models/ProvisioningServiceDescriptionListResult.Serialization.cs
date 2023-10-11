// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    internal partial class ProvisioningServiceDescriptionListResult
    {
        internal static ProvisioningServiceDescriptionListResult DeserializeProvisioningServiceDescriptionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DeviceProvisioningServiceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServiceData> array = new List<DeviceProvisioningServiceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServiceData.DeserializeDeviceProvisioningServiceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ProvisioningServiceDescriptionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}