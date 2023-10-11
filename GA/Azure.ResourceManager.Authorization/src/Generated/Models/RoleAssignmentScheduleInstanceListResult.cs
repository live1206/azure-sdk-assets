// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role assignment schedule instance list operation result. </summary>
    internal partial class RoleAssignmentScheduleInstanceListResult
    {
        /// <summary> Initializes a new instance of RoleAssignmentScheduleInstanceListResult. </summary>
        internal RoleAssignmentScheduleInstanceListResult()
        {
            Value = new ChangeTrackingList<RoleAssignmentScheduleInstanceData>();
        }

        /// <summary> Initializes a new instance of RoleAssignmentScheduleInstanceListResult. </summary>
        /// <param name="value"> Role assignment schedule instance list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleAssignmentScheduleInstanceListResult(IReadOnlyList<RoleAssignmentScheduleInstanceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role assignment schedule instance list. </summary>
        public IReadOnlyList<RoleAssignmentScheduleInstanceData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}