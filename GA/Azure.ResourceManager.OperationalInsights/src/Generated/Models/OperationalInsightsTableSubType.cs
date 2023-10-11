// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The subtype describes what APIs can be used to interact with the table, and what features are available against it. </summary>
    public readonly partial struct OperationalInsightsTableSubType : IEquatable<OperationalInsightsTableSubType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsTableSubType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsTableSubType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyValue = "Any";
        private const string ClassicValue = "Classic";
        private const string DataCollectionRuleBasedValue = "DataCollectionRuleBased";

        /// <summary> The default subtype with which built-in tables are created. </summary>
        public static OperationalInsightsTableSubType Any { get; } = new OperationalInsightsTableSubType(AnyValue);
        /// <summary> Indicates a table created through the Data Collector API or with the custom logs feature of the MMA agent, or any table against which Custom Fields were created. </summary>
        public static OperationalInsightsTableSubType Classic { get; } = new OperationalInsightsTableSubType(ClassicValue);
        /// <summary> A table eligible to have data sent into it via any of the means supported by Data Collection Rules: the Data Collection Endpoint API, ingestion-time transformations, or any other mechanism provided by Data Collection Rules. </summary>
        public static OperationalInsightsTableSubType DataCollectionRuleBased { get; } = new OperationalInsightsTableSubType(DataCollectionRuleBasedValue);
        /// <summary> Determines if two <see cref="OperationalInsightsTableSubType"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsTableSubType left, OperationalInsightsTableSubType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsTableSubType"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsTableSubType left, OperationalInsightsTableSubType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationalInsightsTableSubType"/>. </summary>
        public static implicit operator OperationalInsightsTableSubType(string value) => new OperationalInsightsTableSubType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsTableSubType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsTableSubType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}