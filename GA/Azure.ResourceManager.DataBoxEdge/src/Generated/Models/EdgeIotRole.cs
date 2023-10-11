// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Compute role. </summary>
    public partial class EdgeIotRole : DataBoxEdgeRoleData
    {
        /// <summary> Initializes a new instance of EdgeIotRole. </summary>
        public EdgeIotRole()
        {
            ShareMappings = new ChangeTrackingList<DataBoxEdgeMountPointMap>();
            Kind = DataBoxEdgeRoleType.IoT;
        }

        /// <summary> Initializes a new instance of EdgeIotRole. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Role type. </param>
        /// <param name="hostPlatform"> Host OS supported by the IoT role. </param>
        /// <param name="iotDeviceDetails"> IoT device metadata to which data box edge device needs to be connected. </param>
        /// <param name="iotEdgeDeviceDetails"> IoT edge device to which the IoT role needs to be configured. </param>
        /// <param name="shareMappings"> Mount points of shares in role(s). </param>
        /// <param name="iotEdgeAgentInfo"> Iot edge agent details to download the agent and bootstrap iot runtime. </param>
        /// <param name="hostPlatformType"> Platform where the Iot runtime is hosted. </param>
        /// <param name="computeResource"> Resource allocation. </param>
        /// <param name="roleStatus"> Role status. </param>
        internal EdgeIotRole(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataBoxEdgeRoleType kind, DataBoxEdgeOSPlatformType? hostPlatform, EdgeIotDeviceInfo iotDeviceDetails, EdgeIotDeviceInfo iotEdgeDeviceDetails, IList<DataBoxEdgeMountPointMap> shareMappings, IotEdgeAgentInfo iotEdgeAgentInfo, HostPlatformType? hostPlatformType, EdgeComputeResourceInfo computeResource, DataBoxEdgeRoleStatus? roleStatus) : base(id, name, resourceType, systemData, kind)
        {
            HostPlatform = hostPlatform;
            IotDeviceDetails = iotDeviceDetails;
            IotEdgeDeviceDetails = iotEdgeDeviceDetails;
            ShareMappings = shareMappings;
            IotEdgeAgentInfo = iotEdgeAgentInfo;
            HostPlatformType = hostPlatformType;
            ComputeResource = computeResource;
            RoleStatus = roleStatus;
            Kind = kind;
        }

        /// <summary> Host OS supported by the IoT role. </summary>
        public DataBoxEdgeOSPlatformType? HostPlatform { get; set; }
        /// <summary> IoT device metadata to which data box edge device needs to be connected. </summary>
        public EdgeIotDeviceInfo IotDeviceDetails { get; set; }
        /// <summary> IoT edge device to which the IoT role needs to be configured. </summary>
        public EdgeIotDeviceInfo IotEdgeDeviceDetails { get; set; }
        /// <summary> Mount points of shares in role(s). </summary>
        public IList<DataBoxEdgeMountPointMap> ShareMappings { get; }
        /// <summary> Iot edge agent details to download the agent and bootstrap iot runtime. </summary>
        public IotEdgeAgentInfo IotEdgeAgentInfo { get; set; }
        /// <summary> Platform where the Iot runtime is hosted. </summary>
        public HostPlatformType? HostPlatformType { get; }
        /// <summary> Resource allocation. </summary>
        public EdgeComputeResourceInfo ComputeResource { get; set; }
        /// <summary> Role status. </summary>
        public DataBoxEdgeRoleStatus? RoleStatus { get; set; }
    }
}