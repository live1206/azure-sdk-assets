// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component feature capability. </summary>
    public partial class ApplicationInsightsComponentFeatureCapability
    {
        /// <summary> Initializes a new instance of ApplicationInsightsComponentFeatureCapability. </summary>
        internal ApplicationInsightsComponentFeatureCapability()
        {
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentFeatureCapability. </summary>
        /// <param name="name"> The name of the capability. </param>
        /// <param name="description"> The description of the capability. </param>
        /// <param name="value"> The value of the capability. </param>
        /// <param name="unit"> The unit of the capability. </param>
        /// <param name="meterId"> The meter used for the capability. </param>
        /// <param name="meterRateFrequency"> The meter rate of the meter. </param>
        internal ApplicationInsightsComponentFeatureCapability(string name, string description, string value, string unit, string meterId, string meterRateFrequency)
        {
            Name = name;
            Description = description;
            Value = value;
            Unit = unit;
            MeterId = meterId;
            MeterRateFrequency = meterRateFrequency;
        }

        /// <summary> The name of the capability. </summary>
        public string Name { get; }
        /// <summary> The description of the capability. </summary>
        public string Description { get; }
        /// <summary> The value of the capability. </summary>
        public string Value { get; }
        /// <summary> The unit of the capability. </summary>
        public string Unit { get; }
        /// <summary> The meter used for the capability. </summary>
        public string MeterId { get; }
        /// <summary> The meter rate of the meter. </summary>
        public string MeterRateFrequency { get; }
    }
}