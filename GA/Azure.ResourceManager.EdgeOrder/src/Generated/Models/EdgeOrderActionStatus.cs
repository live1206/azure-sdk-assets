// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Describes whether the order item is deletable or not. </summary>
    public readonly partial struct EdgeOrderActionStatus : IEquatable<EdgeOrderActionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderActionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeOrderActionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowedValue = "Allowed";
        private const string NotAllowedValue = "NotAllowed";

        /// <summary> Allowed flag. </summary>
        public static EdgeOrderActionStatus Allowed { get; } = new EdgeOrderActionStatus(AllowedValue);
        /// <summary> Not Allowed flag. </summary>
        public static EdgeOrderActionStatus NotAllowed { get; } = new EdgeOrderActionStatus(NotAllowedValue);
        /// <summary> Determines if two <see cref="EdgeOrderActionStatus"/> values are the same. </summary>
        public static bool operator ==(EdgeOrderActionStatus left, EdgeOrderActionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeOrderActionStatus"/> values are not the same. </summary>
        public static bool operator !=(EdgeOrderActionStatus left, EdgeOrderActionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EdgeOrderActionStatus"/>. </summary>
        public static implicit operator EdgeOrderActionStatus(string value) => new EdgeOrderActionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeOrderActionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeOrderActionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}