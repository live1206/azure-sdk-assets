// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> List of subscription Ids in the private store. </summary>
    public partial class SubscriptionsContextList
    {
        /// <summary> Initializes a new instance of SubscriptionsContextList. </summary>
        internal SubscriptionsContextList()
        {
            SubscriptionsIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SubscriptionsContextList. </summary>
        /// <param name="subscriptionsIds"></param>
        internal SubscriptionsContextList(IReadOnlyList<string> subscriptionsIds)
        {
            SubscriptionsIds = subscriptionsIds;
        }

        /// <summary> Gets the subscriptions ids. </summary>
        public IReadOnlyList<string> SubscriptionsIds { get; }
    }
}