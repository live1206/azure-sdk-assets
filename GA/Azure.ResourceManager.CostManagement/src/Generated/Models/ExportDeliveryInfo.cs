// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The delivery information associated with a export. </summary>
    public partial class ExportDeliveryInfo
    {
        /// <summary> Initializes a new instance of ExportDeliveryInfo. </summary>
        /// <param name="destination"> Has destination for the export being delivered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="destination"/> is null. </exception>
        public ExportDeliveryInfo(ExportDeliveryDestination destination)
        {
            Argument.AssertNotNull(destination, nameof(destination));

            Destination = destination;
        }

        /// <summary> Has destination for the export being delivered. </summary>
        public ExportDeliveryDestination Destination { get; set; }
    }
}