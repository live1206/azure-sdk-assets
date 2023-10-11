// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The AutomationRulePropertyArrayChangedConditionSupportedArrayType. </summary>
    public readonly partial struct AutomationRulePropertyArrayChangedConditionSupportedArrayType : IEquatable<AutomationRulePropertyArrayChangedConditionSupportedArrayType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyArrayChangedConditionSupportedArrayType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationRulePropertyArrayChangedConditionSupportedArrayType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlertsValue = "Alerts";
        private const string LabelsValue = "Labels";
        private const string TacticsValue = "Tactics";
        private const string CommentsValue = "Comments";

        /// <summary> Evaluate the condition on the alerts. </summary>
        public static AutomationRulePropertyArrayChangedConditionSupportedArrayType Alerts { get; } = new AutomationRulePropertyArrayChangedConditionSupportedArrayType(AlertsValue);
        /// <summary> Evaluate the condition on the labels. </summary>
        public static AutomationRulePropertyArrayChangedConditionSupportedArrayType Labels { get; } = new AutomationRulePropertyArrayChangedConditionSupportedArrayType(LabelsValue);
        /// <summary> Evaluate the condition on the tactics. </summary>
        public static AutomationRulePropertyArrayChangedConditionSupportedArrayType Tactics { get; } = new AutomationRulePropertyArrayChangedConditionSupportedArrayType(TacticsValue);
        /// <summary> Evaluate the condition on the comments. </summary>
        public static AutomationRulePropertyArrayChangedConditionSupportedArrayType Comments { get; } = new AutomationRulePropertyArrayChangedConditionSupportedArrayType(CommentsValue);
        /// <summary> Determines if two <see cref="AutomationRulePropertyArrayChangedConditionSupportedArrayType"/> values are the same. </summary>
        public static bool operator ==(AutomationRulePropertyArrayChangedConditionSupportedArrayType left, AutomationRulePropertyArrayChangedConditionSupportedArrayType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationRulePropertyArrayChangedConditionSupportedArrayType"/> values are not the same. </summary>
        public static bool operator !=(AutomationRulePropertyArrayChangedConditionSupportedArrayType left, AutomationRulePropertyArrayChangedConditionSupportedArrayType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutomationRulePropertyArrayChangedConditionSupportedArrayType"/>. </summary>
        public static implicit operator AutomationRulePropertyArrayChangedConditionSupportedArrayType(string value) => new AutomationRulePropertyArrayChangedConditionSupportedArrayType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationRulePropertyArrayChangedConditionSupportedArrayType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationRulePropertyArrayChangedConditionSupportedArrayType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}