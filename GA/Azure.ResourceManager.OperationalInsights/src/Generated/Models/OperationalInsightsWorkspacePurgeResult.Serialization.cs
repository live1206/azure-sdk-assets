// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspacePurgeResult
    {
        internal static OperationalInsightsWorkspacePurgeResult DeserializeOperationalInsightsWorkspacePurgeResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid operationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetGuid();
                    continue;
                }
            }
            return new OperationalInsightsWorkspacePurgeResult(operationId);
        }
    }
}