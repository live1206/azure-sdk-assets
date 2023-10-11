// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The Advisor configuration data structure. </summary>
    public partial class ConfigData : ResourceData
    {
        /// <summary> Initializes a new instance of ConfigData. </summary>
        public ConfigData()
        {
            Digests = new ChangeTrackingList<DigestConfig>();
        }

        /// <summary> Initializes a new instance of ConfigData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="exclude"> Exclude the resource from Advisor evaluations. Valid values: False (default) or True. </param>
        /// <param name="lowCpuThreshold"> Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5 (default), 10, 15 or 20. </param>
        /// <param name="digests"> Advisor digest configuration. Valid only for subscriptions. </param>
        internal ConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? exclude, CpuThreshold? lowCpuThreshold, IList<DigestConfig> digests) : base(id, name, resourceType, systemData)
        {
            Exclude = exclude;
            LowCpuThreshold = lowCpuThreshold;
            Digests = digests;
        }

        /// <summary> Exclude the resource from Advisor evaluations. Valid values: False (default) or True. </summary>
        public bool? Exclude { get; set; }
        /// <summary> Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5 (default), 10, 15 or 20. </summary>
        public CpuThreshold? LowCpuThreshold { get; set; }
        /// <summary> Advisor digest configuration. Valid only for subscriptions. </summary>
        public IList<DigestConfig> Digests { get; }
    }
}