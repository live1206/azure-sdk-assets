// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> An enum describing the unit of usage measurement. </summary>
    public readonly partial struct MachineLearningUsageUnit : IEquatable<MachineLearningUsageUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningUsageUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningUsageUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";

        /// <summary> Count. </summary>
        public static MachineLearningUsageUnit Count { get; } = new MachineLearningUsageUnit(CountValue);
        /// <summary> Determines if two <see cref="MachineLearningUsageUnit"/> values are the same. </summary>
        public static bool operator ==(MachineLearningUsageUnit left, MachineLearningUsageUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningUsageUnit"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningUsageUnit left, MachineLearningUsageUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningUsageUnit"/>. </summary>
        public static implicit operator MachineLearningUsageUnit(string value) => new MachineLearningUsageUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningUsageUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningUsageUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}