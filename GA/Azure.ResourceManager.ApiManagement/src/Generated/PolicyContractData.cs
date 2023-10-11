// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the PolicyContract data model.
    /// Policy Contract details.
    /// </summary>
    public partial class PolicyContractData : ResourceData
    {
        /// <summary> Initializes a new instance of PolicyContractData. </summary>
        public PolicyContractData()
        {
        }

        /// <summary> Initializes a new instance of PolicyContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Contents of the Policy as defined by the format. </param>
        /// <param name="format"> Format of the policyContent. </param>
        internal PolicyContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string value, PolicyContentFormat? format) : base(id, name, resourceType, systemData)
        {
            Value = value;
            Format = format;
        }

        /// <summary> Contents of the Policy as defined by the format. </summary>
        public string Value { get; set; }
        /// <summary> Format of the policyContent. </summary>
        public PolicyContentFormat? Format { get; set; }
    }
}
