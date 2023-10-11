// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineCordonParameters represents the body of the request to evacuate workloads from node on a bare metal machine. </summary>
    public partial class BareMetalMachineCordonContent
    {
        /// <summary> Initializes a new instance of BareMetalMachineCordonContent. </summary>
        public BareMetalMachineCordonContent()
        {
        }

        /// <summary> The indicator of whether to evacuate the node workload when the bare metal machine is cordoned. </summary>
        public BareMetalMachineEvacuate? Evacuate { get; set; }
    }
}