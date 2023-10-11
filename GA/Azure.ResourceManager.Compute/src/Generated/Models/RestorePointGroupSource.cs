// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The properties of the source resource that this restore point collection is created from. </summary>
    public partial class RestorePointGroupSource
    {
        /// <summary> Initializes a new instance of RestorePointGroupSource. </summary>
        public RestorePointGroupSource()
        {
        }

        /// <summary> Initializes a new instance of RestorePointGroupSource. </summary>
        /// <param name="location"> Location of the source resource used to create this restore point collection. </param>
        /// <param name="id"> Resource Id of the source resource used to create this restore point collection. </param>
        internal RestorePointGroupSource(AzureLocation? location, ResourceIdentifier id)
        {
            Location = location;
            Id = id;
        }

        /// <summary> Location of the source resource used to create this restore point collection. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Resource Id of the source resource used to create this restore point collection. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}