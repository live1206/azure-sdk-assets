// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackReplicationDetails
    {
        internal static InMageRcmFailbackReplicationDetails DeserializeInMageRcmFailbackReplicationDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> internalIdentifier = default;
            Optional<ResourceIdentifier> azureVirtualMachineId = default;
            Optional<string> multiVmGroupName = default;
            Optional<string> reprotectAgentId = default;
            Optional<string> reprotectAgentName = default;
            Optional<string> osType = default;
            Optional<ResourceIdentifier> logStorageAccountId = default;
            Optional<string> targetvCenterId = default;
            Optional<string> targetDataStoreName = default;
            Optional<string> targetVmName = default;
            Optional<int> initialReplicationProgressPercentage = default;
            Optional<long> initialReplicationProcessedBytes = default;
            Optional<long> initialReplicationTransferredBytes = default;
            Optional<VmReplicationProgressHealth> initialReplicationProgressHealth = default;
            Optional<int> resyncProgressPercentage = default;
            Optional<long> resyncProcessedBytes = default;
            Optional<long> resyncTransferredBytes = default;
            Optional<VmReplicationProgressHealth> resyncProgressHealth = default;
            Optional<string> resyncRequired = default;
            Optional<SiteRecoveryResyncState> resyncState = default;
            Optional<IReadOnlyList<InMageRcmFailbackProtectedDiskDetails>> protectedDisks = default;
            Optional<InMageRcmFailbackMobilityAgentDetails> mobilityAgentDetails = default;
            Optional<IReadOnlyList<InMageRcmFailbackNicDetails>> vmNics = default;
            Optional<DateTimeOffset> lastPlannedFailoverStartTime = default;
            Optional<PlannedFailoverStatus> lastPlannedFailoverStatus = default;
            Optional<InMageRcmFailbackDiscoveredProtectedVmDetails> discoveredVmDetails = default;
            Optional<ResourceIdentifier> lastUsedPolicyId = default;
            Optional<string> lastUsedPolicyFriendlyName = default;
            Optional<bool> isAgentRegistrationSuccessfulAfterFailover = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("internalIdentifier"u8))
                {
                    internalIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reprotectAgentId"u8))
                {
                    reprotectAgentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reprotectAgentName"u8))
                {
                    reprotectAgentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetvCenterId"u8))
                {
                    targetvCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDataStoreName"u8))
                {
                    targetDataStoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialReplicationProcessedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initialReplicationTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProgressHealth = new VmReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncProcessedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncProgressHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressHealth = new VmReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    resyncRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncState = new SiteRecoveryResyncState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmFailbackProtectedDiskDetails> array = new List<InMageRcmFailbackProtectedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmFailbackProtectedDiskDetails.DeserializeInMageRcmFailbackProtectedDiskDetails(item));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("mobilityAgentDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mobilityAgentDetails = InMageRcmFailbackMobilityAgentDetails.DeserializeInMageRcmFailbackMobilityAgentDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmFailbackNicDetails> array = new List<InMageRcmFailbackNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmFailbackNicDetails.DeserializeInMageRcmFailbackNicDetails(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastPlannedFailoverStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastPlannedFailoverStatus = new PlannedFailoverStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("discoveredVmDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    discoveredVmDetails = InMageRcmFailbackDiscoveredProtectedVmDetails.DeserializeInMageRcmFailbackDiscoveredProtectedVmDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUsedPolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUsedPolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastUsedPolicyFriendlyName"u8))
                {
                    lastUsedPolicyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAgentRegistrationSuccessfulAfterFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAgentRegistrationSuccessfulAfterFailover = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new InMageRcmFailbackReplicationDetails(instanceType, internalIdentifier.Value, azureVirtualMachineId.Value, multiVmGroupName.Value, reprotectAgentId.Value, reprotectAgentName.Value, osType.Value, logStorageAccountId.Value, targetvCenterId.Value, targetDataStoreName.Value, targetVmName.Value, Optional.ToNullable(initialReplicationProgressPercentage), Optional.ToNullable(initialReplicationProcessedBytes), Optional.ToNullable(initialReplicationTransferredBytes), Optional.ToNullable(initialReplicationProgressHealth), Optional.ToNullable(resyncProgressPercentage), Optional.ToNullable(resyncProcessedBytes), Optional.ToNullable(resyncTransferredBytes), Optional.ToNullable(resyncProgressHealth), resyncRequired.Value, Optional.ToNullable(resyncState), Optional.ToList(protectedDisks), mobilityAgentDetails.Value, Optional.ToList(vmNics), Optional.ToNullable(lastPlannedFailoverStartTime), Optional.ToNullable(lastPlannedFailoverStatus), discoveredVmDetails.Value, lastUsedPolicyId.Value, lastUsedPolicyFriendlyName.Value, Optional.ToNullable(isAgentRegistrationSuccessfulAfterFailover));
        }
    }
}