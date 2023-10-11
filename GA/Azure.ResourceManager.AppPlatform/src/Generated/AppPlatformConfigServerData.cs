// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformConfigServer data model.
    /// Config Server resource
    /// </summary>
    public partial class AppPlatformConfigServerData : ResourceData
    {
        /// <summary> Initializes a new instance of AppPlatformConfigServerData. </summary>
        public AppPlatformConfigServerData()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformConfigServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the Config Server resource. </param>
        internal AppPlatformConfigServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformConfigServerProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the Config Server resource. </summary>
        public AppPlatformConfigServerProperties Properties { get; set; }
    }
}
