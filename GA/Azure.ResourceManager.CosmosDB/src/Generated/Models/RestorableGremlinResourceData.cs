// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Specific Databases to restore. </summary>
    public partial class RestorableGremlinResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of RestorableGremlinResourceData. </summary>
        internal RestorableGremlinResourceData()
        {
            GraphNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RestorableGremlinResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="databaseName"> The name of the gremlin database available for restore. </param>
        /// <param name="graphNames"> The names of the graphs available for restore. </param>
        internal RestorableGremlinResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string databaseName, IReadOnlyList<string> graphNames) : base(id, name, resourceType, systemData)
        {
            DatabaseName = databaseName;
            GraphNames = graphNames;
        }

        /// <summary> The name of the gremlin database available for restore. </summary>
        public string DatabaseName { get; }
        /// <summary> The names of the graphs available for restore. </summary>
        public IReadOnlyList<string> GraphNames { get; }
    }
}