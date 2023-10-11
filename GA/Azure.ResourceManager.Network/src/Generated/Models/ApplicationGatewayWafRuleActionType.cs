// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The string representation of the web application firewall rule action. </summary>
    public readonly partial struct ApplicationGatewayWafRuleActionType : IEquatable<ApplicationGatewayWafRuleActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWafRuleActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayWafRuleActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AnomalyScoringValue = "AnomalyScoring";
        private const string AllowValue = "Allow";
        private const string BlockValue = "Block";
        private const string LogValue = "Log";

        /// <summary> None. </summary>
        public static ApplicationGatewayWafRuleActionType None { get; } = new ApplicationGatewayWafRuleActionType(NoneValue);
        /// <summary> AnomalyScoring. </summary>
        public static ApplicationGatewayWafRuleActionType AnomalyScoring { get; } = new ApplicationGatewayWafRuleActionType(AnomalyScoringValue);
        /// <summary> Allow. </summary>
        public static ApplicationGatewayWafRuleActionType Allow { get; } = new ApplicationGatewayWafRuleActionType(AllowValue);
        /// <summary> Block. </summary>
        public static ApplicationGatewayWafRuleActionType Block { get; } = new ApplicationGatewayWafRuleActionType(BlockValue);
        /// <summary> Log. </summary>
        public static ApplicationGatewayWafRuleActionType Log { get; } = new ApplicationGatewayWafRuleActionType(LogValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayWafRuleActionType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayWafRuleActionType left, ApplicationGatewayWafRuleActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayWafRuleActionType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayWafRuleActionType left, ApplicationGatewayWafRuleActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayWafRuleActionType"/>. </summary>
        public static implicit operator ApplicationGatewayWafRuleActionType(string value) => new ApplicationGatewayWafRuleActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayWafRuleActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayWafRuleActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}