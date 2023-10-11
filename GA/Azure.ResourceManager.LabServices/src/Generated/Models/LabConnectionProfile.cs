// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Connection profile for how users connect to lab virtual machines. </summary>
    public partial class LabConnectionProfile
    {
        /// <summary> Initializes a new instance of LabConnectionProfile. </summary>
        public LabConnectionProfile()
        {
        }

        /// <summary> Initializes a new instance of LabConnectionProfile. </summary>
        /// <param name="webSshAccess"> The enabled access level for Web Access over SSH. </param>
        /// <param name="webRdpAccess"> The enabled access level for Web Access over RDP. </param>
        /// <param name="clientSshAccess"> The enabled access level for Client Access over SSH. </param>
        /// <param name="clientRdpAccess"> The enabled access level for Client Access over RDP. </param>
        internal LabConnectionProfile(LabVirtualMachineConnectionType? webSshAccess, LabVirtualMachineConnectionType? webRdpAccess, LabVirtualMachineConnectionType? clientSshAccess, LabVirtualMachineConnectionType? clientRdpAccess)
        {
            WebSshAccess = webSshAccess;
            WebRdpAccess = webRdpAccess;
            ClientSshAccess = clientSshAccess;
            ClientRdpAccess = clientRdpAccess;
        }

        /// <summary> The enabled access level for Web Access over SSH. </summary>
        public LabVirtualMachineConnectionType? WebSshAccess { get; set; }
        /// <summary> The enabled access level for Web Access over RDP. </summary>
        public LabVirtualMachineConnectionType? WebRdpAccess { get; set; }
        /// <summary> The enabled access level for Client Access over SSH. </summary>
        public LabVirtualMachineConnectionType? ClientSshAccess { get; set; }
        /// <summary> The enabled access level for Client Access over RDP. </summary>
        public LabVirtualMachineConnectionType? ClientRdpAccess { get; set; }
    }
}