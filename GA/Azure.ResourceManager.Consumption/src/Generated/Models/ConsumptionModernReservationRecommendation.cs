// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Modern reservation recommendation. </summary>
    public partial class ConsumptionModernReservationRecommendation : ConsumptionReservationRecommendation
    {
        /// <summary> Initializes a new instance of ConsumptionModernReservationRecommendation. </summary>
        internal ConsumptionModernReservationRecommendation()
        {
            SkuProperties = new ChangeTrackingList<ConsumptionSkuProperty>();
            Kind = ReservationRecommendationKind.Modern;
        }

        /// <summary> Initializes a new instance of ConsumptionModernReservationRecommendation. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of reservation recommendation. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="sku"> Resource sku. </param>
        /// <param name="locationPropertiesLocation"> Resource Location. </param>
        /// <param name="lookBackPeriod"> The number of days of usage to look back for recommendation. </param>
        /// <param name="instanceFlexibilityRatio"> The instance Flexibility Ratio. </param>
        /// <param name="instanceFlexibilityGroup"> The instance Flexibility Group. </param>
        /// <param name="normalizedSize"> The normalized Size. </param>
        /// <param name="recommendedQuantityNormalized"> The recommended Quantity Normalized. </param>
        /// <param name="meterId"> The meter id (GUID). </param>
        /// <param name="term"> RI recommendations in one or three year terms. </param>
        /// <param name="costWithNoReservedInstances"> The total amount of cost without reserved instances. </param>
        /// <param name="recommendedQuantity"> Recommended quality for reserved instances. </param>
        /// <param name="totalCostWithReservedInstances"> The total amount of cost with reserved instances. </param>
        /// <param name="netSavings"> Total estimated savings with reserved instances. </param>
        /// <param name="firstUsageOn"> The usage date for looking back. </param>
        /// <param name="scope"> Shared or single recommendation. </param>
        /// <param name="skuProperties"> List of sku properties. </param>
        /// <param name="skuName"> This is the ARM Sku name. </param>
        internal ConsumptionModernReservationRecommendation(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ReservationRecommendationKind kind, ETag? etag, IReadOnlyDictionary<string, string> tags, AzureLocation? location, string sku, string locationPropertiesLocation, int? lookBackPeriod, float? instanceFlexibilityRatio, string instanceFlexibilityGroup, string normalizedSize, float? recommendedQuantityNormalized, Guid? meterId, string term, ConsumptionAmount costWithNoReservedInstances, decimal? recommendedQuantity, ConsumptionAmount totalCostWithReservedInstances, ConsumptionAmount netSavings, DateTimeOffset? firstUsageOn, string scope, IReadOnlyList<ConsumptionSkuProperty> skuProperties, string skuName) : base(id, name, resourceType, systemData, kind, etag, tags, location, sku)
        {
            LocationPropertiesLocation = locationPropertiesLocation;
            LookBackPeriod = lookBackPeriod;
            InstanceFlexibilityRatio = instanceFlexibilityRatio;
            InstanceFlexibilityGroup = instanceFlexibilityGroup;
            NormalizedSize = normalizedSize;
            RecommendedQuantityNormalized = recommendedQuantityNormalized;
            MeterId = meterId;
            Term = term;
            CostWithNoReservedInstances = costWithNoReservedInstances;
            RecommendedQuantity = recommendedQuantity;
            TotalCostWithReservedInstances = totalCostWithReservedInstances;
            NetSavings = netSavings;
            FirstUsageOn = firstUsageOn;
            Scope = scope;
            SkuProperties = skuProperties;
            SkuName = skuName;
            Kind = kind;
        }

        /// <summary> Resource Location. </summary>
        public string LocationPropertiesLocation { get; }
        /// <summary> The number of days of usage to look back for recommendation. </summary>
        public int? LookBackPeriod { get; }
        /// <summary> The instance Flexibility Ratio. </summary>
        public float? InstanceFlexibilityRatio { get; }
        /// <summary> The instance Flexibility Group. </summary>
        public string InstanceFlexibilityGroup { get; }
        /// <summary> The normalized Size. </summary>
        public string NormalizedSize { get; }
        /// <summary> The recommended Quantity Normalized. </summary>
        public float? RecommendedQuantityNormalized { get; }
        /// <summary> The meter id (GUID). </summary>
        public Guid? MeterId { get; }
        /// <summary> RI recommendations in one or three year terms. </summary>
        public string Term { get; }
        /// <summary> The total amount of cost without reserved instances. </summary>
        public ConsumptionAmount CostWithNoReservedInstances { get; }
        /// <summary> Recommended quality for reserved instances. </summary>
        public decimal? RecommendedQuantity { get; }
        /// <summary> The total amount of cost with reserved instances. </summary>
        public ConsumptionAmount TotalCostWithReservedInstances { get; }
        /// <summary> Total estimated savings with reserved instances. </summary>
        public ConsumptionAmount NetSavings { get; }
        /// <summary> The usage date for looking back. </summary>
        public DateTimeOffset? FirstUsageOn { get; }
        /// <summary> Shared or single recommendation. </summary>
        public string Scope { get; }
        /// <summary> List of sku properties. </summary>
        public IReadOnlyList<ConsumptionSkuProperty> SkuProperties { get; }
        /// <summary> This is the ARM Sku name. </summary>
        public string SkuName { get; }
    }
}
