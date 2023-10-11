// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsPrivateCloudEndpoints
    {
        internal static AvsPrivateCloudEndpoints DeserializeAvsPrivateCloudEndpoints(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nsxtManager = default;
            Optional<string> vcsa = default;
            Optional<string> hcxCloudManager = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nsxtManager"u8))
                {
                    nsxtManager = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vcsa"u8))
                {
                    vcsa = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hcxCloudManager"u8))
                {
                    hcxCloudManager = property.Value.GetString();
                    continue;
                }
            }
            return new AvsPrivateCloudEndpoints(nsxtManager.Value, vcsa.Value, hcxCloudManager.Value);
        }
    }
}