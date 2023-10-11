// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the properties for automatic resolution. </summary>
    internal partial class AutomaticResolutionProperties
    {
        /// <summary> Initializes a new instance of AutomaticResolutionProperties. </summary>
        internal AutomaticResolutionProperties()
        {
        }

        /// <summary> Initializes a new instance of AutomaticResolutionProperties. </summary>
        /// <param name="resourceId">
        /// Gets the MoveResource ARM ID of
        /// the dependent resource if the resolution type is Automatic.
        /// </param>
        internal AutomaticResolutionProperties(ResourceIdentifier resourceId)
        {
            ResourceId = resourceId;
        }

        /// <summary>
        /// Gets the MoveResource ARM ID of
        /// the dependent resource if the resolution type is Automatic.
        /// </summary>
        public ResourceIdentifier ResourceId { get; }
    }
}