// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Details of the resource. </summary>
    public partial class ConsumptionResourceProperties
    {
        /// <summary> Initializes a new instance of ConsumptionResourceProperties. </summary>
        internal ConsumptionResourceProperties()
        {
            AppliedScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ConsumptionResourceProperties. </summary>
        /// <param name="appliedScopes"> List of subscriptions for which the reservation is applied. </param>
        /// <param name="onDemandRate"> On demand rate of the resource. </param>
        /// <param name="product"> Azure product ex: Standard_E8s_v3 etc. </param>
        /// <param name="region"> Azure resource region ex:EastUS, WestUS etc. </param>
        /// <param name="reservationRate"> Reservation rate of the resource. </param>
        /// <param name="resourceType"> The azure resource type. </param>
        internal ConsumptionResourceProperties(IReadOnlyList<string> appliedScopes, float? onDemandRate, string product, string region, float? reservationRate, string resourceType)
        {
            AppliedScopes = appliedScopes;
            OnDemandRate = onDemandRate;
            Product = product;
            Region = region;
            ReservationRate = reservationRate;
            ResourceType = resourceType;
        }

        /// <summary> List of subscriptions for which the reservation is applied. </summary>
        public IReadOnlyList<string> AppliedScopes { get; }
        /// <summary> On demand rate of the resource. </summary>
        public float? OnDemandRate { get; }
        /// <summary> Azure product ex: Standard_E8s_v3 etc. </summary>
        public string Product { get; }
        /// <summary> Azure resource region ex:EastUS, WestUS etc. </summary>
        public string Region { get; }
        /// <summary> Reservation rate of the resource. </summary>
        public float? ReservationRate { get; }
        /// <summary> The azure resource type. </summary>
        public string ResourceType { get; }
    }
}