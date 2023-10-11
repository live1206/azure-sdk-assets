// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal partial class NetworkSecurityPerimeterConfigurationList
    {
        internal static NetworkSecurityPerimeterConfigurationList DeserializeNetworkSecurityPerimeterConfigurationList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EventHubsNetworkSecurityPerimeterConfiguration>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsNetworkSecurityPerimeterConfiguration> array = new List<EventHubsNetworkSecurityPerimeterConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsNetworkSecurityPerimeterConfiguration.DeserializeEventHubsNetworkSecurityPerimeterConfiguration(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new NetworkSecurityPerimeterConfigurationList(Optional.ToList(value));
        }
    }
}