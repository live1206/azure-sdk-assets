// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The state of a virtual machine. </summary>
    public enum LabState
    {
        /// <summary> The lab is currently in draft (has not been published). </summary>
        Draft,
        /// <summary> The lab is publishing. </summary>
        Publishing,
        /// <summary> The lab is scaling. </summary>
        Scaling,
        /// <summary> The lab is syncing users. </summary>
        Syncing,
        /// <summary> The lab has been published. </summary>
        Published
    }
}