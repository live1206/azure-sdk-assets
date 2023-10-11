// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Maintenance window starting hour and day of week. </summary>
    public partial class MaintenanceWindowPatchProperties
    {
        /// <summary> Initializes a new instance of MaintenanceWindowPatchProperties. </summary>
        public MaintenanceWindowPatchProperties()
        {
        }

        /// <summary> Initializes a new instance of MaintenanceWindowPatchProperties. </summary>
        /// <param name="hour"> The update start hour of the day. (0 - 23). </param>
        /// <param name="dayOfWeek"> Day of the week. </param>
        internal MaintenanceWindowPatchProperties(int? hour, DesktopVirtualizationDayOfWeek? dayOfWeek)
        {
            Hour = hour;
            DayOfWeek = dayOfWeek;
        }

        /// <summary> The update start hour of the day. (0 - 23). </summary>
        public int? Hour { get; set; }
        /// <summary> Day of the week. </summary>
        public DesktopVirtualizationDayOfWeek? DayOfWeek { get; set; }
    }
}