// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Simulate alerts according to this bundles. </summary>
    public partial class SecurityAlertSimulatorBundlesRequestProperties : SecurityAlertSimulatorRequestProperties
    {
        /// <summary> Initializes a new instance of SecurityAlertSimulatorBundlesRequestProperties. </summary>
        public SecurityAlertSimulatorBundlesRequestProperties()
        {
            Bundles = new ChangeTrackingList<SecurityAlertSimulatorBundleType>();
            Kind = SecurityCenterKind.Bundles;
        }

        /// <summary> Bundles list. </summary>
        public IList<SecurityAlertSimulatorBundleType> Bundles { get; }
    }
}