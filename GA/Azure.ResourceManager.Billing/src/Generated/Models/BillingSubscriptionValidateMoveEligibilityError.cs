// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Error details of the transfer eligibility validation. </summary>
    public partial class BillingSubscriptionValidateMoveEligibilityError
    {
        /// <summary> Initializes a new instance of BillingSubscriptionValidateMoveEligibilityError. </summary>
        internal BillingSubscriptionValidateMoveEligibilityError()
        {
        }

        /// <summary> Initializes a new instance of BillingSubscriptionValidateMoveEligibilityError. </summary>
        /// <param name="code"> Error code for the billing subscription move validation. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> Detailed error message explaining the error. </param>
        internal BillingSubscriptionValidateMoveEligibilityError(SubscriptionTransferValidationErrorCode? code, string message, string details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary> Error code for the billing subscription move validation. </summary>
        public SubscriptionTransferValidationErrorCode? Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> Detailed error message explaining the error. </summary>
        public string Details { get; }
    }
}