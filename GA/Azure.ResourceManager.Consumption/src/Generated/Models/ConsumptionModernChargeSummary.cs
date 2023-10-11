// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Modern charge summary. </summary>
    public partial class ConsumptionModernChargeSummary : ConsumptionChargeSummary
    {
        /// <summary> Initializes a new instance of ConsumptionModernChargeSummary. </summary>
        public ConsumptionModernChargeSummary()
        {
            Kind = ChargeSummaryKind.Modern;
        }

        /// <summary> Initializes a new instance of ConsumptionModernChargeSummary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of charge summary. </param>
        /// <param name="etag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        /// <param name="billingPeriodId"> The id of the billing period resource that the charge belongs to. </param>
        /// <param name="usageStart"> Usage start date. </param>
        /// <param name="usageEnd"> Usage end date. </param>
        /// <param name="azureCharges"> Azure Charges. </param>
        /// <param name="chargesBilledSeparately"> Charges Billed separately. </param>
        /// <param name="marketplaceCharges"> Marketplace Charges. </param>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="billingProfileId"> Billing Profile Id. </param>
        /// <param name="invoiceSectionId"> Invoice Section Id. </param>
        /// <param name="customerId"> Customer Id. </param>
        /// <param name="isInvoiced"> Is charge Invoiced. </param>
        internal ConsumptionModernChargeSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ChargeSummaryKind kind, ETag? etag, string billingPeriodId, string usageStart, string usageEnd, ConsumptionAmount azureCharges, ConsumptionAmount chargesBilledSeparately, ConsumptionAmount marketplaceCharges, string billingAccountId, string billingProfileId, string invoiceSectionId, string customerId, bool? isInvoiced) : base(id, name, resourceType, systemData, kind, etag)
        {
            BillingPeriodId = billingPeriodId;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            AzureCharges = azureCharges;
            ChargesBilledSeparately = chargesBilledSeparately;
            MarketplaceCharges = marketplaceCharges;
            BillingAccountId = billingAccountId;
            BillingProfileId = billingProfileId;
            InvoiceSectionId = invoiceSectionId;
            CustomerId = customerId;
            IsInvoiced = isInvoiced;
            Kind = kind;
        }

        /// <summary> The id of the billing period resource that the charge belongs to. </summary>
        public string BillingPeriodId { get; }
        /// <summary> Usage start date. </summary>
        public string UsageStart { get; }
        /// <summary> Usage end date. </summary>
        public string UsageEnd { get; }
        /// <summary> Azure Charges. </summary>
        public ConsumptionAmount AzureCharges { get; }
        /// <summary> Charges Billed separately. </summary>
        public ConsumptionAmount ChargesBilledSeparately { get; }
        /// <summary> Marketplace Charges. </summary>
        public ConsumptionAmount MarketplaceCharges { get; }
        /// <summary> Billing Account Id. </summary>
        public string BillingAccountId { get; }
        /// <summary> Billing Profile Id. </summary>
        public string BillingProfileId { get; }
        /// <summary> Invoice Section Id. </summary>
        public string InvoiceSectionId { get; }
        /// <summary> Customer Id. </summary>
        public string CustomerId { get; }
        /// <summary> Is charge Invoiced. </summary>
        public bool? IsInvoiced { get; }
    }
}