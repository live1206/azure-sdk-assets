// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The safety profile of the Gallery Application Version. </summary>
    internal partial class GalleryApplicationVersionSafetyProfile : GalleryArtifactSafetyProfileBase
    {
        /// <summary> Initializes a new instance of GalleryApplicationVersionSafetyProfile. </summary>
        public GalleryApplicationVersionSafetyProfile()
        {
        }

        /// <summary> Initializes a new instance of GalleryApplicationVersionSafetyProfile. </summary>
        /// <param name="allowDeletionOfReplicatedLocations"> Indicates whether or not removing this Gallery Image Version from replicated regions is allowed. </param>
        internal GalleryApplicationVersionSafetyProfile(bool? allowDeletionOfReplicatedLocations) : base(allowDeletionOfReplicatedLocations)
        {
        }
    }
}
