// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class ShareAccessRight
    {
        internal static ShareAccessRight DeserializeShareAccessRight(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier shareId = default;
            ShareAccessType accessType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareId"u8))
                {
                    shareId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessType"u8))
                {
                    accessType = new ShareAccessType(property.Value.GetString());
                    continue;
                }
            }
            return new ShareAccessRight(shareId, accessType);
        }
    }
}