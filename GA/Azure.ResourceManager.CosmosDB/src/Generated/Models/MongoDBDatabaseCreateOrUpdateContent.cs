// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB MongoDB database. </summary>
    public partial class MongoDBDatabaseCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary> Initializes a new instance of MongoDBDatabaseCreateOrUpdateContent. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a MongoDB database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public MongoDBDatabaseCreateOrUpdateContent(AzureLocation location, MongoDBDatabaseResourceInfo resource) : base(location)
        {
            Argument.AssertNotNull(resource, nameof(resource));

            Resource = resource;
        }

        /// <summary> Initializes a new instance of MongoDBDatabaseCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a MongoDB database. </param>
        /// <param name="options"> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </param>
        /// <param name="identity"> Identity for the resource. </param>
        internal MongoDBDatabaseCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MongoDBDatabaseResourceInfo resource, CosmosDBCreateUpdateConfig options, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
            Identity = identity;
        }

        /// <summary> The standard JSON format of a MongoDB database. </summary>
        public MongoDBDatabaseResourceInfo Resource { get; set; }
        /// <summary> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </summary>
        public CosmosDBCreateUpdateConfig Options { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
