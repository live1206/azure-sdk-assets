// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> AadConfiguration represents the Azure Active Directory Integration properties. </summary>
    internal partial class NetworkCloudAadConfiguration
    {
        /// <summary> Initializes a new instance of NetworkCloudAadConfiguration. </summary>
        /// <param name="adminGroupObjectIds"> The list of Azure Active Directory group object IDs that will have an administrative role on the Kubernetes cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="adminGroupObjectIds"/> is null. </exception>
        public NetworkCloudAadConfiguration(IEnumerable<string> adminGroupObjectIds)
        {
            Argument.AssertNotNull(adminGroupObjectIds, nameof(adminGroupObjectIds));

            AdminGroupObjectIds = adminGroupObjectIds.ToList();
        }

        /// <summary> Initializes a new instance of NetworkCloudAadConfiguration. </summary>
        /// <param name="adminGroupObjectIds"> The list of Azure Active Directory group object IDs that will have an administrative role on the Kubernetes cluster. </param>
        internal NetworkCloudAadConfiguration(IList<string> adminGroupObjectIds)
        {
            AdminGroupObjectIds = adminGroupObjectIds;
        }

        /// <summary> The list of Azure Active Directory group object IDs that will have an administrative role on the Kubernetes cluster. </summary>
        public IList<string> AdminGroupObjectIds { get; }
    }
}
