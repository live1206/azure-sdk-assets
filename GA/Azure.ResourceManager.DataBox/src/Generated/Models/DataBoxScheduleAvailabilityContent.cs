// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the availability for scheduling data box orders orders. </summary>
    public partial class DataBoxScheduleAvailabilityContent : ScheduleAvailabilityContent
    {
        /// <summary> Initializes a new instance of DataBoxScheduleAvailabilityContent. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        public DataBoxScheduleAvailabilityContent(AzureLocation storageLocation) : base(storageLocation)
        {
            SkuName = DataBoxSkuName.DataBox;
        }
    }
}