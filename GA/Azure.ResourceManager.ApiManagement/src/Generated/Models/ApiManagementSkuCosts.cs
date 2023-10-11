// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes metadata for retrieving price info. </summary>
    public partial class ApiManagementSkuCosts
    {
        /// <summary> Initializes a new instance of ApiManagementSkuCosts. </summary>
        internal ApiManagementSkuCosts()
        {
        }

        /// <summary> Initializes a new instance of ApiManagementSkuCosts. </summary>
        /// <param name="meterId"> Used for querying price from commerce. </param>
        /// <param name="quantity"> The multiplier is needed to extend the base metered cost. </param>
        /// <param name="extendedUnit"> An invariant to show the extended unit. </param>
        internal ApiManagementSkuCosts(string meterId, long? quantity, string extendedUnit)
        {
            MeterId = meterId;
            Quantity = quantity;
            ExtendedUnit = extendedUnit;
        }

        /// <summary> Used for querying price from commerce. </summary>
        public string MeterId { get; }
        /// <summary> The multiplier is needed to extend the base metered cost. </summary>
        public long? Quantity { get; }
        /// <summary> An invariant to show the extended unit. </summary>
        public string ExtendedUnit { get; }
    }
}