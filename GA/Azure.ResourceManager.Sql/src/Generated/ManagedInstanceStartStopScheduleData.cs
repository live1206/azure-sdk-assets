// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstanceStartStopSchedule data model.
    /// Managed instance's Start/Stop schedule.
    /// </summary>
    public partial class ManagedInstanceStartStopScheduleData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedInstanceStartStopScheduleData. </summary>
        public ManagedInstanceStartStopScheduleData()
        {
            ScheduleList = new ChangeTrackingList<SqlScheduleItem>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceStartStopScheduleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of the schedule. </param>
        /// <param name="timeZoneId"> The time zone of the schedule. </param>
        /// <param name="scheduleList"> Schedule list. </param>
        /// <param name="nextRunAction"> Next action to be executed (Start or Stop). </param>
        /// <param name="nextExecutionTime"> Timestamp when the next action will be executed in the corresponding schedule time zone. </param>
        internal ManagedInstanceStartStopScheduleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string timeZoneId, IList<SqlScheduleItem> scheduleList, string nextRunAction, string nextExecutionTime) : base(id, name, resourceType, systemData)
        {
            Description = description;
            TimeZoneId = timeZoneId;
            ScheduleList = scheduleList;
            NextRunAction = nextRunAction;
            NextExecutionTime = nextExecutionTime;
        }

        /// <summary> The description of the schedule. </summary>
        public string Description { get; set; }
        /// <summary> The time zone of the schedule. </summary>
        public string TimeZoneId { get; set; }
        /// <summary> Schedule list. </summary>
        public IList<SqlScheduleItem> ScheduleList { get; }
        /// <summary> Next action to be executed (Start or Stop). </summary>
        public string NextRunAction { get; }
        /// <summary> Timestamp when the next action will be executed in the corresponding schedule time zone. </summary>
        public string NextExecutionTime { get; }
    }
}
