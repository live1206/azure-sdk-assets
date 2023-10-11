// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Request body of unlock delete API. </summary>
    public partial class UnlockDeleteContent
    {
        /// <summary> Initializes a new instance of UnlockDeleteContent. </summary>
        public UnlockDeleteContent()
        {
            ResourceGuardOperationRequests = new ChangeTrackingList<string>();
        }

        /// <summary> Gets the resource guard operation requests. </summary>
        public IList<string> ResourceGuardOperationRequests { get; }
        /// <summary> Gets or sets the resource to be deleted. </summary>
        public string ResourceToBeDeleted { get; set; }
    }
}