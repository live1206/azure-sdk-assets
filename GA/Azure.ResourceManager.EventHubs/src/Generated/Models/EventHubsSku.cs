// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> SKU parameters supplied to the create namespace operation. </summary>
    public partial class EventHubsSku
    {
        /// <summary> Initializes a new instance of EventHubsSku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        public EventHubsSku(EventHubsSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of EventHubsSku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        /// <param name="tier"> The billing tier of this particular SKU. </param>
        /// <param name="capacity"> The Event Hubs throughput units for Basic or Standard tiers, where value should be 0 to 20 throughput units. The Event Hubs premium units for Premium tier, where value should be 0 to 10 premium units. </param>
        internal EventHubsSku(EventHubsSkuName name, EventHubsSkuTier? tier, int? capacity)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary> Name of this SKU. </summary>
        public EventHubsSkuName Name { get; set; }
        /// <summary> The billing tier of this particular SKU. </summary>
        public EventHubsSkuTier? Tier { get; set; }
        /// <summary> The Event Hubs throughput units for Basic or Standard tiers, where value should be 0 to 20 throughput units. The Event Hubs premium units for Premium tier, where value should be 0 to 10 premium units. </summary>
        public int? Capacity { get; set; }
    }
}