// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class RegionConfigurationResult
    {
        internal static RegionConfigurationResult DeserializeRegionConfigurationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ScheduleAvailabilityResponse> scheduleAvailabilityResponse = default;
            Optional<TransportAvailabilityResponse> transportAvailabilityResponse = default;
            Optional<DataCenterAddressResult> dataCenterAddressResponse = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleAvailabilityResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleAvailabilityResponse = ScheduleAvailabilityResponse.DeserializeScheduleAvailabilityResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("transportAvailabilityResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportAvailabilityResponse = TransportAvailabilityResponse.DeserializeTransportAvailabilityResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("datacenterAddressResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddressResponse = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value);
                    continue;
                }
            }
            return new RegionConfigurationResult(scheduleAvailabilityResponse.Value, transportAvailabilityResponse.Value, dataCenterAddressResponse.Value);
        }
    }
}