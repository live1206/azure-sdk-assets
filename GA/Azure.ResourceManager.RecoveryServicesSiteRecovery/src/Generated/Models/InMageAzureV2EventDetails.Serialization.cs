// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2EventDetails
    {
        internal static InMageAzureV2EventDetails DeserializeInMageAzureV2EventDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> eventType = default;
            Optional<string> category = default;
            Optional<string> component = default;
            Optional<string> correctiveAction = default;
            Optional<string> details = default;
            Optional<string> summary = default;
            Optional<string> siteName = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    component = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correctiveAction"u8))
                {
                    correctiveAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new InMageAzureV2EventDetails(instanceType, eventType.Value, category.Value, component.Value, correctiveAction.Value, details.Value, summary.Value, siteName.Value);
        }
    }
}