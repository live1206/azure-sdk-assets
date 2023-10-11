// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the DataWarehouseUserActivity data model.
    /// User activities of a data warehouse
    /// </summary>
    public partial class DataWarehouseUserActivityData : ResourceData
    {
        /// <summary> Initializes a new instance of DataWarehouseUserActivityData. </summary>
        public DataWarehouseUserActivityData()
        {
        }

        /// <summary> Initializes a new instance of DataWarehouseUserActivityData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="activeQueriesCount"> Count of running and suspended queries. </param>
        internal DataWarehouseUserActivityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? activeQueriesCount) : base(id, name, resourceType, systemData)
        {
            ActiveQueriesCount = activeQueriesCount;
        }

        /// <summary> Count of running and suspended queries. </summary>
        public int? ActiveQueriesCount { get; }
    }
}
