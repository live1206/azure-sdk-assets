// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary>
    /// A class representing the EdgeOrderItem data model.
    /// Represents order item contract
    /// </summary>
    public partial class EdgeOrderItemData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of EdgeOrderItemData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="orderItemDetails"> Represents order item details. </param>
        /// <param name="addressDetails"> Represents shipping and return address for order item. </param>
        /// <param name="orderId"> Id of the order to which order item belongs to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemDetails"/>, <paramref name="addressDetails"/> or <paramref name="orderId"/> is null. </exception>
        public EdgeOrderItemData(AzureLocation location, EdgeOrderItemDetails orderItemDetails, EdgeOrderItemAddressDetails addressDetails, ResourceIdentifier orderId) : base(location)
        {
            Argument.AssertNotNull(orderItemDetails, nameof(orderItemDetails));
            Argument.AssertNotNull(addressDetails, nameof(addressDetails));
            Argument.AssertNotNull(orderId, nameof(orderId));

            OrderItemDetails = orderItemDetails;
            AddressDetails = addressDetails;
            OrderId = orderId;
        }

        /// <summary> Initializes a new instance of EdgeOrderItemData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="orderItemDetails"> Represents order item details. </param>
        /// <param name="addressDetails"> Represents shipping and return address for order item. </param>
        /// <param name="startOn"> Start time of order item. </param>
        /// <param name="orderId"> Id of the order to which order item belongs to. </param>
        internal EdgeOrderItemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EdgeOrderItemDetails orderItemDetails, EdgeOrderItemAddressDetails addressDetails, DateTimeOffset? startOn, ResourceIdentifier orderId) : base(id, name, resourceType, systemData, tags, location)
        {
            OrderItemDetails = orderItemDetails;
            AddressDetails = addressDetails;
            StartOn = startOn;
            OrderId = orderId;
        }

        /// <summary> Represents order item details. </summary>
        public EdgeOrderItemDetails OrderItemDetails { get; set; }
        /// <summary> Represents shipping and return address for order item. </summary>
        public EdgeOrderItemAddressDetails AddressDetails { get; set; }
        /// <summary> Start time of order item. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Id of the order to which order item belongs to. </summary>
        public ResourceIdentifier OrderId { get; set; }
    }
}