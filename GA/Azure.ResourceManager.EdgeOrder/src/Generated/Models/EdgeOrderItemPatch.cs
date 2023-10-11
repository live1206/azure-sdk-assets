// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Updates order item parameters. </summary>
    public partial class EdgeOrderItemPatch
    {
        /// <summary> Initializes a new instance of EdgeOrderItemPatch. </summary>
        public EdgeOrderItemPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            NotificationEmailList = new ChangeTrackingList<string>();
        }

        /// <summary> The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Updates forward shipping address and contact details. </summary>
        public EdgeOrderItemAddressProperties ForwardAddress { get; set; }
        /// <summary> Customer preference. </summary>
        public OrderItemPreferences Preferences { get; set; }
        /// <summary> Additional notification email list. </summary>
        public IList<string> NotificationEmailList { get; }
    }
}