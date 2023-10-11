// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotFirmwareDefense.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary>
    /// A class representing the FirmwareWorkspace data model.
    /// Firmware analysis workspace.
    /// </summary>
    public partial class FirmwareWorkspaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of FirmwareWorkspaceData. </summary>
        /// <param name="location"> The location. </param>
        public FirmwareWorkspaceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of FirmwareWorkspaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        internal FirmwareWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}