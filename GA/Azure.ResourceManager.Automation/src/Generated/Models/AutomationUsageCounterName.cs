// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of usage counter name. </summary>
    public partial class AutomationUsageCounterName
    {
        /// <summary> Initializes a new instance of AutomationUsageCounterName. </summary>
        internal AutomationUsageCounterName()
        {
        }

        /// <summary> Initializes a new instance of AutomationUsageCounterName. </summary>
        /// <param name="value"> Gets or sets the usage counter name. </param>
        /// <param name="localizedValue"> Gets or sets the localized usage counter name. </param>
        internal AutomationUsageCounterName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> Gets or sets the usage counter name. </summary>
        public string Value { get; }
        /// <summary> Gets or sets the localized usage counter name. </summary>
        public string LocalizedValue { get; }
    }
}
