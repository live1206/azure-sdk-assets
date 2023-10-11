// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Recovery Availability Set custom input.
    /// Please note <see cref="RecoveryAvailabilitySetCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ExistingRecoveryAvailabilitySet"/>.
    /// </summary>
    public abstract partial class RecoveryAvailabilitySetCustomDetails
    {
        /// <summary> Initializes a new instance of RecoveryAvailabilitySetCustomDetails. </summary>
        protected RecoveryAvailabilitySetCustomDetails()
        {
        }

        /// <summary> Initializes a new instance of RecoveryAvailabilitySetCustomDetails. </summary>
        /// <param name="resourceType"> The class type. </param>
        internal RecoveryAvailabilitySetCustomDetails(string resourceType)
        {
            ResourceType = resourceType;
        }

        /// <summary> The class type. </summary>
        internal string ResourceType { get; set; }
    }
}