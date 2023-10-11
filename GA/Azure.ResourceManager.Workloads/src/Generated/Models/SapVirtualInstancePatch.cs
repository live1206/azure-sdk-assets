// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the request body for updating Virtual Instance for SAP. </summary>
    public partial class SapVirtualInstancePatch
    {
        /// <summary> Initializes a new instance of SapVirtualInstancePatch. </summary>
        public SapVirtualInstancePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> A pre-created user assigned identity with appropriate roles assigned. To learn more on identity and roles required, visit the ACSS how-to-guide. </summary>
        public UserAssignedServiceIdentity Identity { get; set; }
    }
}
