// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Recurrence object.
    /// Please note <see cref="AlertProcessingRuleRecurrence"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DailyRecurrence"/>, <see cref="AlertProcessingRuleMonthlyRecurrence"/> and <see cref="AlertProcessingRuleWeeklyRecurrence"/>.
    /// </summary>
    public abstract partial class AlertProcessingRuleRecurrence
    {
        /// <summary> Initializes a new instance of AlertProcessingRuleRecurrence. </summary>
        protected AlertProcessingRuleRecurrence()
        {
        }

        /// <summary> Initializes a new instance of AlertProcessingRuleRecurrence. </summary>
        /// <param name="recurrenceType"> Specifies when the recurrence should be applied. </param>
        /// <param name="startOn"> Start time for recurrence. </param>
        /// <param name="endOn"> End time for recurrence. </param>
        internal AlertProcessingRuleRecurrence(RecurrenceType recurrenceType, TimeSpan? startOn, TimeSpan? endOn)
        {
            RecurrenceType = recurrenceType;
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> Specifies when the recurrence should be applied. </summary>
        internal RecurrenceType RecurrenceType { get; set; }
        /// <summary> Start time for recurrence. </summary>
        public TimeSpan? StartOn { get; set; }
        /// <summary> End time for recurrence. </summary>
        public TimeSpan? EndOn { get; set; }
    }
}