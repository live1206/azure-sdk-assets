// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The DataCollectionRuleEventHubDirectDestination. </summary>
    public partial class DataCollectionRuleEventHubDirectDestination
    {
        /// <summary> Initializes a new instance of DataCollectionRuleEventHubDirectDestination. </summary>
        public DataCollectionRuleEventHubDirectDestination()
        {
        }

        /// <summary> Initializes a new instance of DataCollectionRuleEventHubDirectDestination. </summary>
        /// <param name="eventHubResourceId"> The resource ID of the event hub. </param>
        /// <param name="name">
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </param>
        internal DataCollectionRuleEventHubDirectDestination(ResourceIdentifier eventHubResourceId, string name)
        {
            EventHubResourceId = eventHubResourceId;
            Name = name;
        }

        /// <summary> The resource ID of the event hub. </summary>
        public ResourceIdentifier EventHubResourceId { get; set; }
        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}