// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Describes the properties of a resource type that has been onboarded to private link service. </summary>
    public partial class ShareablePrivateLinkProperties
    {
        /// <summary> Initializes a new instance of ShareablePrivateLinkProperties. </summary>
        public ShareablePrivateLinkProperties()
        {
        }

        /// <summary> Initializes a new instance of ShareablePrivateLinkProperties. </summary>
        /// <param name="description"> The description of the resource type that has been onboarded to private link service. </param>
        /// <param name="groupId"> The resource provider group id for the resource that has been onboarded to private link service. </param>
        /// <param name="shareablePrivateLinkPropertiesType"> The resource provider type for the resource that has been onboarded to private link service. </param>
        internal ShareablePrivateLinkProperties(string description, string groupId, string shareablePrivateLinkPropertiesType)
        {
            Description = description;
            GroupId = groupId;
            ShareablePrivateLinkPropertiesType = shareablePrivateLinkPropertiesType;
        }

        /// <summary> The description of the resource type that has been onboarded to private link service. </summary>
        public string Description { get; set; }
        /// <summary> The resource provider group id for the resource that has been onboarded to private link service. </summary>
        public string GroupId { get; set; }
        /// <summary> The resource provider type for the resource that has been onboarded to private link service. </summary>
        public string ShareablePrivateLinkPropertiesType { get; set; }
    }
}