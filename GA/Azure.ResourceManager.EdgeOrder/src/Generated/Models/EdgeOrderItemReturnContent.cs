// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Return order item request body. </summary>
    public partial class EdgeOrderItemReturnContent
    {
        /// <summary> Initializes a new instance of EdgeOrderItemReturnContent. </summary>
        /// <param name="returnReason"> Return Reason. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="returnReason"/> is null. </exception>
        public EdgeOrderItemReturnContent(string returnReason)
        {
            Argument.AssertNotNull(returnReason, nameof(returnReason));

            ReturnReason = returnReason;
        }

        /// <summary> customer return address. </summary>
        public EdgeOrderItemAddressProperties ReturnAddress { get; set; }
        /// <summary> Return Reason. </summary>
        public string ReturnReason { get; }
        /// <summary> Service tag (located on the bottom-right corner of the device). </summary>
        public string ServiceTag { get; set; }
        /// <summary> Shipping Box required. </summary>
        public bool? IsShippingBoxRequired { get; set; }
    }
}