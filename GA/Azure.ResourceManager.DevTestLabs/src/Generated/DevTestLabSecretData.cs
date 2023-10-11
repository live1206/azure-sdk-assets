// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing the DevTestLabSecret data model.
    /// A secret.
    /// </summary>
    public partial class DevTestLabSecretData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DevTestLabSecretData. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabSecretData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DevTestLabSecretData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="value"> The value of the secret for secret creation. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        internal DevTestLabSecretData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string value, string provisioningState, Guid? uniqueIdentifier) : base(id, name, resourceType, systemData, tags, location)
        {
            Value = value;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary> The value of the secret for secret creation. </summary>
        public string Value { get; set; }
        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public Guid? UniqueIdentifier { get; }
    }
}