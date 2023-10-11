// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Static definitions of the ProactiveDetection configuration rule (same values for all components). </summary>
    public partial class ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions
    {
        /// <summary> Initializes a new instance of ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions. </summary>
        public ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions()
        {
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions. </summary>
        /// <param name="name"> The rule name. </param>
        /// <param name="displayName"> The rule name as it is displayed in UI. </param>
        /// <param name="description"> The rule description. </param>
        /// <param name="helpUri"> URL which displays additional info about the proactive detection rule. </param>
        /// <param name="isHidden"> A flag indicating whether the rule is hidden (from the UI). </param>
        /// <param name="isEnabledByDefault"> A flag indicating whether the rule is enabled by default. </param>
        /// <param name="isInPreview"> A flag indicating whether the rule is in preview. </param>
        /// <param name="supportsEmailNotifications"> A flag indicating whether email notifications are supported for detections for this rule. </param>
        internal ApplicationInsightsComponentProactiveDetectionConfigurationRuleDefinitions(string name, string displayName, string description, Uri helpUri, bool? isHidden, bool? isEnabledByDefault, bool? isInPreview, bool? supportsEmailNotifications)
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            HelpUri = helpUri;
            IsHidden = isHidden;
            IsEnabledByDefault = isEnabledByDefault;
            IsInPreview = isInPreview;
            SupportsEmailNotifications = supportsEmailNotifications;
        }

        /// <summary> The rule name. </summary>
        public string Name { get; set; }
        /// <summary> The rule name as it is displayed in UI. </summary>
        public string DisplayName { get; set; }
        /// <summary> The rule description. </summary>
        public string Description { get; set; }
        /// <summary> URL which displays additional info about the proactive detection rule. </summary>
        public Uri HelpUri { get; set; }
        /// <summary> A flag indicating whether the rule is hidden (from the UI). </summary>
        public bool? IsHidden { get; set; }
        /// <summary> A flag indicating whether the rule is enabled by default. </summary>
        public bool? IsEnabledByDefault { get; set; }
        /// <summary> A flag indicating whether the rule is in preview. </summary>
        public bool? IsInPreview { get; set; }
        /// <summary> A flag indicating whether email notifications are supported for detections for this rule. </summary>
        public bool? SupportsEmailNotifications { get; set; }
    }
}