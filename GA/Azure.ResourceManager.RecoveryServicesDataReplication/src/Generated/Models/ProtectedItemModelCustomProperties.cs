// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary>
    /// Protected item model custom properties.
    /// Please note <see cref="ProtectedItemModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="HyperVToAzStackHciProtectedItemModelCustomProperties"/>, <see cref="GeneralProtectedItemModelCustomProperties"/> and <see cref="VMwareToAzStackHciProtectedItemModelCustomProperties"/>.
    /// </summary>
    public abstract partial class ProtectedItemModelCustomProperties
    {
        /// <summary> Initializes a new instance of ProtectedItemModelCustomProperties. </summary>
        protected ProtectedItemModelCustomProperties()
        {
        }

        /// <summary> Initializes a new instance of ProtectedItemModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal ProtectedItemModelCustomProperties(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets or sets the instance type. </summary>
        internal string InstanceType { get; set; }
    }
}