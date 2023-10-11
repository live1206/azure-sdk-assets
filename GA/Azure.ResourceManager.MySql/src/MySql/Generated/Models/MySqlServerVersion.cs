// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> The version of a server. </summary>
    public readonly partial struct MySqlServerVersion : IEquatable<MySqlServerVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlServerVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlServerVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Ver5_6Value = "5.6";
        private const string Ver5_7Value = "5.7";
        private const string Ver8_0Value = "8.0";
        /// <summary> Determines if two <see cref="MySqlServerVersion"/> values are the same. </summary>
        public static bool operator ==(MySqlServerVersion left, MySqlServerVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlServerVersion"/> values are not the same. </summary>
        public static bool operator !=(MySqlServerVersion left, MySqlServerVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MySqlServerVersion"/>. </summary>
        public static implicit operator MySqlServerVersion(string value) => new MySqlServerVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlServerVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlServerVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}