// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Result of the list devcenters operation. </summary>
    internal partial class DevCenterListResult
    {
        /// <summary> Initializes a new instance of DevCenterListResult. </summary>
        internal DevCenterListResult()
        {
            Value = new ChangeTrackingList<DevCenterData>();
        }

        /// <summary> Initializes a new instance of DevCenterListResult. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        internal DevCenterListResult(IReadOnlyList<DevCenterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<DevCenterData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
