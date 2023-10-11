// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Probe of the application gateway. </summary>
    public partial class ApplicationGatewayProbe : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayProbe. </summary>
        public ApplicationGatewayProbe()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayProbe. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="protocol"> The protocol used for the probe. </param>
        /// <param name="host"> Host name to send the probe to. </param>
        /// <param name="path"> Relative path of probe. Valid path starts from '/'. Probe is sent to &lt;Protocol&gt;://&lt;host&gt;:&lt;port&gt;&lt;path&gt;. </param>
        /// <param name="intervalInSeconds"> The probing interval in seconds. This is the time interval between two consecutive probes. Acceptable values are from 1 second to 86400 seconds. </param>
        /// <param name="timeoutInSeconds"> The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds. </param>
        /// <param name="unhealthyThreshold"> The probe retry count. Backend server is marked down after consecutive probe failure count reaches UnhealthyThreshold. Acceptable values are from 1 second to 20. </param>
        /// <param name="pickHostNameFromBackendHttpSettings"> Whether the host header should be picked from the backend http settings. Default value is false. </param>
        /// <param name="pickHostNameFromBackendSettings"> Whether the server name indication should be picked from the backend settings for Tls protocol. Default value is false. </param>
        /// <param name="minServers"> Minimum number of servers that are always marked healthy. Default value is 0. </param>
        /// <param name="match"> Criterion for classifying a healthy probe response. </param>
        /// <param name="provisioningState"> The provisioning state of the probe resource. </param>
        /// <param name="port"> Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from http settings will be used. This property is valid for Basic, Standard_v2 and WAF_v2 only. </param>
        internal ApplicationGatewayProbe(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, ApplicationGatewayProtocol? protocol, string host, string path, int? intervalInSeconds, int? timeoutInSeconds, int? unhealthyThreshold, bool? pickHostNameFromBackendHttpSettings, bool? pickHostNameFromBackendSettings, int? minServers, ApplicationGatewayProbeHealthResponseMatch match, NetworkProvisioningState? provisioningState, int? port) : base(id, name, resourceType)
        {
            ETag = etag;
            Protocol = protocol;
            Host = host;
            Path = path;
            IntervalInSeconds = intervalInSeconds;
            TimeoutInSeconds = timeoutInSeconds;
            UnhealthyThreshold = unhealthyThreshold;
            PickHostNameFromBackendHttpSettings = pickHostNameFromBackendHttpSettings;
            PickHostNameFromBackendSettings = pickHostNameFromBackendSettings;
            MinServers = minServers;
            Match = match;
            ProvisioningState = provisioningState;
            Port = port;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The protocol used for the probe. </summary>
        public ApplicationGatewayProtocol? Protocol { get; set; }
        /// <summary> Host name to send the probe to. </summary>
        public string Host { get; set; }
        /// <summary> Relative path of probe. Valid path starts from '/'. Probe is sent to &lt;Protocol&gt;://&lt;host&gt;:&lt;port&gt;&lt;path&gt;. </summary>
        public string Path { get; set; }
        /// <summary> The probing interval in seconds. This is the time interval between two consecutive probes. Acceptable values are from 1 second to 86400 seconds. </summary>
        public int? IntervalInSeconds { get; set; }
        /// <summary> The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary> The probe retry count. Backend server is marked down after consecutive probe failure count reaches UnhealthyThreshold. Acceptable values are from 1 second to 20. </summary>
        public int? UnhealthyThreshold { get; set; }
        /// <summary> Whether the host header should be picked from the backend http settings. Default value is false. </summary>
        public bool? PickHostNameFromBackendHttpSettings { get; set; }
        /// <summary> Whether the server name indication should be picked from the backend settings for Tls protocol. Default value is false. </summary>
        public bool? PickHostNameFromBackendSettings { get; set; }
        /// <summary> Minimum number of servers that are always marked healthy. Default value is 0. </summary>
        public int? MinServers { get; set; }
        /// <summary> Criterion for classifying a healthy probe response. </summary>
        public ApplicationGatewayProbeHealthResponseMatch Match { get; set; }
        /// <summary> The provisioning state of the probe resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from http settings will be used. This property is valid for Basic, Standard_v2 and WAF_v2 only. </summary>
        public int? Port { get; set; }
    }
}