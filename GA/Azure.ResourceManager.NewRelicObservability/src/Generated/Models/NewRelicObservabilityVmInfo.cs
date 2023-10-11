// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Details of VM Resource having NewRelic OneAgent installed. </summary>
    public partial class NewRelicObservabilityVmInfo
    {
        /// <summary> Initializes a new instance of NewRelicObservabilityVmInfo. </summary>
        internal NewRelicObservabilityVmInfo()
        {
        }

        /// <summary> Initializes a new instance of NewRelicObservabilityVmInfo. </summary>
        /// <param name="vmId"> Azure VM resource ID. </param>
        /// <param name="agentVersion"> Version of the NewRelic agent installed on the VM. </param>
        /// <param name="agentStatus"> Status of the NewRelic agent installed on the VM. </param>
        internal NewRelicObservabilityVmInfo(ResourceIdentifier vmId, string agentVersion, string agentStatus)
        {
            VmId = vmId;
            AgentVersion = agentVersion;
            AgentStatus = agentStatus;
        }

        /// <summary> Azure VM resource ID. </summary>
        public ResourceIdentifier VmId { get; }
        /// <summary> Version of the NewRelic agent installed on the VM. </summary>
        public string AgentVersion { get; }
        /// <summary> Status of the NewRelic agent installed on the VM. </summary>
        public string AgentStatus { get; }
    }
}