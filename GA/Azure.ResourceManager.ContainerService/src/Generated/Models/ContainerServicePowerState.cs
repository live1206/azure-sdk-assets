// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Describes the Power State of the cluster. </summary>
    internal partial class ContainerServicePowerState
    {
        /// <summary> Initializes a new instance of ContainerServicePowerState. </summary>
        public ContainerServicePowerState()
        {
        }

        /// <summary> Initializes a new instance of ContainerServicePowerState. </summary>
        /// <param name="code"> Tells whether the cluster is Running or Stopped. </param>
        internal ContainerServicePowerState(ContainerServiceStateCode? code)
        {
            Code = code;
        }

        /// <summary> Tells whether the cluster is Running or Stopped. </summary>
        public ContainerServiceStateCode? Code { get; set; }
    }
}