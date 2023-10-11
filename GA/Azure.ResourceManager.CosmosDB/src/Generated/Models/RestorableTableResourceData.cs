// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Specific Databases to restore. </summary>
    public partial class RestorableTableResourceData
    {
        /// <summary> Initializes a new instance of RestorableTableResourceData. </summary>
        internal RestorableTableResourceData()
        {
        }

        /// <summary> Initializes a new instance of RestorableTableResourceData. </summary>
        /// <param name="id"> The unique resource identifier of the ARM resource. </param>
        /// <param name="name"> The name of the Table. </param>
        /// <param name="resourceType"> The type of Azure resource. </param>
        internal RestorableTableResourceData(string id, string name, string resourceType)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> The unique resource identifier of the ARM resource. </summary>
        public string Id { get; }
        /// <summary> The name of the Table. </summary>
        public string Name { get; }
        /// <summary> The type of Azure resource. </summary>
        public string ResourceType { get; }
    }
}