// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The RenewProperties. </summary>
    internal partial class RenewProperties
    {
        /// <summary> Initializes a new instance of RenewProperties. </summary>
        public RenewProperties()
        {
        }

        /// <summary> Initializes a new instance of RenewProperties. </summary>
        /// <param name="purchaseProperties"></param>
        internal RenewProperties(BillingBenefitsPurchaseContent purchaseProperties)
        {
            PurchaseProperties = purchaseProperties;
        }

        /// <summary> Gets or sets the purchase properties. </summary>
        public BillingBenefitsPurchaseContent PurchaseProperties { get; set; }
    }
}