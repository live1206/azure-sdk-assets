// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt disk input for update. </summary>
    public partial class VMwareCbtUpdateDiskContent
    {
        /// <summary> Initializes a new instance of VMwareCbtUpdateDiskContent. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/> is null. </exception>
        public VMwareCbtUpdateDiskContent(string diskId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));

            DiskId = diskId;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The target disk name. </summary>
        public string TargetDiskName { get; set; }
        /// <summary> A value indicating whether the disk is the OS disk. </summary>
        public string IsOSDisk { get; set; }
    }
}