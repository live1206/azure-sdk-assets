// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Appliance specific details.
    /// Please note <see cref="SiteRecoveryApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
    /// </summary>
    public abstract partial class SiteRecoveryApplianceSpecificDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryApplianceSpecificDetails. </summary>
        protected SiteRecoveryApplianceSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryApplianceSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal SiteRecoveryApplianceSpecificDetails(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        internal string InstanceType { get; set; }
    }
}