// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> the criteria operator. </summary>
    public readonly partial struct MetricCriteriaOperator : IEquatable<MetricCriteriaOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetricCriteriaOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricCriteriaOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualsValueValue = "Equals";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanOrEqualValue = "GreaterThanOrEqual";
        private const string LessThanValue = "LessThan";
        private const string LessThanOrEqualValue = "LessThanOrEqual";

        /// <summary> Equals. </summary>
        public static MetricCriteriaOperator EqualsValue { get; } = new MetricCriteriaOperator(EqualsValueValue);
        /// <summary> GreaterThan. </summary>
        public static MetricCriteriaOperator GreaterThan { get; } = new MetricCriteriaOperator(GreaterThanValue);
        /// <summary> GreaterThanOrEqual. </summary>
        public static MetricCriteriaOperator GreaterThanOrEqual { get; } = new MetricCriteriaOperator(GreaterThanOrEqualValue);
        /// <summary> LessThan. </summary>
        public static MetricCriteriaOperator LessThan { get; } = new MetricCriteriaOperator(LessThanValue);
        /// <summary> LessThanOrEqual. </summary>
        public static MetricCriteriaOperator LessThanOrEqual { get; } = new MetricCriteriaOperator(LessThanOrEqualValue);
        /// <summary> Determines if two <see cref="MetricCriteriaOperator"/> values are the same. </summary>
        public static bool operator ==(MetricCriteriaOperator left, MetricCriteriaOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricCriteriaOperator"/> values are not the same. </summary>
        public static bool operator !=(MetricCriteriaOperator left, MetricCriteriaOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MetricCriteriaOperator"/>. </summary>
        public static implicit operator MetricCriteriaOperator(string value) => new MetricCriteriaOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricCriteriaOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricCriteriaOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}