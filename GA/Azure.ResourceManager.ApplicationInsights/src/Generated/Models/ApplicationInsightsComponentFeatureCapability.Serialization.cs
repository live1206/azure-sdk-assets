// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentFeatureCapability
    {
        internal static ApplicationInsightsComponentFeatureCapability DeserializeApplicationInsightsComponentFeatureCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> value = default;
            Optional<string> unit = default;
            Optional<string> meterId = default;
            Optional<string> meterRateFrequency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MeterId"u8))
                {
                    meterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MeterRateFrequency"u8))
                {
                    meterRateFrequency = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationInsightsComponentFeatureCapability(name.Value, description.Value, value.Value, unit.Value, meterId.Value, meterRateFrequency.Value);
        }
    }
}