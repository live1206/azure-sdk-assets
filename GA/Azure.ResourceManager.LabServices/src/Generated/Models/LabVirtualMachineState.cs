// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The state of a virtual machine. </summary>
    public enum LabVirtualMachineState
    {
        /// <summary> The VM is currently stopped. </summary>
        Stopped,
        /// <summary> The VM is starting. </summary>
        Starting,
        /// <summary> The VM is running. </summary>
        Running,
        /// <summary> The VM is stopping. </summary>
        Stopping,
        /// <summary> The VM password is being reset. </summary>
        ResettingPassword,
        /// <summary> The VM is being reimaged. </summary>
        Reimaging,
        /// <summary> The VM is being redeployed. </summary>
        Redeploying
    }
}