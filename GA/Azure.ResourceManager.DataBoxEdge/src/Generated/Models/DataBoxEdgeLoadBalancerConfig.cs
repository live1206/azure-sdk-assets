// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Load balancer configuration. </summary>
    public partial class DataBoxEdgeLoadBalancerConfig
    {
        /// <summary> Initializes a new instance of DataBoxEdgeLoadBalancerConfig. </summary>
        internal DataBoxEdgeLoadBalancerConfig()
        {
        }

        /// <summary> Initializes a new instance of DataBoxEdgeLoadBalancerConfig. </summary>
        /// <param name="loadBalancerConfigType"> Load balancer type. </param>
        /// <param name="version"> Load balancer version. </param>
        internal DataBoxEdgeLoadBalancerConfig(string loadBalancerConfigType, string version)
        {
            LoadBalancerConfigType = loadBalancerConfigType;
            Version = version;
        }

        /// <summary> Load balancer type. </summary>
        public string LoadBalancerConfigType { get; }
        /// <summary> Load balancer version. </summary>
        public string Version { get; }
    }
}