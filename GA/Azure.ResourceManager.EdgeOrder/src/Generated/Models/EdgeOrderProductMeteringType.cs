// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Represents Metering type (eg one-time or recurrent). </summary>
    public readonly partial struct EdgeOrderProductMeteringType : IEquatable<EdgeOrderProductMeteringType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProductMeteringType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeOrderProductMeteringType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneTimeValue = "OneTime";
        private const string RecurringValue = "Recurring";
        private const string AdhocValue = "Adhoc";

        /// <summary> One time billing. </summary>
        public static EdgeOrderProductMeteringType OneTime { get; } = new EdgeOrderProductMeteringType(OneTimeValue);
        /// <summary> Recurring billing. </summary>
        public static EdgeOrderProductMeteringType Recurring { get; } = new EdgeOrderProductMeteringType(RecurringValue);
        /// <summary> Adhoc billing. </summary>
        public static EdgeOrderProductMeteringType Adhoc { get; } = new EdgeOrderProductMeteringType(AdhocValue);
        /// <summary> Determines if two <see cref="EdgeOrderProductMeteringType"/> values are the same. </summary>
        public static bool operator ==(EdgeOrderProductMeteringType left, EdgeOrderProductMeteringType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeOrderProductMeteringType"/> values are not the same. </summary>
        public static bool operator !=(EdgeOrderProductMeteringType left, EdgeOrderProductMeteringType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EdgeOrderProductMeteringType"/>. </summary>
        public static implicit operator EdgeOrderProductMeteringType(string value) => new EdgeOrderProductMeteringType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeOrderProductMeteringType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeOrderProductMeteringType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}