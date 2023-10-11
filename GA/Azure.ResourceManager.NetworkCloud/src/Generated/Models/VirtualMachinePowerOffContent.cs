// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VirtualMachinePowerOffParameters represents the body of the request to power off virtual machine. </summary>
    public partial class VirtualMachinePowerOffContent
    {
        /// <summary> Initializes a new instance of VirtualMachinePowerOffContent. </summary>
        public VirtualMachinePowerOffContent()
        {
        }

        /// <summary> The indicator of whether to skip the graceful OS shutdown and power off the virtual machine immediately. </summary>
        public SkipShutdown? SkipShutdown { get; set; }
    }
}