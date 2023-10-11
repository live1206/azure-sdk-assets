// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CostManagement;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Scheduled actions list result. It contains a list of scheduled actions. </summary>
    internal partial class ScheduledActionListResult
    {
        /// <summary> Initializes a new instance of ScheduledActionListResult. </summary>
        internal ScheduledActionListResult()
        {
            Value = new ChangeTrackingList<ScheduledActionData>();
        }

        /// <summary> Initializes a new instance of ScheduledActionListResult. </summary>
        /// <param name="value"> The list of scheduled actions. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal ScheduledActionListResult(IReadOnlyList<ScheduledActionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of scheduled actions. </summary>
        public IReadOnlyList<ScheduledActionData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}