// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Object for Capturing DeviceCapacityRequestInfo. </summary>
    public partial class DeviceCapacityRequestContent
    {
        /// <summary> Initializes a new instance of DeviceCapacityRequestContent. </summary>
        /// <param name="vmPlacementQuery"> Array containing the sizes of the VMs for checking if its feasible to create them on the appliance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmPlacementQuery"/> is null. </exception>
        public DeviceCapacityRequestContent(IEnumerable<IList<string>> vmPlacementQuery)
        {
            Argument.AssertNotNull(vmPlacementQuery, nameof(vmPlacementQuery));

            VmPlacementQuery = vmPlacementQuery.ToList();
            VmPlacementResults = new ChangeTrackingList<VmPlacementRequestResult>();
        }

        /// <summary> Array containing the sizes of the VMs for checking if its feasible to create them on the appliance. </summary>
        public IList<IList<string>> VmPlacementQuery { get; }
        /// <summary> Array of the VMs of the sizes in VmSizes can be provisioned on the appliance. </summary>
        public IList<VmPlacementRequestResult> VmPlacementResults { get; }
    }
}