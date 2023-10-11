// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Compute role against which events will be raised. </summary>
    public partial class DataBoxEdgeRoleSinkInfo
    {
        /// <summary> Initializes a new instance of DataBoxEdgeRoleSinkInfo. </summary>
        /// <param name="roleId"> Compute role ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleId"/> is null. </exception>
        public DataBoxEdgeRoleSinkInfo(ResourceIdentifier roleId)
        {
            Argument.AssertNotNull(roleId, nameof(roleId));

            RoleId = roleId;
        }

        /// <summary> Compute role ID. </summary>
        public ResourceIdentifier RoleId { get; set; }
    }
}