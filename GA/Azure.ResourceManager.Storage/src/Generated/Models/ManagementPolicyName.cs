// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The ManagementPolicyName. </summary>
    public readonly partial struct ManagementPolicyName : IEquatable<ManagementPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagementPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagementPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static ManagementPolicyName Default { get; } = new ManagementPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="ManagementPolicyName"/> values are the same. </summary>
        public static bool operator ==(ManagementPolicyName left, ManagementPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagementPolicyName"/> values are not the same. </summary>
        public static bool operator !=(ManagementPolicyName left, ManagementPolicyName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagementPolicyName"/>. </summary>
        public static implicit operator ManagementPolicyName(string value) => new ManagementPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagementPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagementPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}