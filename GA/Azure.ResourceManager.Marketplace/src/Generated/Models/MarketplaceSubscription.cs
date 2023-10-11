// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Subscription information. </summary>
    public partial class MarketplaceSubscription
    {
        /// <summary> Initializes a new instance of MarketplaceSubscription. </summary>
        internal MarketplaceSubscription()
        {
        }

        /// <summary> Initializes a new instance of MarketplaceSubscription. </summary>
        /// <param name="id"> The fully qualified ID for the subscription. For example, /subscriptions/00000000-0000-0000-0000-000000000000. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="displayName"> The subscription display name. </param>
        /// <param name="state"> The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted. </param>
        internal MarketplaceSubscription(string id, string subscriptionId, string displayName, MarketplaceSubscriptionState? state)
        {
            Id = id;
            SubscriptionId = subscriptionId;
            DisplayName = displayName;
            State = state;
        }

        /// <summary> The fully qualified ID for the subscription. For example, /subscriptions/00000000-0000-0000-0000-000000000000. </summary>
        public string Id { get; }
        /// <summary> The subscription ID. </summary>
        public string SubscriptionId { get; }
        /// <summary> The subscription display name. </summary>
        public string DisplayName { get; }
        /// <summary> The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted. </summary>
        public MarketplaceSubscriptionState? State { get; }
    }
}