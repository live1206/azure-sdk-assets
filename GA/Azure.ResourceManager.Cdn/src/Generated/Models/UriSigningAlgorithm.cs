// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Algorithm to use for URL signing. </summary>
    public readonly partial struct UriSigningAlgorithm : IEquatable<UriSigningAlgorithm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UriSigningAlgorithm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UriSigningAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Sha256Value = "SHA256";

        /// <summary> SHA256. </summary>
        public static UriSigningAlgorithm Sha256 { get; } = new UriSigningAlgorithm(Sha256Value);
        /// <summary> Determines if two <see cref="UriSigningAlgorithm"/> values are the same. </summary>
        public static bool operator ==(UriSigningAlgorithm left, UriSigningAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UriSigningAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(UriSigningAlgorithm left, UriSigningAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UriSigningAlgorithm"/>. </summary>
        public static implicit operator UriSigningAlgorithm(string value) => new UriSigningAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UriSigningAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UriSigningAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}