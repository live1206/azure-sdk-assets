// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of all possible traffic between Azure resources. </summary>
    internal partial class AllowedConnectionsList
    {
        /// <summary> Initializes a new instance of AllowedConnectionsList. </summary>
        internal AllowedConnectionsList()
        {
            Value = new ChangeTrackingList<SecurityCenterAllowedConnection>();
        }

        /// <summary> Initializes a new instance of AllowedConnectionsList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal AllowedConnectionsList(IReadOnlyList<SecurityCenterAllowedConnection> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecurityCenterAllowedConnection> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
