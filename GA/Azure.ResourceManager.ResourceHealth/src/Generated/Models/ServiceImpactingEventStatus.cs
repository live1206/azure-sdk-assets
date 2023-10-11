// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Status of the service impacting event. </summary>
    internal partial class ServiceImpactingEventStatus
    {
        /// <summary> Initializes a new instance of ServiceImpactingEventStatus. </summary>
        internal ServiceImpactingEventStatus()
        {
        }

        /// <summary> Initializes a new instance of ServiceImpactingEventStatus. </summary>
        /// <param name="value"> Current status of the event. </param>
        internal ServiceImpactingEventStatus(string value)
        {
            Value = value;
        }

        /// <summary> Current status of the event. </summary>
        public string Value { get; }
    }
}