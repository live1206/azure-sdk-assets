// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The operator to use for comparison. </summary>
    public readonly partial struct ComparisonOperatorType : IEquatable<ComparisonOperatorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComparisonOperatorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComparisonOperatorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InValue = "In";
        private const string ContainsValue = "Contains";

        /// <summary> In. </summary>
        public static ComparisonOperatorType In { get; } = new ComparisonOperatorType(InValue);
        /// <summary> Contains. </summary>
        public static ComparisonOperatorType Contains { get; } = new ComparisonOperatorType(ContainsValue);
        /// <summary> Determines if two <see cref="ComparisonOperatorType"/> values are the same. </summary>
        public static bool operator ==(ComparisonOperatorType left, ComparisonOperatorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComparisonOperatorType"/> values are not the same. </summary>
        public static bool operator !=(ComparisonOperatorType left, ComparisonOperatorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComparisonOperatorType"/>. </summary>
        public static implicit operator ComparisonOperatorType(string value) => new ComparisonOperatorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComparisonOperatorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComparisonOperatorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}