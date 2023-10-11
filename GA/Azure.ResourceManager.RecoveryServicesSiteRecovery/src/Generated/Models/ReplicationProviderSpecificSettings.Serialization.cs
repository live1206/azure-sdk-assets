// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReplicationProviderSpecificSettings
    {
        internal static ReplicationProviderSpecificSettings DeserializeReplicationProviderSpecificSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AReplicationDetails.DeserializeA2AReplicationDetails(element);
                    case "A2ACrossClusterMigration": return A2ACrossClusterMigrationReplicationDetails.DeserializeA2ACrossClusterMigrationReplicationDetails(element);
                    case "HyperVReplica2012": return HyperVReplicaReplicationDetails.DeserializeHyperVReplicaReplicationDetails(element);
                    case "HyperVReplica2012R2": return HyperVReplicaBlueReplicationDetails.DeserializeHyperVReplicaBlueReplicationDetails(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureReplicationDetails.DeserializeHyperVReplicaAzureReplicationDetails(element);
                    case "HyperVReplicaBaseReplicationDetails": return HyperVReplicaBaseReplicationDetails.DeserializeHyperVReplicaBaseReplicationDetails(element);
                    case "InMage": return InMageReplicationDetails.DeserializeInMageReplicationDetails(element);
                    case "InMageAzureV2": return InMageAzureV2ReplicationDetails.DeserializeInMageAzureV2ReplicationDetails(element);
                    case "InMageRcm": return InMageRcmReplicationDetails.DeserializeInMageRcmReplicationDetails(element);
                    case "InMageRcmFailback": return InMageRcmFailbackReplicationDetails.DeserializeInMageRcmFailbackReplicationDetails(element);
                }
            }
            return UnknownReplicationProviderSpecificSettings.DeserializeUnknownReplicationProviderSpecificSettings(element);
        }
    }
}