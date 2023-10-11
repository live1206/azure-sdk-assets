// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuCost. </summary>
    public partial class ResourceTypeSkuCost
    {
        /// <summary> Initializes a new instance of ResourceTypeSkuCost. </summary>
        /// <param name="meterId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="meterId"/> is null. </exception>
        public ResourceTypeSkuCost(string meterId)
        {
            Argument.AssertNotNull(meterId, nameof(meterId));

            MeterId = meterId;
        }

        /// <summary> Initializes a new instance of ResourceTypeSkuCost. </summary>
        /// <param name="meterId"></param>
        /// <param name="quantity"></param>
        /// <param name="extendedUnit"></param>
        internal ResourceTypeSkuCost(string meterId, int? quantity, string extendedUnit)
        {
            MeterId = meterId;
            Quantity = quantity;
            ExtendedUnit = extendedUnit;
        }

        /// <summary> Gets or sets the meter id. </summary>
        public string MeterId { get; set; }
        /// <summary> Gets or sets the quantity. </summary>
        public int? Quantity { get; set; }
        /// <summary> Gets or sets the extended unit. </summary>
        public string ExtendedUnit { get; set; }
    }
}