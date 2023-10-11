// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Environment Auth Token. </summary>
    public partial class ContainerAppEnvironmentAuthToken : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ContainerAppEnvironmentAuthToken. </summary>
        /// <param name="location"> The location. </param>
        public ContainerAppEnvironmentAuthToken(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ContainerAppEnvironmentAuthToken. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="token"> Auth token value. </param>
        /// <param name="expireOn"> Token expiration date. </param>
        internal ContainerAppEnvironmentAuthToken(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string token, DateTimeOffset? expireOn) : base(id, name, resourceType, systemData, tags, location)
        {
            Token = token;
            ExpireOn = expireOn;
        }

        /// <summary> Auth token value. </summary>
        public string Token { get; }
        /// <summary> Token expiration date. </summary>
        public DateTimeOffset? ExpireOn { get; }
    }
}