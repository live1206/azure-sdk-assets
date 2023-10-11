// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The AccessName. </summary>
    public readonly partial struct AccessName : IEquatable<AccessName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TenantAccessValue = "access";
        private const string TenantGitAccessValue = "gitAccess";

        /// <summary> access. </summary>
        public static AccessName TenantAccess { get; } = new AccessName(TenantAccessValue);
        /// <summary> gitAccess. </summary>
        public static AccessName TenantGitAccess { get; } = new AccessName(TenantGitAccessValue);
        /// <summary> Determines if two <see cref="AccessName"/> values are the same. </summary>
        public static bool operator ==(AccessName left, AccessName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessName"/> values are not the same. </summary>
        public static bool operator !=(AccessName left, AccessName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessName"/>. </summary>
        public static implicit operator AccessName(string value) => new AccessName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}