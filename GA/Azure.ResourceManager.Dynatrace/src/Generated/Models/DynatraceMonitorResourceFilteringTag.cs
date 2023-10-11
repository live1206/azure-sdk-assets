// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> The definition of a filtering tag. Filtering tags are used for capturing resources and include/exclude them from being monitored. </summary>
    public partial class DynatraceMonitorResourceFilteringTag
    {
        /// <summary> Initializes a new instance of DynatraceMonitorResourceFilteringTag. </summary>
        public DynatraceMonitorResourceFilteringTag()
        {
        }

        /// <summary> Initializes a new instance of DynatraceMonitorResourceFilteringTag. </summary>
        /// <param name="name"> The name (also known as the key) of the tag. </param>
        /// <param name="value"> The value of the tag. </param>
        /// <param name="action"> Valid actions for a filtering tag. Exclusion takes priority over inclusion. </param>
        internal DynatraceMonitorResourceFilteringTag(string name, string value, DynatraceMonitorResourceTagAction? action)
        {
            Name = name;
            Value = value;
            Action = action;
        }

        /// <summary> The name (also known as the key) of the tag. </summary>
        public string Name { get; set; }
        /// <summary> The value of the tag. </summary>
        public string Value { get; set; }
        /// <summary> Valid actions for a filtering tag. Exclusion takes priority over inclusion. </summary>
        public DynatraceMonitorResourceTagAction? Action { get; set; }
    }
}