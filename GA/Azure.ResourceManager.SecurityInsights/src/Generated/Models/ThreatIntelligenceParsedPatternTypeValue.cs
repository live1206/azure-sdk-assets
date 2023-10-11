// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes threat kill chain phase entity. </summary>
    public partial class ThreatIntelligenceParsedPatternTypeValue
    {
        /// <summary> Initializes a new instance of ThreatIntelligenceParsedPatternTypeValue. </summary>
        public ThreatIntelligenceParsedPatternTypeValue()
        {
        }

        /// <summary> Initializes a new instance of ThreatIntelligenceParsedPatternTypeValue. </summary>
        /// <param name="valueType"> Type of the value. </param>
        /// <param name="value"> Value of parsed pattern. </param>
        internal ThreatIntelligenceParsedPatternTypeValue(string valueType, string value)
        {
            ValueType = valueType;
            Value = value;
        }

        /// <summary> Type of the value. </summary>
        public string ValueType { get; set; }
        /// <summary> Value of parsed pattern. </summary>
        public string Value { get; set; }
    }
}