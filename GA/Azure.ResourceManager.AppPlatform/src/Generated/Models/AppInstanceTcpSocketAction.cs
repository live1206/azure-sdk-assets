// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> TCPSocketAction describes an action based on opening a socket. </summary>
    public partial class AppInstanceTcpSocketAction : AppInstanceProbeAction
    {
        /// <summary> Initializes a new instance of AppInstanceTcpSocketAction. </summary>
        public AppInstanceTcpSocketAction()
        {
            ProbeActionType = ProbeActionType.TCPSocketAction;
        }

        /// <summary> Initializes a new instance of AppInstanceTcpSocketAction. </summary>
        /// <param name="probeActionType"> The type of the action to take to perform the health check. </param>
        internal AppInstanceTcpSocketAction(ProbeActionType probeActionType) : base(probeActionType)
        {
            ProbeActionType = probeActionType;
        }
    }
}