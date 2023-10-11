// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> A collection of IoT Connectors. </summary>
    internal partial class IotConnectorCollection
    {
        /// <summary> Initializes a new instance of IotConnectorCollection. </summary>
        internal IotConnectorCollection()
        {
            Value = new ChangeTrackingList<HealthcareApisIotConnectorData>();
        }

        /// <summary> Initializes a new instance of IotConnectorCollection. </summary>
        /// <param name="nextLink"> The link used to get the next page of IoT Connectors. </param>
        /// <param name="value"> The list of IoT Connectors. </param>
        internal IotConnectorCollection(string nextLink, IReadOnlyList<HealthcareApisIotConnectorData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of IoT Connectors. </summary>
        public string NextLink { get; }
        /// <summary> The list of IoT Connectors. </summary>
        public IReadOnlyList<HealthcareApisIotConnectorData> Value { get; }
    }
}