// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list role assignment operation. </summary>
    internal partial class RoleAssignmentListResult
    {
        /// <summary> Initializes a new instance of RoleAssignmentListResult. </summary>
        internal RoleAssignmentListResult()
        {
            Value = new ChangeTrackingList<RoleAssignmentResourceFormatData>();
        }

        /// <summary> Initializes a new instance of RoleAssignmentListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal RoleAssignmentListResult(IReadOnlyList<RoleAssignmentResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<RoleAssignmentResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}