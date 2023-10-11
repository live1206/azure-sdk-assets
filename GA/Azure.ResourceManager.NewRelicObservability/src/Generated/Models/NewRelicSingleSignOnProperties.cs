// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Single sign on Info of the NewRelic account. </summary>
    public partial class NewRelicSingleSignOnProperties
    {
        /// <summary> Initializes a new instance of NewRelicSingleSignOnProperties. </summary>
        public NewRelicSingleSignOnProperties()
        {
        }

        /// <summary> Initializes a new instance of NewRelicSingleSignOnProperties. </summary>
        /// <param name="singleSignOnState"> Single sign-on state. </param>
        /// <param name="enterpriseAppId"> The Id of the Enterprise App used for Single sign-on. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this NewRelic Organization. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        internal NewRelicSingleSignOnProperties(NewRelicSingleSignOnState? singleSignOnState, string enterpriseAppId, Uri singleSignOnUri, NewRelicProvisioningState? provisioningState)
        {
            SingleSignOnState = singleSignOnState;
            EnterpriseAppId = enterpriseAppId;
            SingleSignOnUri = singleSignOnUri;
            ProvisioningState = provisioningState;
        }

        /// <summary> Single sign-on state. </summary>
        public NewRelicSingleSignOnState? SingleSignOnState { get; set; }
        /// <summary> The Id of the Enterprise App used for Single sign-on. </summary>
        public string EnterpriseAppId { get; set; }
        /// <summary> The login URL specific to this NewRelic Organization. </summary>
        public Uri SingleSignOnUri { get; set; }
        /// <summary> Provisioning state. </summary>
        public NewRelicProvisioningState? ProvisioningState { get; set; }
    }
}