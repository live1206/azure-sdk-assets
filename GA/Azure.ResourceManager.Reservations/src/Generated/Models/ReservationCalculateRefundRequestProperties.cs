// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties needed for calculate refund including the scope and the reservation to be returned. </summary>
    public partial class ReservationCalculateRefundRequestProperties
    {
        /// <summary> Initializes a new instance of ReservationCalculateRefundRequestProperties. </summary>
        public ReservationCalculateRefundRequestProperties()
        {
        }

        /// <summary> The scope of the refund, e.g. Reservation. </summary>
        public string Scope { get; set; }
        /// <summary> Reservation to return. </summary>
        public ReservationToReturn ReservationToReturn { get; set; }
    }
}