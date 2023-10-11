// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing the IntegrationAccountBatchConfiguration data model.
    /// The batch configuration resource definition.
    /// </summary>
    public partial class IntegrationAccountBatchConfigurationData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationAccountBatchConfigurationData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The batch configuration properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public IntegrationAccountBatchConfigurationData(AzureLocation location, IntegrationAccountBatchConfigurationProperties properties) : base(location)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of IntegrationAccountBatchConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The batch configuration properties. </param>
        internal IntegrationAccountBatchConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IntegrationAccountBatchConfigurationProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> The batch configuration properties. </summary>
        public IntegrationAccountBatchConfigurationProperties Properties { get; set; }
    }
}