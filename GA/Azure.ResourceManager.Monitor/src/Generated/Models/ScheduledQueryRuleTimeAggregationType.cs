// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Aggregation type. Relevant and required only for rules of the kind LogAlert. </summary>
    public readonly partial struct ScheduledQueryRuleTimeAggregationType : IEquatable<ScheduledQueryRuleTimeAggregationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduledQueryRuleTimeAggregationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduledQueryRuleTimeAggregationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";
        private const string AverageValue = "Average";
        private const string MinimumValue = "Minimum";
        private const string MaximumValue = "Maximum";
        private const string TotalValue = "Total";

        /// <summary> Count. </summary>
        public static ScheduledQueryRuleTimeAggregationType Count { get; } = new ScheduledQueryRuleTimeAggregationType(CountValue);
        /// <summary> Average. </summary>
        public static ScheduledQueryRuleTimeAggregationType Average { get; } = new ScheduledQueryRuleTimeAggregationType(AverageValue);
        /// <summary> Minimum. </summary>
        public static ScheduledQueryRuleTimeAggregationType Minimum { get; } = new ScheduledQueryRuleTimeAggregationType(MinimumValue);
        /// <summary> Maximum. </summary>
        public static ScheduledQueryRuleTimeAggregationType Maximum { get; } = new ScheduledQueryRuleTimeAggregationType(MaximumValue);
        /// <summary> Total. </summary>
        public static ScheduledQueryRuleTimeAggregationType Total { get; } = new ScheduledQueryRuleTimeAggregationType(TotalValue);
        /// <summary> Determines if two <see cref="ScheduledQueryRuleTimeAggregationType"/> values are the same. </summary>
        public static bool operator ==(ScheduledQueryRuleTimeAggregationType left, ScheduledQueryRuleTimeAggregationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduledQueryRuleTimeAggregationType"/> values are not the same. </summary>
        public static bool operator !=(ScheduledQueryRuleTimeAggregationType left, ScheduledQueryRuleTimeAggregationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScheduledQueryRuleTimeAggregationType"/>. </summary>
        public static implicit operator ScheduledQueryRuleTimeAggregationType(string value) => new ScheduledQueryRuleTimeAggregationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduledQueryRuleTimeAggregationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduledQueryRuleTimeAggregationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}