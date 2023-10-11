// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> A lot summary resource. </summary>
    public partial class ConsumptionLotSummary : ResourceData
    {
        /// <summary> Initializes a new instance of ConsumptionLotSummary. </summary>
        public ConsumptionLotSummary()
        {
        }

        /// <summary> Initializes a new instance of ConsumptionLotSummary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="originalAmount"> The original amount of a lot. </param>
        /// <param name="closedBalance"> The balance as of the last invoice. </param>
        /// <param name="source"> The source of the lot. </param>
        /// <param name="startOn"> The date when the lot became effective. </param>
        /// <param name="expireOn"> The expiration date of a lot. </param>
        /// <param name="poNumber"> The po number of the invoice on which the lot was added. This property is not available for ConsumptionCommitment lots. </param>
        /// <param name="purchasedOn"> The date when the lot was added. </param>
        /// <param name="status"> The status of the lot. </param>
        /// <param name="creditCurrency"> The currency of the lot. </param>
        /// <param name="billingCurrency"> The billing currency of the lot. </param>
        /// <param name="originalAmountInBillingCurrency"> The original amount of a lot in billing currency. </param>
        /// <param name="closedBalanceInBillingCurrency"> The balance as of the last invoice in billing currency. </param>
        /// <param name="reseller"> The reseller of the lot. </param>
        /// <param name="etag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        internal ConsumptionLotSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ConsumptionAmount originalAmount, ConsumptionAmount closedBalance, ConsumptionLotSource? source, DateTimeOffset? startOn, DateTimeOffset? expireOn, string poNumber, DateTimeOffset? purchasedOn, ConsumptionLotStatus? status, string creditCurrency, string billingCurrency, ConsumptionAmountWithExchangeRate originalAmountInBillingCurrency, ConsumptionAmountWithExchangeRate closedBalanceInBillingCurrency, ConsumptionReseller reseller, ETag? etag) : base(id, name, resourceType, systemData)
        {
            OriginalAmount = originalAmount;
            ClosedBalance = closedBalance;
            Source = source;
            StartOn = startOn;
            ExpireOn = expireOn;
            PoNumber = poNumber;
            PurchasedOn = purchasedOn;
            Status = status;
            CreditCurrency = creditCurrency;
            BillingCurrency = billingCurrency;
            OriginalAmountInBillingCurrency = originalAmountInBillingCurrency;
            ClosedBalanceInBillingCurrency = closedBalanceInBillingCurrency;
            Reseller = reseller;
            ETag = etag;
        }

        /// <summary> The original amount of a lot. </summary>
        public ConsumptionAmount OriginalAmount { get; }
        /// <summary> The balance as of the last invoice. </summary>
        public ConsumptionAmount ClosedBalance { get; }
        /// <summary> The source of the lot. </summary>
        public ConsumptionLotSource? Source { get; }
        /// <summary> The date when the lot became effective. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The expiration date of a lot. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> The po number of the invoice on which the lot was added. This property is not available for ConsumptionCommitment lots. </summary>
        public string PoNumber { get; }
        /// <summary> The date when the lot was added. </summary>
        public DateTimeOffset? PurchasedOn { get; }
        /// <summary> The status of the lot. </summary>
        public ConsumptionLotStatus? Status { get; }
        /// <summary> The currency of the lot. </summary>
        public string CreditCurrency { get; }
        /// <summary> The billing currency of the lot. </summary>
        public string BillingCurrency { get; }
        /// <summary> The original amount of a lot in billing currency. </summary>
        public ConsumptionAmountWithExchangeRate OriginalAmountInBillingCurrency { get; }
        /// <summary> The balance as of the last invoice in billing currency. </summary>
        public ConsumptionAmountWithExchangeRate ClosedBalanceInBillingCurrency { get; }
        /// <summary> The reseller of the lot. </summary>
        public ConsumptionReseller Reseller { get; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}