// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Properties of a Fleet that can be patched. </summary>
    public partial class ContainerServiceFleetPatch
    {
        /// <summary> Initializes a new instance of ContainerServiceFleetPatch. </summary>
        public ContainerServiceFleetPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}