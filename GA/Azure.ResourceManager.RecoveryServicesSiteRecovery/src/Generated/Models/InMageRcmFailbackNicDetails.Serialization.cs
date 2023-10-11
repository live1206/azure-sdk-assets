// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackNicDetails
    {
        internal static InMageRcmFailbackNicDetails DeserializeInMageRcmFailbackNicDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> macAddress = default;
            Optional<string> networkName = default;
            Optional<string> adapterType = default;
            Optional<IPAddress> sourceIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adapterType"u8))
                {
                    adapterType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
            }
            return new InMageRcmFailbackNicDetails(macAddress.Value, networkName.Value, adapterType.Value, sourceIPAddress.Value);
        }
    }
}