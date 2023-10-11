// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The compliance state that should be set on the resource. </summary>
    public readonly partial struct PolicyComplianceState : IEquatable<PolicyComplianceState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyComplianceState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyComplianceState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompliantValue = "Compliant";
        private const string NonCompliantValue = "NonCompliant";
        private const string UnknownValue = "Unknown";

        /// <summary> The resource is in compliance with the policy. </summary>
        public static PolicyComplianceState Compliant { get; } = new PolicyComplianceState(CompliantValue);
        /// <summary> The resource is not in compliance with the policy. </summary>
        public static PolicyComplianceState NonCompliant { get; } = new PolicyComplianceState(NonCompliantValue);
        /// <summary> The compliance state of the resource is not known. </summary>
        public static PolicyComplianceState Unknown { get; } = new PolicyComplianceState(UnknownValue);
        /// <summary> Determines if two <see cref="PolicyComplianceState"/> values are the same. </summary>
        public static bool operator ==(PolicyComplianceState left, PolicyComplianceState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyComplianceState"/> values are not the same. </summary>
        public static bool operator !=(PolicyComplianceState left, PolicyComplianceState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyComplianceState"/>. </summary>
        public static implicit operator PolicyComplianceState(string value) => new PolicyComplianceState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyComplianceState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyComplianceState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}