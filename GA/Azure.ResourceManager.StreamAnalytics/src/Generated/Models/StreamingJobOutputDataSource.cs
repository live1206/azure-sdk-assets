// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Describes the data source that output will be written to.
    /// Please note <see cref="StreamingJobOutputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="GatewayMessageBusOutputDataSource"/>, <see cref="FunctionOutputDataSource"/>, <see cref="PostgreSQLOutputDataSource"/>, <see cref="DataLakeStoreOutputDataSource"/>, <see cref="EventHubV2OutputDataSource"/>, <see cref="EventHubOutputDataSource"/>, <see cref="ServiceBusQueueOutputDataSource"/>, <see cref="ServiceBusTopicOutputDataSource"/>, <see cref="SynapseOutputDataSource"/>, <see cref="SqlDatabaseOutputDataSource"/>, <see cref="BlobOutputDataSource"/>, <see cref="DocumentDbOutputDataSource"/>, <see cref="TableOutputDataSource"/>, <see cref="PowerBIOutputDataSource"/> and <see cref="RawOutputDatasource"/>.
    /// </summary>
    public abstract partial class StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of StreamingJobOutputDataSource. </summary>
        protected StreamingJobOutputDataSource()
        {
        }

        /// <summary> Initializes a new instance of StreamingJobOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        internal StreamingJobOutputDataSource(string outputDataSourceType)
        {
            OutputDataSourceType = outputDataSourceType;
        }

        /// <summary> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </summary>
        internal string OutputDataSourceType { get; set; }
    }
}