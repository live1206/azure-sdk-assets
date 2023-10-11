// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The properties of a payment method projection. </summary>
    public partial class PaymentMethodProjectionProperties
    {
        /// <summary> Initializes a new instance of PaymentMethodProjectionProperties. </summary>
        public PaymentMethodProjectionProperties()
        {
            Logos = new ChangeTrackingList<PaymentMethodLogo>();
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
        internal PaymentMethodProjectionProperties(ResourceIdentifier paymentMethodId, PaymentMethodFamily? family, string paymentMethodProjectionPropertiesType, string accountHolderName, string expiration, string lastFourDigits, string displayName, IList<PaymentMethodLogo> logos, PaymentMethodStatus? status)
        {
            PaymentMethodId = paymentMethodId;
            Family = family;
            PaymentMethodProjectionPropertiesType = paymentMethodProjectionPropertiesType;
            AccountHolderName = accountHolderName;
            Expiration = expiration;
            LastFourDigits = lastFourDigits;
            DisplayName = displayName;
            Logos = logos;
            Status = status;
        }

        /// <summary> Id of payment method. </summary>
        public ResourceIdentifier PaymentMethodId { get; }
        /// <summary> The family of payment method. </summary>
        public PaymentMethodFamily? Family { get; set; }
        /// <summary> The type of payment method. </summary>
        public string PaymentMethodProjectionPropertiesType { get; }
        /// <summary> The account holder name for the payment method. This is only supported for payment methods with family CreditCard. </summary>
        public string AccountHolderName { get; }
        /// <summary> The expiration month and year of the payment method. This is only supported for payment methods with family CreditCard. </summary>
        public string Expiration { get; }
        /// <summary> Last four digits of payment method. </summary>
        public string LastFourDigits { get; }
        /// <summary> The display name of the payment method. </summary>
        public string DisplayName { get; }
        /// <summary> The list of logos for the payment method. </summary>
        public IList<PaymentMethodLogo> Logos { get; }
        /// <summary> Status of the payment method. </summary>
        public PaymentMethodStatus? Status { get; set; }
    }
}