// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Application type version update request. </summary>
    public partial class ServiceFabricManagedApplicationTypeVersionPatch
    {
        /// <summary> Initializes a new instance of ServiceFabricManagedApplicationTypeVersionPatch. </summary>
        public ServiceFabricManagedApplicationTypeVersionPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Application type version update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}