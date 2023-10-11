// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Properties needed for refund request including the session id from calculate refund, the scope, the reservation to be returned and the return reason. </summary>
    public partial class ReservationRefundRequestProperties
    {
        /// <summary> Initializes a new instance of ReservationRefundRequestProperties. </summary>
        public ReservationRefundRequestProperties()
        {
        }

        /// <summary> SessionId that was returned by CalculateRefund API. </summary>
        public Guid? SessionId { get; set; }
        /// <summary> The scope of the refund, e.g. Reservation. </summary>
        public string Scope { get; set; }
        /// <summary> Reservation to return. </summary>
        public ReservationToReturn ReservationToReturn { get; set; }
        /// <summary> The reason of returning the reservation. </summary>
        public string ReturnReason { get; set; }
    }
}
