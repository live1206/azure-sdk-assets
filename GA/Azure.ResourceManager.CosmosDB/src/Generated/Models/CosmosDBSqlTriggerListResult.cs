// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the triggers and their properties. </summary>
    internal partial class CosmosDBSqlTriggerListResult
    {
        /// <summary> Initializes a new instance of CosmosDBSqlTriggerListResult. </summary>
        internal CosmosDBSqlTriggerListResult()
        {
            Value = new ChangeTrackingList<CosmosDBSqlTriggerData>();
        }

        /// <summary> Initializes a new instance of CosmosDBSqlTriggerListResult. </summary>
        /// <param name="value"> List of triggers and their properties. </param>
        internal CosmosDBSqlTriggerListResult(IReadOnlyList<CosmosDBSqlTriggerData> value)
        {
            Value = value;
        }

        /// <summary> List of triggers and their properties. </summary>
        public IReadOnlyList<CosmosDBSqlTriggerData> Value { get; }
    }
}