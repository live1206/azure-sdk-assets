// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A class representing the TimeSeriesDatabaseConnection data model.
    /// Describes a time series database connection resource.
    /// </summary>
    public partial class TimeSeriesDatabaseConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of TimeSeriesDatabaseConnectionData. </summary>
        public TimeSeriesDatabaseConnectionData()
        {
        }

        /// <summary> Initializes a new instance of TimeSeriesDatabaseConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of a specific time series database connection.
        /// Please note <see cref="TimeSeriesDatabaseConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataExplorerConnectionProperties"/>.
        /// </param>
        internal TimeSeriesDatabaseConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TimeSeriesDatabaseConnectionProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// Properties of a specific time series database connection.
        /// Please note <see cref="TimeSeriesDatabaseConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataExplorerConnectionProperties"/>.
        /// </summary>
        public TimeSeriesDatabaseConnectionProperties Properties { get; set; }
    }
}