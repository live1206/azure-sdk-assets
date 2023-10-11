// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmEventDetails
    {
        internal static InMageRcmEventDetails DeserializeInMageRcmEventDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> protectedItemName = default;
            Optional<string> vmName = default;
            Optional<string> latestAgentVersion = default;
            Optional<ResourceIdentifier> jobId = default;
            Optional<string> fabricName = default;
            Optional<string> applianceName = default;
            Optional<string> serverType = default;
            Optional<string> componentDisplayName = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmName"u8))
                {
                    vmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestAgentVersion"u8))
                {
                    latestAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applianceName"u8))
                {
                    applianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverType"u8))
                {
                    serverType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentDisplayName"u8))
                {
                    componentDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new InMageRcmEventDetails(instanceType, protectedItemName.Value, vmName.Value, latestAgentVersion.Value, jobId.Value, fabricName.Value, applianceName.Value, serverType.Value, componentDisplayName.Value);
        }
    }
}