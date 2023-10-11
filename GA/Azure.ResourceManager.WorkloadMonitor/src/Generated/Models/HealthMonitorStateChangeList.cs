// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.WorkloadMonitor;

namespace Azure.ResourceManager.WorkloadMonitor.Models
{
    /// <summary> Information about the health state changes of the monitor within the provided time window. </summary>
    internal partial class HealthMonitorStateChangeList
    {
        /// <summary> Initializes a new instance of HealthMonitorStateChangeList. </summary>
        internal HealthMonitorStateChangeList()
        {
            Value = new ChangeTrackingList<HealthMonitorStateChangeData>();
        }

        /// <summary> Initializes a new instance of HealthMonitorStateChangeList. </summary>
        /// <param name="value"> Array of health state changes within the specified time window. </param>
        /// <param name="nextLink"> Link to next page if the list is too long. </param>
        internal HealthMonitorStateChangeList(IReadOnlyList<HealthMonitorStateChangeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of health state changes within the specified time window. </summary>
        public IReadOnlyList<HealthMonitorStateChangeData> Value { get; }
        /// <summary> Link to next page if the list is too long. </summary>
        public string NextLink { get; }
    }
}