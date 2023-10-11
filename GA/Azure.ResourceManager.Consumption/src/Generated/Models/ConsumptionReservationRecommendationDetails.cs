// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Reservation recommendation details. </summary>
    public partial class ConsumptionReservationRecommendationDetails : ResourceData
    {
        /// <summary> Initializes a new instance of ConsumptionReservationRecommendationDetails. </summary>
        internal ConsumptionReservationRecommendationDetails()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ConsumptionReservationRecommendationDetails. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="sku"> Resource sku. </param>
        /// <param name="currency"> An ISO 4217 currency code identifier for the costs and savings. </param>
        /// <param name="properties"> Resource specific properties. </param>
        /// <param name="resourceGroup"> Resource Group. </param>
        /// <param name="savings"> Savings information for the recommendation. </param>
        /// <param name="scope"> Scope of the reservation, ex: Single or Shared. </param>
        /// <param name="usage"> Historical usage details used to calculate the estimated savings. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        internal ConsumptionReservationRecommendationDetails(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string sku, string currency, ConsumptionResourceProperties properties, string resourceGroup, ConsumptionSavingsProperties savings, string scope, ConsumptionUsageProperties usage, ETag? etag, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Sku = sku;
            Currency = currency;
            Properties = properties;
            ResourceGroup = resourceGroup;
            Savings = savings;
            Scope = scope;
            Usage = usage;
            ETag = etag;
            Tags = tags;
        }

        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Resource sku. </summary>
        public string Sku { get; }
        /// <summary> An ISO 4217 currency code identifier for the costs and savings. </summary>
        public string Currency { get; }
        /// <summary> Resource specific properties. </summary>
        public ConsumptionResourceProperties Properties { get; }
        /// <summary> Resource Group. </summary>
        public string ResourceGroup { get; }
        /// <summary> Savings information for the recommendation. </summary>
        public ConsumptionSavingsProperties Savings { get; }
        /// <summary> Scope of the reservation, ex: Single or Shared. </summary>
        public string Scope { get; }
        /// <summary> Historical usage details used to calculate the estimated savings. </summary>
        public ConsumptionUsageProperties Usage { get; }
        /// <summary> The etag for the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}