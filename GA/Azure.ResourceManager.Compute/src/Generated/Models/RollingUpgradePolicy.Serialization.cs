// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RollingUpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxBatchInstancePercent))
            {
                writer.WritePropertyName("maxBatchInstancePercent"u8);
                writer.WriteNumberValue(MaxBatchInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyUpgradedInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyUpgradedInstancePercent"u8);
                writer.WriteNumberValue(MaxUnhealthyUpgradedInstancePercent.Value);
            }
            if (Optional.IsDefined(PauseTimeBetweenBatches))
            {
                writer.WritePropertyName("pauseTimeBetweenBatches"u8);
                writer.WriteStringValue(PauseTimeBetweenBatches);
            }
            if (Optional.IsDefined(EnableCrossZoneUpgrade))
            {
                writer.WritePropertyName("enableCrossZoneUpgrade"u8);
                writer.WriteBooleanValue(EnableCrossZoneUpgrade.Value);
            }
            if (Optional.IsDefined(PrioritizeUnhealthyInstances))
            {
                writer.WritePropertyName("prioritizeUnhealthyInstances"u8);
                writer.WriteBooleanValue(PrioritizeUnhealthyInstances.Value);
            }
            if (Optional.IsDefined(RollbackFailedInstancesOnPolicyBreach))
            {
                writer.WritePropertyName("rollbackFailedInstancesOnPolicyBreach"u8);
                writer.WriteBooleanValue(RollbackFailedInstancesOnPolicyBreach.Value);
            }
            if (Optional.IsDefined(IsMaxSurgeEnabled))
            {
                writer.WritePropertyName("maxSurge"u8);
                writer.WriteBooleanValue(IsMaxSurgeEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static RollingUpgradePolicy DeserializeRollingUpgradePolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxBatchInstancePercent = default;
            Optional<int> maxUnhealthyInstancePercent = default;
            Optional<int> maxUnhealthyUpgradedInstancePercent = default;
            Optional<string> pauseTimeBetweenBatches = default;
            Optional<bool> enableCrossZoneUpgrade = default;
            Optional<bool> prioritizeUnhealthyInstances = default;
            Optional<bool> rollbackFailedInstancesOnPolicyBreach = default;
            Optional<bool> maxSurge = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxBatchInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBatchInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyUpgradedInstancePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnhealthyUpgradedInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pauseTimeBetweenBatches"u8))
                {
                    pauseTimeBetweenBatches = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableCrossZoneUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCrossZoneUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("prioritizeUnhealthyInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prioritizeUnhealthyInstances = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rollbackFailedInstancesOnPolicyBreach"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollbackFailedInstancesOnPolicyBreach = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxSurge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSurge = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RollingUpgradePolicy(Optional.ToNullable(maxBatchInstancePercent), Optional.ToNullable(maxUnhealthyInstancePercent), Optional.ToNullable(maxUnhealthyUpgradedInstancePercent), pauseTimeBetweenBatches.Value, Optional.ToNullable(enableCrossZoneUpgrade), Optional.ToNullable(prioritizeUnhealthyInstances), Optional.ToNullable(rollbackFailedInstancesOnPolicyBreach), Optional.ToNullable(maxSurge));
        }
    }
}