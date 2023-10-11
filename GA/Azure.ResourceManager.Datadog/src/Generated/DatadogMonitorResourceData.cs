// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Datadog.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Datadog
{
    /// <summary> A class representing the DatadogMonitorResource data model. </summary>
    public partial class DatadogMonitorResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DatadogMonitorResourceData. </summary>
        /// <param name="location"> The location. </param>
        public DatadogMonitorResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DatadogMonitorResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"></param>
        /// <param name="properties"> Properties specific to the monitor resource. </param>
        /// <param name="identity"> Gets or sets the identity. Current supported identity types: SystemAssigned, UserAssigned. </param>
        internal DatadogMonitorResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceSku sku, MonitorProperties properties, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Properties = properties;
            Identity = identity;
        }

        /// <summary> Gets or sets the sku. </summary>
        internal ResourceSku Sku { get; set; }
        /// <summary> Name of the SKU. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new ResourceSku(value);
        }

        /// <summary> Properties specific to the monitor resource. </summary>
        public MonitorProperties Properties { get; set; }
        /// <summary> Gets or sets the identity. Current supported identity types: SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}