// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of workflows. </summary>
    internal partial class LogicWorkflowListResult
    {
        /// <summary> Initializes a new instance of LogicWorkflowListResult. </summary>
        internal LogicWorkflowListResult()
        {
            Value = new ChangeTrackingList<LogicWorkflowData>();
        }

        /// <summary> Initializes a new instance of LogicWorkflowListResult. </summary>
        /// <param name="value"> The list of workflows. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal LogicWorkflowListResult(IReadOnlyList<LogicWorkflowData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of workflows. </summary>
        public IReadOnlyList<LogicWorkflowData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}