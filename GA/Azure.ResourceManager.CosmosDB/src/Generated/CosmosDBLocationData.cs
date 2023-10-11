// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the CosmosDBLocation data model.
    /// Cosmos DB location get result
    /// </summary>
    public partial class CosmosDBLocationData : ResourceData
    {
        /// <summary> Initializes a new instance of CosmosDBLocationData. </summary>
        public CosmosDBLocationData()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBLocationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Cosmos DB location metadata. </param>
        internal CosmosDBLocationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CosmosDBLocationProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Cosmos DB location metadata. </summary>
        public CosmosDBLocationProperties Properties { get; set; }
    }
}