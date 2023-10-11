// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the Gremlin graph events and their properties. </summary>
    internal partial class RestorableGremlinGraphsListResult
    {
        /// <summary> Initializes a new instance of RestorableGremlinGraphsListResult. </summary>
        internal RestorableGremlinGraphsListResult()
        {
            Value = new ChangeTrackingList<RestorableGremlinGraph>();
        }

        /// <summary> Initializes a new instance of RestorableGremlinGraphsListResult. </summary>
        /// <param name="value"> List of Gremlin graph events and their properties. </param>
        internal RestorableGremlinGraphsListResult(IReadOnlyList<RestorableGremlinGraph> value)
        {
            Value = value;
        }

        /// <summary> List of Gremlin graph events and their properties. </summary>
        public IReadOnlyList<RestorableGremlinGraph> Value { get; }
    }
}