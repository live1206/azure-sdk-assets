// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The paginated list of peerings. </summary>
    internal partial class PeeringListResult
    {
        /// <summary> Initializes a new instance of PeeringListResult. </summary>
        internal PeeringListResult()
        {
            Value = new ChangeTrackingList<PeeringData>();
        }

        /// <summary> Initializes a new instance of PeeringListResult. </summary>
        /// <param name="value"> The list of peerings. </param>
        /// <param name="nextLink"> The link to fetch the next page of peerings. </param>
        internal PeeringListResult(IReadOnlyList<PeeringData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of peerings. </summary>
        public IReadOnlyList<PeeringData> Value { get; }
        /// <summary> The link to fetch the next page of peerings. </summary>
        public string NextLink { get; }
    }
}