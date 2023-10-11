// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Information of the sku. </summary>
    public partial class DataBoxSkuInformation
    {
        /// <summary> Initializes a new instance of DataBoxSkuInformation. </summary>
        internal DataBoxSkuInformation()
        {
            DataLocationToServiceLocationMap = new ChangeTrackingList<DataLocationToServiceLocationMap>();
            Costs = new ChangeTrackingList<DataBoxSkuCost>();
            ApiVersions = new ChangeTrackingList<string>();
            CountriesWithinCommerceBoundary = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DataBoxSkuInformation. </summary>
        /// <param name="sku"> The Sku. </param>
        /// <param name="isEnabled"> The sku is enabled or not. </param>
        /// <param name="dataLocationToServiceLocationMap"> The map of data location to service location. </param>
        /// <param name="capacity"> Capacity of the Sku. </param>
        /// <param name="costs"> Cost of the Sku. </param>
        /// <param name="apiVersions"> Api versions that support this Sku. </param>
        /// <param name="disabledReason"> Reason why the Sku is disabled. </param>
        /// <param name="disabledReasonMessage"> Message for why the Sku is disabled. </param>
        /// <param name="requiredFeature"> Required feature to access the sku. </param>
        /// <param name="countriesWithinCommerceBoundary"> List of all the Countries in the SKU specific commerce boundary. </param>
        internal DataBoxSkuInformation(DataBoxSku sku, bool? isEnabled, IReadOnlyList<DataLocationToServiceLocationMap> dataLocationToServiceLocationMap, DataBoxSkuCapacity capacity, IReadOnlyList<DataBoxSkuCost> costs, IReadOnlyList<string> apiVersions, SkuDisabledReason? disabledReason, string disabledReasonMessage, string requiredFeature, IReadOnlyList<string> countriesWithinCommerceBoundary)
        {
            Sku = sku;
            IsEnabled = isEnabled;
            DataLocationToServiceLocationMap = dataLocationToServiceLocationMap;
            Capacity = capacity;
            Costs = costs;
            ApiVersions = apiVersions;
            DisabledReason = disabledReason;
            DisabledReasonMessage = disabledReasonMessage;
            RequiredFeature = requiredFeature;
            CountriesWithinCommerceBoundary = countriesWithinCommerceBoundary;
        }

        /// <summary> The Sku. </summary>
        public DataBoxSku Sku { get; }
        /// <summary> The sku is enabled or not. </summary>
        public bool? IsEnabled { get; }
        /// <summary> The map of data location to service location. </summary>
        public IReadOnlyList<DataLocationToServiceLocationMap> DataLocationToServiceLocationMap { get; }
        /// <summary> Capacity of the Sku. </summary>
        public DataBoxSkuCapacity Capacity { get; }
        /// <summary> Cost of the Sku. </summary>
        public IReadOnlyList<DataBoxSkuCost> Costs { get; }
        /// <summary> Api versions that support this Sku. </summary>
        public IReadOnlyList<string> ApiVersions { get; }
        /// <summary> Reason why the Sku is disabled. </summary>
        public SkuDisabledReason? DisabledReason { get; }
        /// <summary> Message for why the Sku is disabled. </summary>
        public string DisabledReasonMessage { get; }
        /// <summary> Required feature to access the sku. </summary>
        public string RequiredFeature { get; }
        /// <summary> List of all the Countries in the SKU specific commerce boundary. </summary>
        public IReadOnlyList<string> CountriesWithinCommerceBoundary { get; }
    }
}