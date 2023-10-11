// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> List of restorable table names. </summary>
    internal partial class RestorableTableResourcesListResult
    {
        /// <summary> Initializes a new instance of RestorableTableResourcesListResult. </summary>
        internal RestorableTableResourcesListResult()
        {
            Value = new ChangeTrackingList<RestorableTableResourceData>();
        }

        /// <summary> Initializes a new instance of RestorableTableResourcesListResult. </summary>
        /// <param name="value"> List of restorable table names. </param>
        internal RestorableTableResourcesListResult(IReadOnlyList<RestorableTableResourceData> value)
        {
            Value = value;
        }

        /// <summary> List of restorable table names. </summary>
        public IReadOnlyList<RestorableTableResourceData> Value { get; }
    }
}
