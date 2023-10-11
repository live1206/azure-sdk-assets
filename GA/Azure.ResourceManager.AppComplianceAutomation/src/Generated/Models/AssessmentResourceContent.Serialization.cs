// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class AssessmentResourceContent
    {
        internal static AssessmentResourceContent DeserializeAssessmentResourceContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceId = default;
            Optional<ResourceStatus> resourceStatus = default;
            Optional<string> reason = default;
            Optional<string> statusChangeDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceStatus = new ResourceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusChangeDate"u8))
                {
                    statusChangeDate = property.Value.GetString();
                    continue;
                }
            }
            return new AssessmentResourceContent(resourceId.Value, Optional.ToNullable(resourceStatus), reason.Value, statusChangeDate.Value);
        }
    }
}