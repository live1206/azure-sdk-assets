// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class KeySetUserStatus
    {
        internal static KeySetUserStatus DeserializeKeySetUserStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> azureUserName = default;
            Optional<BareMetalMachineKeySetUserSetupStatus> status = default;
            Optional<string> statusMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureUserName"u8))
                {
                    azureUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new BareMetalMachineKeySetUserSetupStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
            }
            return new KeySetUserStatus(azureUserName.Value, Optional.ToNullable(status), statusMessage.Value);
        }
    }
}