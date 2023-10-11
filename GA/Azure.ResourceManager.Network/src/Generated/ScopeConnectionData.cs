// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ScopeConnection data model.
    /// The Scope Connections resource
    /// </summary>
    public partial class ScopeConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of ScopeConnectionData. </summary>
        public ScopeConnectionData()
        {
        }

        /// <summary> Initializes a new instance of ScopeConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tenantId"> Tenant ID. </param>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="connectionState"> Connection State. </param>
        /// <param name="description"> A description of the scope connection. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        internal ScopeConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? tenantId, ResourceIdentifier resourceId, ScopeConnectionState? connectionState, string description, ETag? etag) : base(id, name, resourceType, systemData)
        {
            TenantId = tenantId;
            ResourceId = resourceId;
            ConnectionState = connectionState;
            Description = description;
            ETag = etag;
        }

        /// <summary> Tenant ID. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Connection State. </summary>
        public ScopeConnectionState? ConnectionState { get; }
        /// <summary> A description of the scope connection. </summary>
        public string Description { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
