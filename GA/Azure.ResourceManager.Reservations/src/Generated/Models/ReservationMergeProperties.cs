// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties of reservation merge. </summary>
    public partial class ReservationMergeProperties
    {
        /// <summary> Initializes a new instance of ReservationMergeProperties. </summary>
        internal ReservationMergeProperties()
        {
            MergeSources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ReservationMergeProperties. </summary>
        /// <param name="mergeDestination"> Reservation resource id Created due to the merge. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        /// <param name="mergeSources"> Resource ids of the source reservation's merged to form this reservation. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        internal ReservationMergeProperties(string mergeDestination, IReadOnlyList<string> mergeSources)
        {
            MergeDestination = mergeDestination;
            MergeSources = mergeSources;
        }

        /// <summary> Reservation resource id Created due to the merge. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public string MergeDestination { get; }
        /// <summary> Resource ids of the source reservation's merged to form this reservation. Format of the resource id is /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public IReadOnlyList<string> MergeSources { get; }
    }
}