// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response from the List Application Groups operation. </summary>
    internal partial class EventHubsApplicationGroupListResult
    {
        /// <summary> Initializes a new instance of EventHubsApplicationGroupListResult. </summary>
        internal EventHubsApplicationGroupListResult()
        {
            Value = new ChangeTrackingList<EventHubsApplicationGroupData>();
        }

        /// <summary> Initializes a new instance of EventHubsApplicationGroupListResult. </summary>
        /// <param name="value"> Result of the List Application Groups operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains an incomplete list of Authorization Rules. </param>
        internal EventHubsApplicationGroupListResult(IReadOnlyList<EventHubsApplicationGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List Application Groups operation. </summary>
        public IReadOnlyList<EventHubsApplicationGroupData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains an incomplete list of Authorization Rules. </summary>
        public string NextLink { get; }
    }
}