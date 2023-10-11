// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Private Endpoint Connection Approval ARM resource. </summary>
    public partial class DataFactoryPrivateEndpointConnectionCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of DataFactoryPrivateEndpointConnectionCreateOrUpdateContent. </summary>
        public DataFactoryPrivateEndpointConnectionCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of DataFactoryPrivateEndpointConnectionCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Core resource properties. </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        internal DataFactoryPrivateEndpointConnectionCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PrivateLinkConnectionApprovalRequest properties, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary> Core resource properties. </summary>
        public PrivateLinkConnectionApprovalRequest Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}