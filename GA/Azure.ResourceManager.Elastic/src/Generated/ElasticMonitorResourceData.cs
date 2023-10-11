// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Elastic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Elastic
{
    /// <summary>
    /// A class representing the ElasticMonitorResource data model.
    /// Monitor resource.
    /// </summary>
    public partial class ElasticMonitorResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ElasticMonitorResourceData. </summary>
        /// <param name="location"> The location. </param>
        public ElasticMonitorResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ElasticMonitorResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the monitor resource. </param>
        /// <param name="properties"> Properties of the monitor resource. </param>
        /// <param name="identity"> Identity properties of the monitor resource. Current supported identity types: SystemAssigned. </param>
        internal ElasticMonitorResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceSku sku, MonitorProperties properties, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Properties = properties;
            Identity = identity;
        }

        /// <summary> SKU of the monitor resource. </summary>
        internal ResourceSku Sku { get; set; }
        /// <summary> Name of the SKU. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new ResourceSku(value);
        }

        /// <summary> Properties of the monitor resource. </summary>
        public MonitorProperties Properties { get; set; }
        /// <summary> Identity properties of the monitor resource. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}