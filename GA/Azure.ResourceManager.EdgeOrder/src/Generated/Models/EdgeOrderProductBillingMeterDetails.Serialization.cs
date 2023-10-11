// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderProductBillingMeterDetails
    {
        internal static EdgeOrderProductBillingMeterDetails DeserializeEdgeOrderProductBillingMeterDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<EdgeOrderProductMeterDetails> meterDetails = default;
            Optional<EdgeOrderProductMeteringType> meteringType = default;
            Optional<string> frequency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meterDetails = EdgeOrderProductMeterDetails.DeserializeEdgeOrderProductMeterDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("meteringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meteringType = new EdgeOrderProductMeteringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    frequency = property.Value.GetString();
                    continue;
                }
            }
            return new EdgeOrderProductBillingMeterDetails(name.Value, meterDetails.Value, Optional.ToNullable(meteringType), frequency.Value);
        }
    }
}