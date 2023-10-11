// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Community ID list properties. </summary>
    public partial class IPCommunityIdList
    {
        /// <summary> Initializes a new instance of IPCommunityIdList. </summary>
        public IPCommunityIdList()
        {
            IPCommunityIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of IPCommunityIdList. </summary>
        /// <param name="ipCommunityIds"> List of IP Community resource IDs. </param>
        internal IPCommunityIdList(IList<ResourceIdentifier> ipCommunityIds)
        {
            IPCommunityIds = ipCommunityIds;
        }

        /// <summary> List of IP Community resource IDs. </summary>
        public IList<ResourceIdentifier> IPCommunityIds { get; }
    }
}