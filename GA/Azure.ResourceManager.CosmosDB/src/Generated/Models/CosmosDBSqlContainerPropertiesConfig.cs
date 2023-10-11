// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CosmosDBSqlContainerPropertiesConfig. </summary>
    public partial class CosmosDBSqlContainerPropertiesConfig : CosmosDBBaseConfig
    {
        /// <summary> Initializes a new instance of CosmosDBSqlContainerPropertiesConfig. </summary>
        public CosmosDBSqlContainerPropertiesConfig()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBSqlContainerPropertiesConfig. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal CosmosDBSqlContainerPropertiesConfig(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}