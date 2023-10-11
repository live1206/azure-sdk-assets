// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> ResourceGuardProxyBase object, used in ResourceGuardProxyBaseResource. </summary>
    public partial class ResourceGuardProxyBase
    {
        /// <summary> Initializes a new instance of ResourceGuardProxyBase. </summary>
        public ResourceGuardProxyBase()
        {
            ResourceGuardOperationDetails = new ChangeTrackingList<ResourceGuardOperationDetail>();
        }

        /// <summary> Initializes a new instance of ResourceGuardProxyBase. </summary>
        /// <param name="resourceGuardResourceId"></param>
        /// <param name="resourceGuardOperationDetails"></param>
        /// <param name="lastUpdatedTime"></param>
        /// <param name="description"></param>
        internal ResourceGuardProxyBase(string resourceGuardResourceId, IList<ResourceGuardOperationDetail> resourceGuardOperationDetails, string lastUpdatedTime, string description)
        {
            ResourceGuardResourceId = resourceGuardResourceId;
            ResourceGuardOperationDetails = resourceGuardOperationDetails;
            LastUpdatedTime = lastUpdatedTime;
            Description = description;
        }

        /// <summary> Gets or sets the resource guard resource id. </summary>
        public string ResourceGuardResourceId { get; set; }
        /// <summary> Gets the resource guard operation details. </summary>
        public IList<ResourceGuardOperationDetail> ResourceGuardOperationDetails { get; }
        /// <summary> Gets or sets the last updated time. </summary>
        public string LastUpdatedTime { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}