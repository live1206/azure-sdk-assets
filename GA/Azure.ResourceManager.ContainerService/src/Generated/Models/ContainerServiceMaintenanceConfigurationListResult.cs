// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List maintenance configurations operation. </summary>
    internal partial class ContainerServiceMaintenanceConfigurationListResult
    {
        /// <summary> Initializes a new instance of ContainerServiceMaintenanceConfigurationListResult. </summary>
        internal ContainerServiceMaintenanceConfigurationListResult()
        {
            Value = new ChangeTrackingList<ContainerServiceMaintenanceConfigurationData>();
        }

        /// <summary> Initializes a new instance of ContainerServiceMaintenanceConfigurationListResult. </summary>
        /// <param name="value"> The list of maintenance configurations. </param>
        /// <param name="nextLink"> The URL to get the next set of maintenance configuration results. </param>
        internal ContainerServiceMaintenanceConfigurationListResult(IReadOnlyList<ContainerServiceMaintenanceConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of maintenance configurations. </summary>
        public IReadOnlyList<ContainerServiceMaintenanceConfigurationData> Value { get; }
        /// <summary> The URL to get the next set of maintenance configuration results. </summary>
        public string NextLink { get; }
    }
}