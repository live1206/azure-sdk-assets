// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies the type of threshold criteria. </summary>
    internal readonly partial struct CriterionType : IEquatable<CriterionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CriterionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CriterionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticThresholdCriterionValue = "StaticThresholdCriterion";
        private const string DynamicThresholdCriterionValue = "DynamicThresholdCriterion";

        /// <summary> StaticThresholdCriterion. </summary>
        public static CriterionType StaticThresholdCriterion { get; } = new CriterionType(StaticThresholdCriterionValue);
        /// <summary> DynamicThresholdCriterion. </summary>
        public static CriterionType DynamicThresholdCriterion { get; } = new CriterionType(DynamicThresholdCriterionValue);
        /// <summary> Determines if two <see cref="CriterionType"/> values are the same. </summary>
        public static bool operator ==(CriterionType left, CriterionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CriterionType"/> values are not the same. </summary>
        public static bool operator !=(CriterionType left, CriterionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CriterionType"/>. </summary>
        public static implicit operator CriterionType(string value) => new CriterionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CriterionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CriterionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
