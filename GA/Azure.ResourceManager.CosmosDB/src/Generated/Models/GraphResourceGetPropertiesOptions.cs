// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The GraphResourceGetPropertiesOptions. </summary>
    public partial class GraphResourceGetPropertiesOptions : CosmosDBBaseConfig
    {
        /// <summary> Initializes a new instance of GraphResourceGetPropertiesOptions. </summary>
        public GraphResourceGetPropertiesOptions()
        {
        }

        /// <summary> Initializes a new instance of GraphResourceGetPropertiesOptions. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal GraphResourceGetPropertiesOptions(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}
