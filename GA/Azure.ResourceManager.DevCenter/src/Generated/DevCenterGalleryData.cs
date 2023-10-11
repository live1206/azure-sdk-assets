// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing the DevCenterGallery data model.
    /// Represents a gallery.
    /// </summary>
    public partial class DevCenterGalleryData : ResourceData
    {
        /// <summary> Initializes a new instance of DevCenterGalleryData. </summary>
        public DevCenterGalleryData()
        {
        }

        /// <summary> Initializes a new instance of DevCenterGalleryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="galleryResourceId"> The resource ID of the backing Azure Compute Gallery. </param>
        internal DevCenterGalleryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DevCenterProvisioningState? provisioningState, ResourceIdentifier galleryResourceId) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            GalleryResourceId = galleryResourceId;
        }

        /// <summary> The provisioning state of the resource. </summary>
        public DevCenterProvisioningState? ProvisioningState { get; }
        /// <summary> The resource ID of the backing Azure Compute Gallery. </summary>
        public ResourceIdentifier GalleryResourceId { get; set; }
    }
}