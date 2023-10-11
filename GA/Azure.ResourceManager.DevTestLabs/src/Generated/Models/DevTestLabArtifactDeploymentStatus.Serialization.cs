// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabArtifactDeploymentStatus
    {
        internal static DevTestLabArtifactDeploymentStatus DeserializeDevTestLabArtifactDeploymentStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deploymentStatus = default;
            Optional<int> artifactsApplied = default;
            Optional<int> totalArtifacts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentStatus"u8))
                {
                    deploymentStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactsApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactsApplied = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalArtifacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalArtifacts = property.Value.GetInt32();
                    continue;
                }
            }
            return new DevTestLabArtifactDeploymentStatus(deploymentStatus.Value, Optional.ToNullable(artifactsApplied), Optional.ToNullable(totalArtifacts));
        }
    }
}
