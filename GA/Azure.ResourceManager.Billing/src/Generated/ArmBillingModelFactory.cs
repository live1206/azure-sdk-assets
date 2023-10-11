// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Billing;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmBillingModelFactory
    {
        /// <summary> Initializes a new instance of BillingSubscriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="autoRenew"> Indicates whether auto renewal is turned on or off for a subscription. </param>
        /// <param name="beneficiaryTenantId"> The provisioning tenant of the subscription. </param>
        /// <param name="billingFrequency"> The billing frequency of the subscription in the ISO8601 format. Example: P1M, P3M, P1Y. </param>
        /// <param name="billingProfileId"> The ID of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="billingPolicies"> Dictionary of billing policies associated with the subscription. </param>
        /// <param name="billingProfileDisplayName"> The display name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="billingProfileName"> The name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="consumptionCostCenter"> The cost center applied to the subscription. This field is only available for consumption subscriptions of Microsoft Customer Agreement Type billing accounts. </param>
        /// <param name="customerId"> The ID of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="customerDisplayName"> The name of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="displayName"> The name of the subscription. </param>
        /// <param name="enrollmentAccountId"> The enrollment Account ID associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="enrollmentAccountDisplayName"> The enrollment Account name associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="invoiceSectionId"> The ID of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="invoiceSectionDisplayName"> The display name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="invoiceSectionName"> The name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="lastMonthCharges"> The last month's charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="monthToDateCharges"> The current month to date charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="nextBillingCycleBillingFrequency"> Next billing cycle details of the subscription. </param>
        /// <param name="offerId"> The offer ID for the subscription. This field is only available for the Microsoft Online Services Program billing accounts. </param>
        /// <param name="productCategory"> The category of the product for which the subscription is purchased. Possible values include: AzureSupport, Hardware, ReservationOrder, SaaS, SavingsPlanOrder, Software, UsageBased, Other. </param>
        /// <param name="productType"> The type of the product for which the subscription is purchased. </param>
        /// <param name="productTypeId"> The ID of the product for which the subscription is purchased. </param>
        /// <param name="purchaseOn"> The purchase date of the subscription in UTC time. </param>
        /// <param name="quantity"> The number of licenses purchased for the subscription. </param>
        /// <param name="reseller"> The reseller for which the subscription is created. The field is available for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="renewalTermDetails"> The term details of the subscription at the next renewal. </param>
        /// <param name="skuDescription"> The SKU description of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="skuId"> The SKU ID of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="status"> The status of the subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="subscriptionId"> The ID of the usage-based subscription. This field is only available for usage-based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="suspensionReasons"> The suspension reason for the subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="termDuration"> The duration for which you can use the subscription. Example P1Y and P1M. </param>
        /// <param name="termStartOn"> The start date of the term in UTC time. </param>
        /// <param name="termEndOn"> The end date of the term in UTC time. </param>
        /// <param name="subscriptionEnrollmentAccountStatus"> The current enrollment account status of the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="enrollmentAccountStartOn"> The enrollment Account and the subscription association start date. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <returns> A new <see cref="Billing.BillingSubscriptionData"/> instance for mocking. </returns>
        public static BillingSubscriptionData BillingSubscriptionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, BillingSubscriptionAutoRenewState? autoRenew = null, string beneficiaryTenantId = null, string billingFrequency = null, ResourceIdentifier billingProfileId = null, IReadOnlyDictionary<string, string> billingPolicies = null, string billingProfileDisplayName = null, string billingProfileName = null, string consumptionCostCenter = null, string customerId = null, string customerDisplayName = null, string displayName = null, string enrollmentAccountId = null, string enrollmentAccountDisplayName = null, ResourceIdentifier invoiceSectionId = null, string invoiceSectionDisplayName = null, string invoiceSectionName = null, BillingAmount lastMonthCharges = null, BillingAmount monthToDateCharges = null, string nextBillingCycleBillingFrequency = null, string offerId = null, string productCategory = null, string productType = null, string productTypeId = null, DateTimeOffset? purchaseOn = null, long? quantity = null, CreatedSubscriptionReseller reseller = null, SubscriptionRenewalTermDetails renewalTermDetails = null, string skuDescription = null, string skuId = null, BillingSubscriptionStatus? status = null, string subscriptionId = null, IEnumerable<string> suspensionReasons = null, TimeSpan? termDuration = null, DateTimeOffset? termStartOn = null, DateTimeOffset? termEndOn = null, SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus = null, DateTimeOffset? enrollmentAccountStartOn = null)
        {
            billingPolicies ??= new Dictionary<string, string>();
            suspensionReasons ??= new List<string>();

            return new BillingSubscriptionData(id, name, resourceType, systemData, autoRenew, beneficiaryTenantId, billingFrequency, billingProfileId, billingPolicies, billingProfileDisplayName, billingProfileName, consumptionCostCenter, customerId, customerDisplayName, displayName, enrollmentAccountId, enrollmentAccountDisplayName, invoiceSectionId, invoiceSectionDisplayName, invoiceSectionName, lastMonthCharges, monthToDateCharges, nextBillingCycleBillingFrequency != null ? new NextBillingCycleDetails(nextBillingCycleBillingFrequency) : null, offerId, productCategory, productType, productTypeId, purchaseOn, quantity, reseller, renewalTermDetails, skuDescription, skuId, status, subscriptionId, suspensionReasons?.ToList(), termDuration, termStartOn, termEndOn, subscriptionEnrollmentAccountStatus, enrollmentAccountStartOn);
        }

        /// <summary> Initializes a new instance of BillingAmount. </summary>
        /// <param name="currency"> The currency for the amount value. </param>
        /// <param name="value"> Amount value. </param>
        /// <returns> A new <see cref="Models.BillingAmount"/> instance for mocking. </returns>
        public static BillingAmount BillingAmount(string currency = null, float? value = null)
        {
            return new BillingAmount(currency, value);
        }

        /// <summary> Initializes a new instance of CreatedSubscriptionReseller. </summary>
        /// <param name="resellerId"> The MPN ID of the reseller. </param>
        /// <param name="description"> The name of the reseller. </param>
        /// <returns> A new <see cref="Models.CreatedSubscriptionReseller"/> instance for mocking. </returns>
        public static CreatedSubscriptionReseller CreatedSubscriptionReseller(string resellerId = null, string description = null)
        {
            return new CreatedSubscriptionReseller(resellerId, description);
        }

        /// <summary> Initializes a new instance of SubscriptionRenewalTermDetails. </summary>
        /// <param name="billingFrequency"> The billing frequency of the subscription. </param>
        /// <param name="productTypeId"> The ID of the product. </param>
        /// <param name="quantity"> The number of licenses. </param>
        /// <param name="skuId"> The SKU ID of the product. </param>
        /// <param name="termDuration"> The term duration of the subscription. Example P1M and P1Y. </param>
        /// <returns> A new <see cref="Models.SubscriptionRenewalTermDetails"/> instance for mocking. </returns>
        public static SubscriptionRenewalTermDetails SubscriptionRenewalTermDetails(string billingFrequency = null, string productTypeId = null, long? quantity = null, string skuId = null, TimeSpan? termDuration = null)
        {
            return new SubscriptionRenewalTermDetails(billingFrequency, productTypeId, quantity, skuId, termDuration);
        }

        /// <summary> Initializes a new instance of BillingSubscriptionValidateMoveEligibilityResult. </summary>
        /// <param name="isMoveEligible"> Specifies whether the subscription is eligible to move. </param>
        /// <param name="errorDetails"> Validation error details. </param>
        /// <returns> A new <see cref="Models.BillingSubscriptionValidateMoveEligibilityResult"/> instance for mocking. </returns>
        public static BillingSubscriptionValidateMoveEligibilityResult BillingSubscriptionValidateMoveEligibilityResult(bool? isMoveEligible = null, BillingSubscriptionValidateMoveEligibilityError errorDetails = null)
        {
            return new BillingSubscriptionValidateMoveEligibilityResult(isMoveEligible, errorDetails);
        }

        /// <summary> Initializes a new instance of BillingSubscriptionValidateMoveEligibilityError. </summary>
        /// <param name="code"> Error code for the billing subscription move validation. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> Detailed error message explaining the error. </param>
        /// <returns> A new <see cref="Models.BillingSubscriptionValidateMoveEligibilityError"/> instance for mocking. </returns>
        public static BillingSubscriptionValidateMoveEligibilityError BillingSubscriptionValidateMoveEligibilityError(SubscriptionTransferValidationErrorCode? code = null, string message = null, string details = null)
        {
            return new BillingSubscriptionValidateMoveEligibilityError(code, message, details);
        }

        /// <summary> Initializes a new instance of BillingSubscriptionAliasData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="autoRenew"> Indicates whether auto renewal is turned on or off for a subscription. </param>
        /// <param name="beneficiaryTenantId"> The provisioning tenant of the subscription. </param>
        /// <param name="billingFrequency"> The billing frequency of the subscription in the ISO8601 format. Example: P1M, P3M, P1Y. </param>
        /// <param name="billingProfileId"> The ID of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="billingPolicies"> Dictionary of billing policies associated with the subscription. </param>
        /// <param name="billingProfileDisplayName"> The display name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="billingProfileName"> The name of the billing profile to which the subscription is billed. This field is only applicable for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="consumptionCostCenter"> The cost center applied to the subscription. This field is only available for consumption subscriptions of Microsoft Customer Agreement Type billing accounts. </param>
        /// <param name="customerId"> The ID of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="customerDisplayName"> The name of the customer for whom the subscription was created. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="displayName"> The name of the subscription. </param>
        /// <param name="enrollmentAccountId"> The enrollment Account ID associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="enrollmentAccountDisplayName"> The enrollment Account name associated with the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="invoiceSectionId"> The ID of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="invoiceSectionDisplayName"> The display name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="invoiceSectionName"> The name of the invoice section to which the subscription is billed. The field is applicable only for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="lastMonthCharges"> The last month's charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="monthToDateCharges"> The current month to date charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="nextBillingCycleBillingFrequency"> Next billing cycle details of the subscription. </param>
        /// <param name="offerId"> The offer ID for the subscription. This field is only available for the Microsoft Online Services Program billing accounts. </param>
        /// <param name="productCategory"> The category of the product for which the subscription is purchased. Possible values include: AzureSupport, Hardware, ReservationOrder, SaaS, SavingsPlanOrder, Software, UsageBased, Other. </param>
        /// <param name="productType"> The type of the product for which the subscription is purchased. </param>
        /// <param name="productTypeId"> The ID of the product for which the subscription is purchased. </param>
        /// <param name="purchaseOn"> The purchase date of the subscription in UTC time. </param>
        /// <param name="quantity"> The number of licenses purchased for the subscription. </param>
        /// <param name="reseller"> The reseller for which the subscription is created. The field is available for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="renewalTermDetails"> The term details of the subscription at the next renewal. </param>
        /// <param name="skuDescription"> The SKU description of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="skuId"> The SKU ID of the product for which the subscription is purchased. This field is only available for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="status"> The status of the subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="subscriptionId"> The ID of the usage-based subscription. This field is only available for usage-based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="suspensionReasons"> The suspension reason for the subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="termDuration"> The duration for which you can use the subscription. Example P1Y and P1M. </param>
        /// <param name="termStartOn"> The start date of the term in UTC time. </param>
        /// <param name="termEndOn"> The end date of the term in UTC time. </param>
        /// <param name="subscriptionEnrollmentAccountStatus"> The current enrollment account status of the subscription. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="enrollmentAccountStartOn"> The enrollment Account and the subscription association start date. This field is available only for the Enterprise Agreement billing accounts. </param>
        /// <param name="billingSubscriptionId"> The ID of the billing subscription with the subscription alias. </param>
        /// <returns> A new <see cref="Billing.BillingSubscriptionAliasData"/> instance for mocking. </returns>
        public static BillingSubscriptionAliasData BillingSubscriptionAliasData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, BillingSubscriptionAutoRenewState? autoRenew = null, string beneficiaryTenantId = null, string billingFrequency = null, ResourceIdentifier billingProfileId = null, IReadOnlyDictionary<string, string> billingPolicies = null, string billingProfileDisplayName = null, string billingProfileName = null, string consumptionCostCenter = null, string customerId = null, string customerDisplayName = null, string displayName = null, string enrollmentAccountId = null, string enrollmentAccountDisplayName = null, ResourceIdentifier invoiceSectionId = null, string invoiceSectionDisplayName = null, string invoiceSectionName = null, BillingAmount lastMonthCharges = null, BillingAmount monthToDateCharges = null, string nextBillingCycleBillingFrequency = null, string offerId = null, string productCategory = null, string productType = null, string productTypeId = null, DateTimeOffset? purchaseOn = null, long? quantity = null, CreatedSubscriptionReseller reseller = null, SubscriptionRenewalTermDetails renewalTermDetails = null, string skuDescription = null, string skuId = null, BillingSubscriptionStatus? status = null, string subscriptionId = null, IEnumerable<string> suspensionReasons = null, TimeSpan? termDuration = null, DateTimeOffset? termStartOn = null, DateTimeOffset? termEndOn = null, SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus = null, DateTimeOffset? enrollmentAccountStartOn = null, ResourceIdentifier billingSubscriptionId = null)
        {
            billingPolicies ??= new Dictionary<string, string>();
            suspensionReasons ??= new List<string>();

            return new BillingSubscriptionAliasData(id, name, resourceType, systemData, autoRenew, beneficiaryTenantId, billingFrequency, billingProfileId, billingPolicies, billingProfileDisplayName, billingProfileName, consumptionCostCenter, customerId, customerDisplayName, displayName, enrollmentAccountId, enrollmentAccountDisplayName, invoiceSectionId, invoiceSectionDisplayName, invoiceSectionName, lastMonthCharges, monthToDateCharges, nextBillingCycleBillingFrequency != null ? new NextBillingCycleDetails(nextBillingCycleBillingFrequency) : null, offerId, productCategory, productType, productTypeId, purchaseOn, quantity, reseller, renewalTermDetails, skuDescription, skuId, status, subscriptionId, suspensionReasons?.ToList(), termDuration, termStartOn, termEndOn, subscriptionEnrollmentAccountStatus, enrollmentAccountStartOn, billingSubscriptionId);
        }

        /// <summary> Initializes a new instance of BillingPaymentMethodData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="family"> The family of payment method. </param>
        /// <param name="paymentMethodType"> The type of payment method. </param>
        /// <param name="accountHolderName"> The account holder name for the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="expiration"> The expiration month and year of the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="lastFourDigits"> Last four digits of payment method. </param>
        /// <param name="displayName"> The display name of the payment method. </param>
        /// <param name="logos"> The list of logos for the payment method. </param>
        /// <param name="status"> Status of the payment method. </param>
        /// <returns> A new <see cref="Billing.BillingPaymentMethodData"/> instance for mocking. </returns>
        public static BillingPaymentMethodData BillingPaymentMethodData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PaymentMethodFamily? family = null, string paymentMethodType = null, string accountHolderName = null, string expiration = null, string lastFourDigits = null, string displayName = null, IEnumerable<PaymentMethodLogo> logos = null, PaymentMethodStatus? status = null)
        {
            logos ??= new List<PaymentMethodLogo>();

            return new BillingPaymentMethodData(id, name, resourceType, systemData, family, paymentMethodType, accountHolderName, expiration, lastFourDigits, displayName, logos?.ToList(), status);
        }

        /// <summary> Initializes a new instance of PaymentMethodLogo. </summary>
        /// <param name="mimeType"> MIME type of the logo. </param>
        /// <param name="uri"> Public URL of image of the logo. </param>
        /// <returns> A new <see cref="Models.PaymentMethodLogo"/> instance for mocking. </returns>
        public static PaymentMethodLogo PaymentMethodLogo(string mimeType = null, Uri uri = null)
        {
            return new PaymentMethodLogo(mimeType, uri);
        }

        /// <summary> Initializes a new instance of BillingPaymentMethodLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="paymentMethod"> Projection of a payment method. </param>
        /// <returns> A new <see cref="Billing.BillingPaymentMethodLinkData"/> instance for mocking. </returns>
        public static BillingPaymentMethodLinkData BillingPaymentMethodLinkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PaymentMethodProjectionProperties paymentMethod = null)
        {
            return new BillingPaymentMethodLinkData(id, name, resourceType, systemData, paymentMethod);
        }

        /// <summary> Initializes a new instance of PaymentMethodProjectionProperties. </summary>
        /// <param name="paymentMethodId"> Id of payment method. </param>
        /// <param name="family"> The family of payment method. </param>
        /// <param name="paymentMethodProjectionPropertiesType"> The type of payment method. </param>
        /// <param name="accountHolderName"> The account holder name for the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="expiration"> The expiration month and year of the payment method. This is only supported for payment methods with family CreditCard. </param>
        /// <param name="lastFourDigits"> Last four digits of payment method. </param>
        /// <param name="displayName"> The display name of the payment method. </param>
        /// <param name="logos"> The list of logos for the payment method. </param>
        /// <param name="status"> Status of the payment method. </param>
        /// <returns> A new <see cref="Models.PaymentMethodProjectionProperties"/> instance for mocking. </returns>
        public static PaymentMethodProjectionProperties PaymentMethodProjectionProperties(ResourceIdentifier paymentMethodId = null, PaymentMethodFamily? family = null, string paymentMethodProjectionPropertiesType = null, string accountHolderName = null, string expiration = null, string lastFourDigits = null, string displayName = null, IEnumerable<PaymentMethodLogo> logos = null, PaymentMethodStatus? status = null)
        {
            logos ??= new List<PaymentMethodLogo>();

            return new PaymentMethodProjectionProperties(paymentMethodId, family, paymentMethodProjectionPropertiesType, accountHolderName, expiration, lastFourDigits, displayName, logos?.ToList(), status);
        }
    }
}