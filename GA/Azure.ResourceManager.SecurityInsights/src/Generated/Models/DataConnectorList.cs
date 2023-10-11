// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List all the data connectors. </summary>
    internal partial class DataConnectorList
    {
        /// <summary> Initializes a new instance of DataConnectorList. </summary>
        /// <param name="value">
        /// Array of data connectors.
        /// Please note <see cref="SecurityInsightsDataConnectorData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsAwsCloudTrailDataConnector"/>, <see cref="SecurityInsightsAadDataConnector"/>, <see cref="SecurityInsightsAatpDataConnector"/>, <see cref="SecurityInsightsAscDataConnector"/>, <see cref="McasDataConnector"/>, <see cref="MdatpDataConnector"/>, <see cref="SecurityInsightsOfficeDataConnector"/> and <see cref="SecurityInsightsTIDataConnector"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataConnectorList(IEnumerable<SecurityInsightsDataConnectorData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DataConnectorList. </summary>
        /// <param name="nextLink"> URL to fetch the next set of data connectors. </param>
        /// <param name="value">
        /// Array of data connectors.
        /// Please note <see cref="SecurityInsightsDataConnectorData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsAwsCloudTrailDataConnector"/>, <see cref="SecurityInsightsAadDataConnector"/>, <see cref="SecurityInsightsAatpDataConnector"/>, <see cref="SecurityInsightsAscDataConnector"/>, <see cref="McasDataConnector"/>, <see cref="MdatpDataConnector"/>, <see cref="SecurityInsightsOfficeDataConnector"/> and <see cref="SecurityInsightsTIDataConnector"/>.
        /// </param>
        internal DataConnectorList(string nextLink, IReadOnlyList<SecurityInsightsDataConnectorData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to fetch the next set of data connectors. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Array of data connectors.
        /// Please note <see cref="SecurityInsightsDataConnectorData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsAwsCloudTrailDataConnector"/>, <see cref="SecurityInsightsAadDataConnector"/>, <see cref="SecurityInsightsAatpDataConnector"/>, <see cref="SecurityInsightsAscDataConnector"/>, <see cref="McasDataConnector"/>, <see cref="MdatpDataConnector"/>, <see cref="SecurityInsightsOfficeDataConnector"/> and <see cref="SecurityInsightsTIDataConnector"/>.
        /// </summary>
        public IReadOnlyList<SecurityInsightsDataConnectorData> Value { get; }
    }
}