// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Status of address validation. </summary>
    public readonly partial struct EdgeOrderAddressValidationStatus : IEquatable<EdgeOrderAddressValidationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressValidationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeOrderAddressValidationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidValue = "Valid";
        private const string InvalidValue = "Invalid";
        private const string AmbiguousValue = "Ambiguous";

        /// <summary> Address provided is valid. </summary>
        public static EdgeOrderAddressValidationStatus Valid { get; } = new EdgeOrderAddressValidationStatus(ValidValue);
        /// <summary> Address provided is invalid or not supported. </summary>
        public static EdgeOrderAddressValidationStatus Invalid { get; } = new EdgeOrderAddressValidationStatus(InvalidValue);
        /// <summary> Address provided is ambiguous, please choose one of the alternate addresses returned. </summary>
        public static EdgeOrderAddressValidationStatus Ambiguous { get; } = new EdgeOrderAddressValidationStatus(AmbiguousValue);
        /// <summary> Determines if two <see cref="EdgeOrderAddressValidationStatus"/> values are the same. </summary>
        public static bool operator ==(EdgeOrderAddressValidationStatus left, EdgeOrderAddressValidationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeOrderAddressValidationStatus"/> values are not the same. </summary>
        public static bool operator !=(EdgeOrderAddressValidationStatus left, EdgeOrderAddressValidationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EdgeOrderAddressValidationStatus"/>. </summary>
        public static implicit operator EdgeOrderAddressValidationStatus(string value) => new EdgeOrderAddressValidationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeOrderAddressValidationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeOrderAddressValidationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
