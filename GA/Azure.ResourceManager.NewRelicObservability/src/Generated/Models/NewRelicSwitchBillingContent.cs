// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Request of a switch billing Operation. </summary>
    public partial class NewRelicSwitchBillingContent
    {
        /// <summary> Initializes a new instance of NewRelicSwitchBillingContent. </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        public NewRelicSwitchBillingContent(string userEmail)
        {
            Argument.AssertNotNull(userEmail, nameof(userEmail));

            UserEmail = userEmail;
        }

        /// <summary> Azure resource Id. </summary>
        public ResourceIdentifier AzureResourceId { get; set; }
        /// <summary> Organization id. </summary>
        public string OrganizationId { get; set; }
        /// <summary> Plan details. </summary>
        public NewRelicPlanDetails PlanData { get; set; }
        /// <summary> User Email. </summary>
        public string UserEmail { get; }
    }
}