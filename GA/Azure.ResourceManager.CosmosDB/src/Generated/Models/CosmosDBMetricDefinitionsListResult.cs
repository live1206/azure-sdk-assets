// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The response to a list metric definitions request. </summary>
    internal partial class CosmosDBMetricDefinitionsListResult
    {
        /// <summary> Initializes a new instance of CosmosDBMetricDefinitionsListResult. </summary>
        internal CosmosDBMetricDefinitionsListResult()
        {
            Value = new ChangeTrackingList<CosmosDBMetricDefinition>();
        }

        /// <summary> Initializes a new instance of CosmosDBMetricDefinitionsListResult. </summary>
        /// <param name="value"> The list of metric definitions for the account. </param>
        internal CosmosDBMetricDefinitionsListResult(IReadOnlyList<CosmosDBMetricDefinition> value)
        {
            Value = value;
        }

        /// <summary> The list of metric definitions for the account. </summary>
        public IReadOnlyList<CosmosDBMetricDefinition> Value { get; }
    }
}