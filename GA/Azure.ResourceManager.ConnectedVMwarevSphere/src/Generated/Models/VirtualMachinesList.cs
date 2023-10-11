// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> List of VirtualMachines. </summary>
    internal partial class VirtualMachinesList
    {
        /// <summary> Initializes a new instance of VirtualMachinesList. </summary>
        /// <param name="value"> Array of VirtualMachines. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachinesList(IEnumerable<VirtualMachineData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of VirtualMachinesList. </summary>
        /// <param name="nextLink"> Url to follow for getting next page of VirtualMachines. </param>
        /// <param name="value"> Array of VirtualMachines. </param>
        internal VirtualMachinesList(string nextLink, IReadOnlyList<VirtualMachineData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Url to follow for getting next page of VirtualMachines. </summary>
        public string NextLink { get; }
        /// <summary> Array of VirtualMachines. </summary>
        public IReadOnlyList<VirtualMachineData> Value { get; }
    }
}