// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A private endpoint connection under a server. </summary>
    public partial class SqlServerPrivateEndpointConnection
    {
        /// <summary> Initializes a new instance of SqlServerPrivateEndpointConnection. </summary>
        internal SqlServerPrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of SqlServerPrivateEndpointConnection. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="properties"> Private endpoint connection properties. </param>
        internal SqlServerPrivateEndpointConnection(ResourceIdentifier id, ServerPrivateEndpointConnectionProperties properties)
        {
            Id = id;
            Properties = properties;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Private endpoint connection properties. </summary>
        public ServerPrivateEndpointConnectionProperties Properties { get; }
    }
}
