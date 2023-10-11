// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Group specific to the update configuration. </summary>
    public partial class SoftwareUpdateConfigurationTargetProperties
    {
        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationTargetProperties. </summary>
        public SoftwareUpdateConfigurationTargetProperties()
        {
            AzureQueries = new ChangeTrackingList<AzureQueryProperties>();
            NonAzureQueries = new ChangeTrackingList<NonAzureQueryProperties>();
        }

        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationTargetProperties. </summary>
        /// <param name="azureQueries"> List of Azure queries in the software update configuration. </param>
        /// <param name="nonAzureQueries"> List of non Azure queries in the software update configuration. </param>
        internal SoftwareUpdateConfigurationTargetProperties(IList<AzureQueryProperties> azureQueries, IList<NonAzureQueryProperties> nonAzureQueries)
        {
            AzureQueries = azureQueries;
            NonAzureQueries = nonAzureQueries;
        }

        /// <summary> List of Azure queries in the software update configuration. </summary>
        public IList<AzureQueryProperties> AzureQueries { get; }
        /// <summary> List of non Azure queries in the software update configuration. </summary>
        public IList<NonAzureQueryProperties> NonAzureQueries { get; }
    }
}