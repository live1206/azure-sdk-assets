// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Describes if policy managed rules will inspect the request body content. </summary>
    public readonly partial struct PolicyRequestBodyCheck : IEquatable<PolicyRequestBodyCheck>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyRequestBodyCheck"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyRequestBodyCheck(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static PolicyRequestBodyCheck Disabled { get; } = new PolicyRequestBodyCheck(DisabledValue);
        /// <summary> Enabled. </summary>
        public static PolicyRequestBodyCheck Enabled { get; } = new PolicyRequestBodyCheck(EnabledValue);
        /// <summary> Determines if two <see cref="PolicyRequestBodyCheck"/> values are the same. </summary>
        public static bool operator ==(PolicyRequestBodyCheck left, PolicyRequestBodyCheck right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyRequestBodyCheck"/> values are not the same. </summary>
        public static bool operator !=(PolicyRequestBodyCheck left, PolicyRequestBodyCheck right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyRequestBodyCheck"/>. </summary>
        public static implicit operator PolicyRequestBodyCheck(string value) => new PolicyRequestBodyCheck(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyRequestBodyCheck other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyRequestBodyCheck other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}