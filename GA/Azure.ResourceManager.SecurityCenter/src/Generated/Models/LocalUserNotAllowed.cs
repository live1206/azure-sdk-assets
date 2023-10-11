// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Login by a local user that isn't allowed. Allow list consists of login names to allow. </summary>
    public partial class LocalUserNotAllowed : AllowlistCustomAlertRule
    {
        /// <summary> Initializes a new instance of LocalUserNotAllowed. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowlistValues"/> is null. </exception>
        public LocalUserNotAllowed(bool isEnabled, IEnumerable<string> allowlistValues) : base(isEnabled, allowlistValues)
        {
            Argument.AssertNotNull(allowlistValues, nameof(allowlistValues));

            RuleType = "LocalUserNotAllowed";
        }

        /// <summary> Initializes a new instance of LocalUserNotAllowed. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="valueType"> The value type of the items in the list. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        internal LocalUserNotAllowed(string displayName, string description, bool isEnabled, string ruleType, SecurityValueType? valueType, IList<string> allowlistValues) : base(displayName, description, isEnabled, ruleType, valueType, allowlistValues)
        {
            RuleType = ruleType ?? "LocalUserNotAllowed";
        }
    }
}