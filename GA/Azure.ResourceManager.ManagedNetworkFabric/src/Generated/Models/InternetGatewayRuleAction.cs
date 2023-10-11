// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Specify action. </summary>
    public readonly partial struct InternetGatewayRuleAction : IEquatable<InternetGatewayRuleAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternetGatewayRuleAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternetGatewayRuleAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static InternetGatewayRuleAction Allow { get; } = new InternetGatewayRuleAction(AllowValue);
        /// <summary> Deny. </summary>
        public static InternetGatewayRuleAction Deny { get; } = new InternetGatewayRuleAction(DenyValue);
        /// <summary> Determines if two <see cref="InternetGatewayRuleAction"/> values are the same. </summary>
        public static bool operator ==(InternetGatewayRuleAction left, InternetGatewayRuleAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternetGatewayRuleAction"/> values are not the same. </summary>
        public static bool operator !=(InternetGatewayRuleAction left, InternetGatewayRuleAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternetGatewayRuleAction"/>. </summary>
        public static implicit operator InternetGatewayRuleAction(string value) => new InternetGatewayRuleAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternetGatewayRuleAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternetGatewayRuleAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}