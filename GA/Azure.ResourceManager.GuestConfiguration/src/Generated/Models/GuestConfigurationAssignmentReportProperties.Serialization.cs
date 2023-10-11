// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentReportProperties
    {
        internal static GuestConfigurationAssignmentReportProperties DeserializeGuestConfigurationAssignmentReportProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AssignedGuestConfigurationMachineComplianceStatus> complianceStatus = default;
            Optional<Guid> reportId = default;
            Optional<GuestConfigurationAssignmentInfo> assignment = default;
            Optional<GuestConfigurationVmInfo> vm = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<GuestConfigurationAssignmentReportDetails> details = default;
            Optional<string> vmssResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("assignment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignment = GuestConfigurationAssignmentInfo.DeserializeGuestConfigurationAssignmentInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("vm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vm = GuestConfigurationVmInfo.DeserializeGuestConfigurationVmInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        details = null;
                        continue;
                    }
                    details = GuestConfigurationAssignmentReportDetails.DeserializeGuestConfigurationAssignmentReportDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vmssResourceId"u8))
                {
                    vmssResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new GuestConfigurationAssignmentReportProperties(Optional.ToNullable(complianceStatus), Optional.ToNullable(reportId), assignment.Value, vm.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), details.Value, vmssResourceId.Value);
        }
    }
}
