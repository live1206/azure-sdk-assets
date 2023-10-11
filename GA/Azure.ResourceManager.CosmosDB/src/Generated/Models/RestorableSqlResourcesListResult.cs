// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the restorable SQL resources. </summary>
    internal partial class RestorableSqlResourcesListResult
    {
        /// <summary> Initializes a new instance of RestorableSqlResourcesListResult. </summary>
        internal RestorableSqlResourcesListResult()
        {
            Value = new ChangeTrackingList<RestorableSqlResourceData>();
        }

        /// <summary> Initializes a new instance of RestorableSqlResourcesListResult. </summary>
        /// <param name="value"> List of restorable SQL resources, including the database and collection names. </param>
        internal RestorableSqlResourcesListResult(IReadOnlyList<RestorableSqlResourceData> value)
        {
            Value = value;
        }

        /// <summary> List of restorable SQL resources, including the database and collection names. </summary>
        public IReadOnlyList<RestorableSqlResourceData> Value { get; }
    }
}