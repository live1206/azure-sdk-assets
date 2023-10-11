// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The api operation. </summary>
    public partial class LogicApiOperationInfo : TrackedResourceData
    {
        /// <summary> Initializes a new instance of LogicApiOperationInfo. </summary>
        /// <param name="location"> The location. </param>
        public LogicApiOperationInfo(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of LogicApiOperationInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The api operations properties. </param>
        internal LogicApiOperationInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, LogicApiOperationProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> The api operations properties. </summary>
        public LogicApiOperationProperties Properties { get; set; }
    }
}