// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Operation Extended Info
    /// Please note <see cref="DataProtectionOperationExtendedInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataProtectionOperationJobExtendedInfo"/>.
    /// </summary>
    public abstract partial class DataProtectionOperationExtendedInfo
    {
        /// <summary> Initializes a new instance of DataProtectionOperationExtendedInfo. </summary>
        protected DataProtectionOperationExtendedInfo()
        {
        }

        /// <summary> Initializes a new instance of DataProtectionOperationExtendedInfo. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal DataProtectionOperationExtendedInfo(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </summary>
        internal string ObjectType { get; set; }
    }
}