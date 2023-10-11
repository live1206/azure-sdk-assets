// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties of reservation split. </summary>
    public partial class ReservationSplitProperties
    {
        /// <summary> Initializes a new instance of ReservationSplitProperties. </summary>
        internal ReservationSplitProperties()
        {
            SplitDestinations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ReservationSplitProperties. </summary>
        /// <param name="splitDestinations"> List of destination resource id that are created due to split. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        /// <param name="splitSource"> Resource id of the reservation from which this is split. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        internal ReservationSplitProperties(IReadOnlyList<string> splitDestinations, string splitSource)
        {
            SplitDestinations = splitDestinations;
            SplitSource = splitSource;
        }

        /// <summary> List of destination resource id that are created due to split. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public IReadOnlyList<string> SplitDestinations { get; }
        /// <summary> Resource id of the reservation from which this is split. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public string SplitSource { get; }
    }
}