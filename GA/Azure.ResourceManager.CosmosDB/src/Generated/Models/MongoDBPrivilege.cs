// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The set of data plane operations permitted through this Role Definition. </summary>
    public partial class MongoDBPrivilege
    {
        /// <summary> Initializes a new instance of MongoDBPrivilege. </summary>
        public MongoDBPrivilege()
        {
            Actions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MongoDBPrivilege. </summary>
        /// <param name="resource"> An Azure Cosmos DB Mongo DB Resource. </param>
        /// <param name="actions"> An array of actions that are allowed. </param>
        internal MongoDBPrivilege(MongoDBPrivilegeResourceInfo resource, IList<string> actions)
        {
            Resource = resource;
            Actions = actions;
        }

        /// <summary> An Azure Cosmos DB Mongo DB Resource. </summary>
        public MongoDBPrivilegeResourceInfo Resource { get; set; }
        /// <summary> An array of actions that are allowed. </summary>
        public IList<string> Actions { get; }
    }
}
