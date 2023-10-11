// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SingleServerRecommendationResult
    {
        internal static SingleServerRecommendationResult DeserializeSingleServerRecommendationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmSku = default;
            SapDeploymentType deploymentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSku"u8))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
            }
            return new SingleServerRecommendationResult(deploymentType, vmSku.Value);
        }
    }
}