// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Suppression rules list for subscription. </summary>
    internal partial class AlertsSuppressionRulesList
    {
        /// <summary> Initializes a new instance of AlertsSuppressionRulesList. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AlertsSuppressionRulesList(IEnumerable<SecurityAlertsSuppressionRuleData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of AlertsSuppressionRulesList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URI to fetch the next page. </param>
        internal AlertsSuppressionRulesList(IReadOnlyList<SecurityAlertsSuppressionRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecurityAlertsSuppressionRuleData> Value { get; }
        /// <summary> URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}