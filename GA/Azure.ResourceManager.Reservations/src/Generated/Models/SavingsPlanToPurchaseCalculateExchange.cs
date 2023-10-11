// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Savings plan purchase details. </summary>
    public partial class SavingsPlanToPurchaseCalculateExchange
    {
        /// <summary> Initializes a new instance of SavingsPlanToPurchaseCalculateExchange. </summary>
        internal SavingsPlanToPurchaseCalculateExchange()
        {
        }

        /// <summary> Initializes a new instance of SavingsPlanToPurchaseCalculateExchange. </summary>
        /// <param name="properties"> Request body for savings plan purchase. </param>
        /// <param name="billingCurrencyTotal"> Pricing information containing the amount and the currency code. </param>
        internal SavingsPlanToPurchaseCalculateExchange(SavingsPlanPurchase properties, PurchasePrice billingCurrencyTotal)
        {
            Properties = properties;
            BillingCurrencyTotal = billingCurrencyTotal;
        }

        /// <summary> Request body for savings plan purchase. </summary>
        public SavingsPlanPurchase Properties { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice BillingCurrencyTotal { get; }
    }
}