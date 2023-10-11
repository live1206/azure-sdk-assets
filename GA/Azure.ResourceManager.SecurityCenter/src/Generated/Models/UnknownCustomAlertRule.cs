// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The UnknownCustomAlertRule. </summary>
    internal partial class UnknownCustomAlertRule : CustomAlertRule
    {
        /// <summary> Initializes a new instance of UnknownCustomAlertRule. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        internal UnknownCustomAlertRule(string displayName, string description, bool isEnabled, string ruleType) : base(displayName, description, isEnabled, ruleType)
        {
            RuleType = ruleType ?? "Unknown";
        }
    }
}