// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class MonitorPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of MonitorPrivateLinkResourceListResult. </summary>
        internal MonitorPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<MonitorPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of MonitorPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal MonitorPrivateLinkResourceListResult(IReadOnlyList<MonitorPrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<MonitorPrivateLinkResourceData> Value { get; }
    }
}