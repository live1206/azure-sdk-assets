// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersAwsOffering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefenderForServers))
            {
                writer.WritePropertyName("defenderForServers"u8);
                writer.WriteObjectValue(DefenderForServers);
            }
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                writer.WriteObjectValue(ArcAutoProvisioning);
            }
            if (Optional.IsDefined(VaAutoProvisioning))
            {
                writer.WritePropertyName("vaAutoProvisioning"u8);
                writer.WriteObjectValue(VaAutoProvisioning);
            }
            if (Optional.IsDefined(MdeAutoProvisioning))
            {
                writer.WritePropertyName("mdeAutoProvisioning"u8);
                writer.WriteObjectValue(MdeAutoProvisioning);
            }
            if (Optional.IsDefined(SubPlan))
            {
                writer.WritePropertyName("subPlan"u8);
                writer.WriteObjectValue(SubPlan);
            }
            if (Optional.IsDefined(VmScanners))
            {
                writer.WritePropertyName("vmScanners"u8);
                writer.WriteObjectValue(VmScanners);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            writer.WriteEndObject();
        }

        internal static DefenderForServersAwsOffering DeserializeDefenderForServersAwsOffering(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AwsDefenderForServersInfo> defenderForServers = default;
            Optional<DefenderForServersAwsOfferingArcAutoProvisioning> arcAutoProvisioning = default;
            Optional<DefenderForServersAwsOfferingVulnerabilityAssessmentAutoProvisioning> vaAutoProvisioning = default;
            Optional<DefenderForServersAwsOfferingMdeAutoProvisioning> mdeAutoProvisioning = default;
            Optional<DefenderForServersAwsOfferingSubPlan> subPlan = default;
            Optional<DefenderForServersAwsOfferingVmScanners> vmScanners = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defenderForServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defenderForServers = AwsDefenderForServersInfo.DeserializeAwsDefenderForServersInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForServersAwsOfferingArcAutoProvisioning.DeserializeDefenderForServersAwsOfferingArcAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("vaAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaAutoProvisioning = DefenderForServersAwsOfferingVulnerabilityAssessmentAutoProvisioning.DeserializeDefenderForServersAwsOfferingVulnerabilityAssessmentAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("mdeAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdeAutoProvisioning = DefenderForServersAwsOfferingMdeAutoProvisioning.DeserializeDefenderForServersAwsOfferingMdeAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("subPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subPlan = DefenderForServersAwsOfferingSubPlan.DeserializeDefenderForServersAwsOfferingSubPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("vmScanners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmScanners = DefenderForServersAwsOfferingVmScanners.DeserializeDefenderForServersAwsOfferingVmScanners(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderForServersAwsOffering(offeringType, description.Value, defenderForServers.Value, arcAutoProvisioning.Value, vaAutoProvisioning.Value, mdeAutoProvisioning.Value, subPlan.Value, vmScanners.Value);
        }
    }
}