// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> The UnknownDraModelCustomProperties. </summary>
    internal partial class UnknownDraModelCustomProperties : DraModelCustomProperties
    {
        /// <summary> Initializes a new instance of UnknownDraModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal UnknownDraModelCustomProperties(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}