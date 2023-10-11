// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> Describes a history request to be executed. </summary>
    public partial class ResourcesHistoryContent
    {
        /// <summary> Initializes a new instance of ResourcesHistoryContent. </summary>
        public ResourcesHistoryContent()
        {
            Subscriptions = new ChangeTrackingList<string>();
            ManagementGroups = new ChangeTrackingList<string>();
        }

        /// <summary> Azure subscriptions against which to execute the query. </summary>
        public IList<string> Subscriptions { get; }
        /// <summary> The resources query. </summary>
        public string Query { get; set; }
        /// <summary> The history request evaluation options. </summary>
        public ResourcesHistoryRequestOptions Options { get; set; }
        /// <summary> Azure management groups against which to execute the query. Example: [ 'mg1', 'mg2' ]. </summary>
        public IList<string> ManagementGroups { get; }
    }
}