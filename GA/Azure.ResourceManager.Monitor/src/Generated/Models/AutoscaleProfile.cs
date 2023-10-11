// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Autoscale profile. </summary>
    public partial class AutoscaleProfile
    {
        /// <summary> Initializes a new instance of AutoscaleProfile. </summary>
        /// <param name="name"> the name of the profile. </param>
        /// <param name="capacity"> the number of instances that can be used during this profile. </param>
        /// <param name="rules"> the collection of rules that provide the triggers and parameters for the scaling action. A maximum of 10 rules can be specified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="capacity"/> or <paramref name="rules"/> is null. </exception>
        public AutoscaleProfile(string name, MonitorScaleCapacity capacity, IEnumerable<AutoscaleRule> rules)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(capacity, nameof(capacity));
            Argument.AssertNotNull(rules, nameof(rules));

            Name = name;
            Capacity = capacity;
            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of AutoscaleProfile. </summary>
        /// <param name="name"> the name of the profile. </param>
        /// <param name="capacity"> the number of instances that can be used during this profile. </param>
        /// <param name="rules"> the collection of rules that provide the triggers and parameters for the scaling action. A maximum of 10 rules can be specified. </param>
        /// <param name="fixedDate"> the specific date-time for the profile. This element is not used if the Recurrence element is used. </param>
        /// <param name="recurrence"> the repeating times at which this profile begins. This element is not used if the FixedDate element is used. </param>
        internal AutoscaleProfile(string name, MonitorScaleCapacity capacity, IList<AutoscaleRule> rules, MonitorTimeWindow fixedDate, MonitorRecurrence recurrence)
        {
            Name = name;
            Capacity = capacity;
            Rules = rules;
            FixedDate = fixedDate;
            Recurrence = recurrence;
        }

        /// <summary> the name of the profile. </summary>
        public string Name { get; set; }
        /// <summary> the number of instances that can be used during this profile. </summary>
        public MonitorScaleCapacity Capacity { get; set; }
        /// <summary> the collection of rules that provide the triggers and parameters for the scaling action. A maximum of 10 rules can be specified. </summary>
        public IList<AutoscaleRule> Rules { get; }
        /// <summary> the specific date-time for the profile. This element is not used if the Recurrence element is used. </summary>
        public MonitorTimeWindow FixedDate { get; set; }
        /// <summary> the repeating times at which this profile begins. This element is not used if the FixedDate element is used. </summary>
        public MonitorRecurrence Recurrence { get; set; }
    }
}