// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Parameters used to update an existing Creator resource. </summary>
    public partial class MapsCreatorPatch
    {
        /// <summary> Initializes a new instance of MapsCreatorPatch. </summary>
        public MapsCreatorPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The state of the resource provisioning, terminal states: Succeeded, Failed, Canceled. </summary>
        public string ProvisioningState { get; }
        /// <summary> The storage units to be allocated. Integer values from 1 to 100, inclusive. </summary>
        public int? StorageUnits { get; set; }
    }
}