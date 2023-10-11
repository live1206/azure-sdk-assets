// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The session host configuration for updating agent, monitoring agent, and stack component. </summary>
    public partial class SessionHostAgentUpdateProperties
    {
        /// <summary> Initializes a new instance of SessionHostAgentUpdateProperties. </summary>
        public SessionHostAgentUpdateProperties()
        {
            MaintenanceWindows = new ChangeTrackingList<SessionHostMaintenanceWindowProperties>();
        }

        /// <summary> Initializes a new instance of SessionHostAgentUpdateProperties. </summary>
        /// <param name="updateType"> The type of maintenance for session host components. </param>
        /// <param name="doesUseSessionHostLocalTime"> Whether to use localTime of the virtual machine. </param>
        /// <param name="maintenanceWindowTimeZone"> Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true. </param>
        /// <param name="maintenanceWindows"> List of maintenance windows. Maintenance windows are 2 hours long. </param>
        internal SessionHostAgentUpdateProperties(SessionHostComponentUpdateType? updateType, bool? doesUseSessionHostLocalTime, string maintenanceWindowTimeZone, IList<SessionHostMaintenanceWindowProperties> maintenanceWindows)
        {
            UpdateType = updateType;
            DoesUseSessionHostLocalTime = doesUseSessionHostLocalTime;
            MaintenanceWindowTimeZone = maintenanceWindowTimeZone;
            MaintenanceWindows = maintenanceWindows;
        }

        /// <summary> The type of maintenance for session host components. </summary>
        public SessionHostComponentUpdateType? UpdateType { get; set; }
        /// <summary> Whether to use localTime of the virtual machine. </summary>
        public bool? DoesUseSessionHostLocalTime { get; set; }
        /// <summary> Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true. </summary>
        public string MaintenanceWindowTimeZone { get; set; }
        /// <summary> List of maintenance windows. Maintenance windows are 2 hours long. </summary>
        public IList<SessionHostMaintenanceWindowProperties> MaintenanceWindows { get; }
    }
}