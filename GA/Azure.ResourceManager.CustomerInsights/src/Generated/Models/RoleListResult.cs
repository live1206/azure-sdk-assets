// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list role assignment operation. </summary>
    internal partial class RoleListResult
    {
        /// <summary> Initializes a new instance of RoleListResult. </summary>
        internal RoleListResult()
        {
            Value = new ChangeTrackingList<RoleResourceFormat>();
        }

        /// <summary> Initializes a new instance of RoleListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal RoleListResult(IReadOnlyList<RoleResourceFormat> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<RoleResourceFormat> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}