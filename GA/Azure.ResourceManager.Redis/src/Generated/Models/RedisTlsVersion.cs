// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, '1.0', '1.1', '1.2'). </summary>
    public readonly partial struct RedisTlsVersion : IEquatable<RedisTlsVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisTlsVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisTlsVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tls1_0Value = "1.0";
        private const string Tls1_1Value = "1.1";
        private const string Tls1_2Value = "1.2";
        /// <summary> Determines if two <see cref="RedisTlsVersion"/> values are the same. </summary>
        public static bool operator ==(RedisTlsVersion left, RedisTlsVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisTlsVersion"/> values are not the same. </summary>
        public static bool operator !=(RedisTlsVersion left, RedisTlsVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisTlsVersion"/>. </summary>
        public static implicit operator RedisTlsVersion(string value) => new RedisTlsVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisTlsVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisTlsVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}