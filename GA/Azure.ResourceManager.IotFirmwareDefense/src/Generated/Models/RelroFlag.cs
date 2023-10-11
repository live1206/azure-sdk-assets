// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> RELRO flag. </summary>
    public readonly partial struct RelroFlag : IEquatable<RelroFlag>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelroFlag"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelroFlag(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static RelroFlag True { get; } = new RelroFlag(TrueValue);
        /// <summary> False. </summary>
        public static RelroFlag False { get; } = new RelroFlag(FalseValue);
        /// <summary> Determines if two <see cref="RelroFlag"/> values are the same. </summary>
        public static bool operator ==(RelroFlag left, RelroFlag right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelroFlag"/> values are not the same. </summary>
        public static bool operator !=(RelroFlag left, RelroFlag right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RelroFlag"/>. </summary>
        public static implicit operator RelroFlag(string value) => new RelroFlag(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelroFlag other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelroFlag other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}