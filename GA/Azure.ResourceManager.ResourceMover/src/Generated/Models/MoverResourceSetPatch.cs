// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the request body for updating move collection. </summary>
    public partial class MoverResourceSetPatch
    {
        /// <summary> Initializes a new instance of MoverResourceSetPatch. </summary>
        public MoverResourceSetPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Defines the MSI properties of the Move Collection. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}