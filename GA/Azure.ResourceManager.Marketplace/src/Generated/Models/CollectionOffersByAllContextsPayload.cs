// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Suggested subscription list. </summary>
    public partial class CollectionOffersByAllContextsPayload
    {
        /// <summary> Initializes a new instance of CollectionOffersByAllContextsPayload. </summary>
        public CollectionOffersByAllContextsPayload()
        {
            SubscriptionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Subscription ids list. </summary>
        public IList<string> SubscriptionIds { get; }
    }
}