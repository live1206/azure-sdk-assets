// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the properties for manual resolution. </summary>
    internal partial class ManualResolutionProperties
    {
        /// <summary> Initializes a new instance of ManualResolutionProperties. </summary>
        internal ManualResolutionProperties()
        {
        }

        /// <summary> Initializes a new instance of ManualResolutionProperties. </summary>
        /// <param name="targetId"> Gets or sets the target resource ARM ID of the dependent resource if the resource type is Manual. </param>
        internal ManualResolutionProperties(ResourceIdentifier targetId)
        {
            TargetId = targetId;
        }

        /// <summary> Gets or sets the target resource ARM ID of the dependent resource if the resource type is Manual. </summary>
        public ResourceIdentifier TargetId { get; }
    }
}