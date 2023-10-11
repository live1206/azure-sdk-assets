// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Commitment towards the benefit. </summary>
    public partial class BenefitsCommitment : PurchasePrice
    {
        /// <summary> Initializes a new instance of BenefitsCommitment. </summary>
        public BenefitsCommitment()
        {
        }

        /// <summary> Initializes a new instance of BenefitsCommitment. </summary>
        /// <param name="currencyCode"> The ISO 4217 3-letter currency code for the currency used by this purchase record. </param>
        /// <param name="amount"></param>
        /// <param name="grain"> Commitment grain. </param>
        internal BenefitsCommitment(string currencyCode, double? amount, BenefitsCommitmentGrain? grain) : base(currencyCode, amount)
        {
            Grain = grain;
        }

        /// <summary> Commitment grain. </summary>
        public BenefitsCommitmentGrain? Grain { get; set; }
    }
}