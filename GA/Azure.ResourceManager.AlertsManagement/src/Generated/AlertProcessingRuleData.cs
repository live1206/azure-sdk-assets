// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary>
    /// A class representing the AlertProcessingRule data model.
    /// Alert processing rule object containing target scopes, conditions and scheduling logic.
    /// </summary>
    public partial class AlertProcessingRuleData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AlertProcessingRuleData. </summary>
        /// <param name="location"> The location. </param>
        public AlertProcessingRuleData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AlertProcessingRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Alert processing rule properties. </param>
        internal AlertProcessingRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AlertProcessingRuleProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> Alert processing rule properties. </summary>
        public AlertProcessingRuleProperties Properties { get; set; }
    }
}