// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the ContainerServiceMaintenanceConfiguration data model.
    /// See [planned maintenance](https://docs.microsoft.com/azure/aks/planned-maintenance) for more information about planned maintenance.
    /// </summary>
    public partial class ContainerServiceMaintenanceConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerServiceMaintenanceConfigurationData. </summary>
        public ContainerServiceMaintenanceConfigurationData()
        {
            TimesInWeek = new ChangeTrackingList<ContainerServiceTimeInWeek>();
            NotAllowedTimes = new ChangeTrackingList<ContainerServiceTimeSpan>();
        }

        /// <summary> Initializes a new instance of ContainerServiceMaintenanceConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="timesInWeek"> If two array entries specify the same day of the week, the applied configuration is the union of times in both entries. </param>
        /// <param name="notAllowedTimes"> Time slots on which upgrade is not allowed. </param>
        /// <param name="maintenanceWindow"> Maintenance window for the maintenance configuration. </param>
        internal ContainerServiceMaintenanceConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<ContainerServiceTimeInWeek> timesInWeek, IList<ContainerServiceTimeSpan> notAllowedTimes, ContainerServiceMaintenanceWindow maintenanceWindow) : base(id, name, resourceType, systemData)
        {
            TimesInWeek = timesInWeek;
            NotAllowedTimes = notAllowedTimes;
            MaintenanceWindow = maintenanceWindow;
        }

        /// <summary> If two array entries specify the same day of the week, the applied configuration is the union of times in both entries. </summary>
        public IList<ContainerServiceTimeInWeek> TimesInWeek { get; }
        /// <summary> Time slots on which upgrade is not allowed. </summary>
        public IList<ContainerServiceTimeSpan> NotAllowedTimes { get; }
        /// <summary> Maintenance window for the maintenance configuration. </summary>
        public ContainerServiceMaintenanceWindow MaintenanceWindow { get; set; }
    }
}
