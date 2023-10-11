// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Additional Map account properties. </summary>
    public partial class MapsAccountProperties
    {
        /// <summary> Initializes a new instance of MapsAccountProperties. </summary>
        public MapsAccountProperties()
        {
            LinkedResources = new ChangeTrackingList<MapsLinkedResource>();
        }

        /// <summary> Initializes a new instance of MapsAccountProperties. </summary>
        /// <param name="uniqueId"> A unique identifier for the maps account. </param>
        /// <param name="disableLocalAuth"> Allows toggle functionality on Azure Policy to disable Azure Maps local authentication support. This will disable Shared Keys authentication from any usage. </param>
        /// <param name="provisioningState"> The provisioning state of the Map account resource. </param>
        /// <param name="linkedResources"> Sets the resources to be used for Managed Identities based operations for the Map account resource. </param>
        /// <param name="cors"> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </param>
        internal MapsAccountProperties(Guid? uniqueId, bool? disableLocalAuth, string provisioningState, IList<MapsLinkedResource> linkedResources, CorsRules cors)
        {
            UniqueId = uniqueId;
            DisableLocalAuth = disableLocalAuth;
            ProvisioningState = provisioningState;
            LinkedResources = linkedResources;
            Cors = cors;
        }

        /// <summary> A unique identifier for the maps account. </summary>
        public Guid? UniqueId { get; }
        /// <summary> Allows toggle functionality on Azure Policy to disable Azure Maps local authentication support. This will disable Shared Keys authentication from any usage. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> The provisioning state of the Map account resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> Sets the resources to be used for Managed Identities based operations for the Map account resource. </summary>
        public IList<MapsLinkedResource> LinkedResources { get; }
        /// <summary> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </summary>
        internal CorsRules Cors { get; set; }
        /// <summary> The list of CORS rules. You can include up to five CorsRule elements in the request. </summary>
        public IList<MapsCorsRule> CorsRulesValue
        {
            get
            {
                if (Cors is null)
                    Cors = new CorsRules();
                return Cors.CorsRulesValue;
            }
        }
    }
}