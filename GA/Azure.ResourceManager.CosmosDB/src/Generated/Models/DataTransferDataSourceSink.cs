// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary>
    /// Base class for all DataTransfer source/sink
    /// Please note <see cref="DataTransferDataSourceSink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureBlobDataTransferDataSourceSink"/>, <see cref="CosmosCassandraDataTransferDataSourceSink"/>, <see cref="CosmosMongoDataTransferDataSourceSink"/> and <see cref="CosmosSqlDataTransferDataSourceSink"/>.
    /// </summary>
    public abstract partial class DataTransferDataSourceSink
    {
        /// <summary> Initializes a new instance of DataTransferDataSourceSink. </summary>
        protected DataTransferDataSourceSink()
        {
        }

        /// <summary> Initializes a new instance of DataTransferDataSourceSink. </summary>
        /// <param name="component"></param>
        internal DataTransferDataSourceSink(DataTransferComponent component)
        {
            Component = component;
        }

        /// <summary> Gets or sets the component. </summary>
        internal DataTransferComponent Component { get; set; }
    }
}