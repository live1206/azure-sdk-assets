// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The source of the gallery artifact version. </summary>
    public partial class GalleryArtifactVersionFullSource : GalleryArtifactVersionSource
    {
        /// <summary> Initializes a new instance of GalleryArtifactVersionFullSource. </summary>
        public GalleryArtifactVersionFullSource()
        {
        }

        /// <summary> Initializes a new instance of GalleryArtifactVersionFullSource. </summary>
        /// <param name="id"> The id of the gallery artifact version source. Can specify a disk uri, snapshot uri, user image or storage account resource. </param>
        /// <param name="communityGalleryImageId"> The resource Id of the source Community Gallery Image.  Only required when using Community Gallery Image as a source. </param>
        internal GalleryArtifactVersionFullSource(ResourceIdentifier id, string communityGalleryImageId) : base(id)
        {
            CommunityGalleryImageId = communityGalleryImageId;
        }

        /// <summary> The resource Id of the source Community Gallery Image.  Only required when using Community Gallery Image as a source. </summary>
        public string CommunityGalleryImageId { get; set; }
    }
}