// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Properties of site details provided during the time of site creation. </summary>
    internal partial class FabricCreationProperties
    {
        /// <summary> Initializes a new instance of FabricCreationProperties. </summary>
        public FabricCreationProperties()
        {
        }

        /// <summary>
        /// Fabric provider specific creation input.
        /// Please note <see cref="FabricSpecificCreationContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SiteRecoveryFabricProviderCreationContent"/>, <see cref="InMageRcmFabricCreationContent"/> and <see cref="VMwareV2FabricCreationContent"/>.
        /// </summary>
        public FabricSpecificCreationContent CustomDetails { get; set; }
    }
}