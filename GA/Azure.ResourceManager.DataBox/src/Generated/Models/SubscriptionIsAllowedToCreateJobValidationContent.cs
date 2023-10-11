// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request to validate subscription permission to create jobs. </summary>
    public partial class SubscriptionIsAllowedToCreateJobValidationContent : DataBoxValidationInputContent
    {
        /// <summary> Initializes a new instance of SubscriptionIsAllowedToCreateJobValidationContent. </summary>
        public SubscriptionIsAllowedToCreateJobValidationContent()
        {
            ValidationType = DataBoxValidationInputDiscriminator.ValidateSubscriptionIsAllowedToCreateJob;
        }
    }
}