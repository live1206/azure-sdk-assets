// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The aggregation interval of the Timeseries. </summary>
    public readonly partial struct FrontDoorTimeSeriesInfoAggregationInterval : IEquatable<FrontDoorTimeSeriesInfoAggregationInterval>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorTimeSeriesInfoAggregationInterval"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorTimeSeriesInfoAggregationInterval(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HourlyValue = "Hourly";
        private const string DailyValue = "Daily";

        /// <summary> Hourly. </summary>
        public static FrontDoorTimeSeriesInfoAggregationInterval Hourly { get; } = new FrontDoorTimeSeriesInfoAggregationInterval(HourlyValue);
        /// <summary> Daily. </summary>
        public static FrontDoorTimeSeriesInfoAggregationInterval Daily { get; } = new FrontDoorTimeSeriesInfoAggregationInterval(DailyValue);
        /// <summary> Determines if two <see cref="FrontDoorTimeSeriesInfoAggregationInterval"/> values are the same. </summary>
        public static bool operator ==(FrontDoorTimeSeriesInfoAggregationInterval left, FrontDoorTimeSeriesInfoAggregationInterval right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorTimeSeriesInfoAggregationInterval"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorTimeSeriesInfoAggregationInterval left, FrontDoorTimeSeriesInfoAggregationInterval right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FrontDoorTimeSeriesInfoAggregationInterval"/>. </summary>
        public static implicit operator FrontDoorTimeSeriesInfoAggregationInterval(string value) => new FrontDoorTimeSeriesInfoAggregationInterval(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorTimeSeriesInfoAggregationInterval other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorTimeSeriesInfoAggregationInterval other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
