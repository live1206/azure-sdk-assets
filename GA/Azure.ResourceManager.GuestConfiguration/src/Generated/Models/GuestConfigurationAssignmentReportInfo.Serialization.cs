// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentReportInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Assignment))
            {
                writer.WritePropertyName("assignment"u8);
                writer.WriteObjectValue(Assignment);
            }
            if (Optional.IsDefined(Vm))
            {
                writer.WritePropertyName("vm"u8);
                writer.WriteObjectValue(Vm);
            }
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static GuestConfigurationAssignmentReportInfo DeserializeGuestConfigurationAssignmentReportInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<Guid> reportId = default;
            Optional<GuestConfigurationAssignmentInfo> assignment = default;
            Optional<GuestConfigurationVmInfo> vm = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<AssignedGuestConfigurationMachineComplianceStatus> complianceStatus = default;
            Optional<GuestConfigurationAssignmentReportType> operationType = default;
            Optional<IList<AssignmentReportResourceInfo>> resources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new GuestConfigurationAssignmentReportType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssignmentReportResourceInfo> array = new List<AssignmentReportResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentReportResourceInfo.DeserializeAssignmentReportResourceInfo(item));
                    }
                    resources = array;
                    continue;
                }
            }
            return new GuestConfigurationAssignmentReportInfo(id.Value, Optional.ToNullable(reportId), assignment.Value, vm.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(complianceStatus), Optional.ToNullable(operationType), Optional.ToList(resources));
        }
    }
}
