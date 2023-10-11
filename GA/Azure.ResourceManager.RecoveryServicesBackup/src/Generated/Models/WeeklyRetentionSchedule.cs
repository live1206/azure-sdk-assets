// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Weekly retention schedule. </summary>
    public partial class WeeklyRetentionSchedule
    {
        /// <summary> Initializes a new instance of WeeklyRetentionSchedule. </summary>
        public WeeklyRetentionSchedule()
        {
            DaysOfTheWeek = new ChangeTrackingList<BackupDayOfWeek>();
            RetentionTimes = new ChangeTrackingList<DateTimeOffset>();
        }

        /// <summary> Initializes a new instance of WeeklyRetentionSchedule. </summary>
        /// <param name="daysOfTheWeek"> List of days of week for weekly retention policy. </param>
        /// <param name="retentionTimes"> Retention times of retention policy. </param>
        /// <param name="retentionDuration"> Retention duration of retention Policy. </param>
        internal WeeklyRetentionSchedule(IList<BackupDayOfWeek> daysOfTheWeek, IList<DateTimeOffset> retentionTimes, RetentionDuration retentionDuration)
        {
            DaysOfTheWeek = daysOfTheWeek;
            RetentionTimes = retentionTimes;
            RetentionDuration = retentionDuration;
        }

        /// <summary> List of days of week for weekly retention policy. </summary>
        public IList<BackupDayOfWeek> DaysOfTheWeek { get; }
        /// <summary> Retention times of retention policy. </summary>
        public IList<DateTimeOffset> RetentionTimes { get; }
        /// <summary> Retention duration of retention Policy. </summary>
        public RetentionDuration RetentionDuration { get; set; }
    }
}