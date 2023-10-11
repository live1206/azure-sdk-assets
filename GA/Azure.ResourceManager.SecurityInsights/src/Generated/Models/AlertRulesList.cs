// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List all the alert rules. </summary>
    internal partial class AlertRulesList
    {
        /// <summary> Initializes a new instance of AlertRulesList. </summary>
        /// <param name="value">
        /// Array of alert rules.
        /// Please note <see cref="SecurityInsightsAlertRuleData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsFusionAlertRule"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRule"/> and <see cref="SecurityInsightsScheduledAlertRule"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AlertRulesList(IEnumerable<SecurityInsightsAlertRuleData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of AlertRulesList. </summary>
        /// <param name="nextLink"> URL to fetch the next set of alert rules. </param>
        /// <param name="value">
        /// Array of alert rules.
        /// Please note <see cref="SecurityInsightsAlertRuleData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsFusionAlertRule"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRule"/> and <see cref="SecurityInsightsScheduledAlertRule"/>.
        /// </param>
        internal AlertRulesList(string nextLink, IReadOnlyList<SecurityInsightsAlertRuleData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to fetch the next set of alert rules. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Array of alert rules.
        /// Please note <see cref="SecurityInsightsAlertRuleData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsFusionAlertRule"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRule"/> and <see cref="SecurityInsightsScheduledAlertRule"/>.
        /// </summary>
        public IReadOnlyList<SecurityInsightsAlertRuleData> Value { get; }
    }
}