// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The details to get the request plans statuses. </summary>
    public partial class QueryApprovalRequestContent
    {
        /// <summary> Initializes a new instance of QueryApprovalRequestContent. </summary>
        public QueryApprovalRequestContent()
        {
            PlanIds = new ChangeTrackingList<string>();
        }

        /// <summary> The offer's publisher id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Current plans list. </summary>
        public IList<string> PlanIds { get; }
        /// <summary> Gets or sets the subscription id. </summary>
        public string SubscriptionId { get; set; }
    }
}