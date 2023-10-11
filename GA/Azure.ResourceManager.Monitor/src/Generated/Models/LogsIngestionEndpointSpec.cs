// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of the endpoint used for ingesting logs. </summary>
    internal partial class LogsIngestionEndpointSpec
    {
        /// <summary> Initializes a new instance of LogsIngestionEndpointSpec. </summary>
        public LogsIngestionEndpointSpec()
        {
        }

        /// <summary> Initializes a new instance of LogsIngestionEndpointSpec. </summary>
        /// <param name="endpoint"> The endpoint. This property is READ-ONLY. </param>
        internal LogsIngestionEndpointSpec(string endpoint)
        {
            Endpoint = endpoint;
        }

        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string Endpoint { get; }
    }
}