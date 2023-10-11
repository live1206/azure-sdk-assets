// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Storage account custom input.
    /// Please note <see cref="StorageAccountCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ExistingStorageAccount"/>.
    /// </summary>
    public abstract partial class StorageAccountCustomDetails
    {
        /// <summary> Initializes a new instance of StorageAccountCustomDetails. </summary>
        protected StorageAccountCustomDetails()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountCustomDetails. </summary>
        /// <param name="resourceType"> The class type. </param>
        internal StorageAccountCustomDetails(string resourceType)
        {
            ResourceType = resourceType;
        }

        /// <summary> The class type. </summary>
        internal string ResourceType { get; set; }
    }
}