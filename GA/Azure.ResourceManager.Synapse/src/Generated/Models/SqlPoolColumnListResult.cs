// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of Sql pool columns. </summary>
    internal partial class SqlPoolColumnListResult
    {
        /// <summary> Initializes a new instance of SqlPoolColumnListResult. </summary>
        internal SqlPoolColumnListResult()
        {
            Value = new ChangeTrackingList<SynapseSqlPoolColumnData>();
        }

        /// <summary> Initializes a new instance of SqlPoolColumnListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SqlPoolColumnListResult(IReadOnlyList<SynapseSqlPoolColumnData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseSqlPoolColumnData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}