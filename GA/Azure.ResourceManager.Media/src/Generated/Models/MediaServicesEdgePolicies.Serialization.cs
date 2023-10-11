// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaServicesEdgePolicies
    {
        internal static MediaServicesEdgePolicies DeserializeMediaServicesEdgePolicies(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeUsageDataCollectionPolicy> usageDataCollectionPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usageDataCollectionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usageDataCollectionPolicy = EdgeUsageDataCollectionPolicy.DeserializeEdgeUsageDataCollectionPolicy(property.Value);
                    continue;
                }
            }
            return new MediaServicesEdgePolicies(usageDataCollectionPolicy.Value);
        }
    }
}