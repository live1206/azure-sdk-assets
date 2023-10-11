// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> The access key to regenerate. </summary>
    public readonly partial struct RelayAccessKeyType : IEquatable<RelayAccessKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelayAccessKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelayAccessKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryKeyValue = "PrimaryKey";
        private const string SecondaryKeyValue = "SecondaryKey";

        /// <summary> PrimaryKey. </summary>
        public static RelayAccessKeyType PrimaryKey { get; } = new RelayAccessKeyType(PrimaryKeyValue);
        /// <summary> SecondaryKey. </summary>
        public static RelayAccessKeyType SecondaryKey { get; } = new RelayAccessKeyType(SecondaryKeyValue);
        /// <summary> Determines if two <see cref="RelayAccessKeyType"/> values are the same. </summary>
        public static bool operator ==(RelayAccessKeyType left, RelayAccessKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelayAccessKeyType"/> values are not the same. </summary>
        public static bool operator !=(RelayAccessKeyType left, RelayAccessKeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RelayAccessKeyType"/>. </summary>
        public static implicit operator RelayAccessKeyType(string value) => new RelayAccessKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelayAccessKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelayAccessKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
