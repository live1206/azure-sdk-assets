// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The custom setup of installing 3rd party components. </summary>
    public partial class SynapseComponentSetup : SynapseCustomSetupBase
    {
        /// <summary> Initializes a new instance of SynapseComponentSetup. </summary>
        /// <param name="componentName"> The name of the 3rd party component. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public SynapseComponentSetup(string componentName)
        {
            Argument.AssertNotNull(componentName, nameof(componentName));

            ComponentName = componentName;
            CustomSetupBaseType = "ComponentSetup";
        }

        /// <summary> Initializes a new instance of SynapseComponentSetup. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="componentName"> The name of the 3rd party component. </param>
        /// <param name="licenseKey">
        /// The license key to activate the component.
        /// Please note <see cref="SynapseSecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseSecureString"/>.
        /// </param>
        internal SynapseComponentSetup(string customSetupBaseType, string componentName, SynapseSecretBase licenseKey) : base(customSetupBaseType)
        {
            ComponentName = componentName;
            LicenseKey = licenseKey;
            CustomSetupBaseType = customSetupBaseType ?? "ComponentSetup";
        }

        /// <summary> The name of the 3rd party component. </summary>
        public string ComponentName { get; set; }
        /// <summary>
        /// The license key to activate the component.
        /// Please note <see cref="SynapseSecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseSecureString"/>.
        /// </summary>
        public SynapseSecretBase LicenseKey { get; set; }
    }
}