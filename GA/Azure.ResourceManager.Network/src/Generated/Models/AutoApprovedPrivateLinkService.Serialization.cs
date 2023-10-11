// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AutoApprovedPrivateLinkService
    {
        internal static AutoApprovedPrivateLinkService DeserializeAutoApprovedPrivateLinkService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> privateLinkService = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLinkService"u8))
                {
                    privateLinkService = property.Value.GetString();
                    continue;
                }
            }
            return new AutoApprovedPrivateLinkService(privateLinkService.Value);
        }
    }
}