// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class WorkloadNetworkSegmentPortVif
    {
        internal static WorkloadNetworkSegmentPortVif DeserializeWorkloadNetworkSegmentPortVif(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> portName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("portName"u8))
                {
                    portName = property.Value.GetString();
                    continue;
                }
            }
            return new WorkloadNetworkSegmentPortVif(portName.Value);
        }
    }
}