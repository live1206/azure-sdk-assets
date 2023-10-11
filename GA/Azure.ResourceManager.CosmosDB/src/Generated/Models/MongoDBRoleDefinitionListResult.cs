// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The relevant Mongo Role Definitions. </summary>
    internal partial class MongoDBRoleDefinitionListResult
    {
        /// <summary> Initializes a new instance of MongoDBRoleDefinitionListResult. </summary>
        internal MongoDBRoleDefinitionListResult()
        {
            Value = new ChangeTrackingList<MongoDBRoleDefinitionData>();
        }

        /// <summary> Initializes a new instance of MongoDBRoleDefinitionListResult. </summary>
        /// <param name="value"> List of Mongo Role Definitions and their properties. </param>
        internal MongoDBRoleDefinitionListResult(IReadOnlyList<MongoDBRoleDefinitionData> value)
        {
            Value = value;
        }

        /// <summary> List of Mongo Role Definitions and their properties. </summary>
        public IReadOnlyList<MongoDBRoleDefinitionData> Value { get; }
    }
}