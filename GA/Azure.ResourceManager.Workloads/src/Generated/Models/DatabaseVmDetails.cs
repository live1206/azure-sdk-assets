// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Database VM details. </summary>
    public partial class DatabaseVmDetails
    {
        /// <summary> Initializes a new instance of DatabaseVmDetails. </summary>
        internal DatabaseVmDetails()
        {
            StorageDetails = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of DatabaseVmDetails. </summary>
        /// <param name="virtualMachineId"></param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="storageDetails"> Storage details of all the Storage Accounts attached to the Database Virtual Machine. For e.g. NFS on AFS Shared Storage. </param>
        internal DatabaseVmDetails(ResourceIdentifier virtualMachineId, SapVirtualInstanceStatus? status, IReadOnlyList<SubResource> storageDetails)
        {
            VirtualMachineId = virtualMachineId;
            Status = status;
            StorageDetails = storageDetails;
        }

        /// <summary> Gets the virtual machine id. </summary>
        public ResourceIdentifier VirtualMachineId { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Storage details of all the Storage Accounts attached to the Database Virtual Machine. For e.g. NFS on AFS Shared Storage. </summary>
        public IReadOnlyList<SubResource> StorageDetails { get; }
    }
}