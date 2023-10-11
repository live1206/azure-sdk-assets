// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownGroupTaskDetails. </summary>
    internal partial class UnknownGroupTaskDetails : SiteRecoveryGroupTaskDetails
    {
        /// <summary> Initializes a new instance of UnknownGroupTaskDetails. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="childTasks"> The child tasks. </param>
        internal UnknownGroupTaskDetails(string instanceType, IReadOnlyList<AsrTask> childTasks) : base(instanceType, childTasks)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}