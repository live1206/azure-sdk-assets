// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The DataBoxEdgeDayOfWeek. </summary>
    public readonly partial struct DataBoxEdgeDayOfWeek : IEquatable<DataBoxEdgeDayOfWeek>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeDayOfWeek"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeDayOfWeek(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SundayValue = "Sunday";
        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";

        /// <summary> Sunday. </summary>
        public static DataBoxEdgeDayOfWeek Sunday { get; } = new DataBoxEdgeDayOfWeek(SundayValue);
        /// <summary> Monday. </summary>
        public static DataBoxEdgeDayOfWeek Monday { get; } = new DataBoxEdgeDayOfWeek(MondayValue);
        /// <summary> Tuesday. </summary>
        public static DataBoxEdgeDayOfWeek Tuesday { get; } = new DataBoxEdgeDayOfWeek(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static DataBoxEdgeDayOfWeek Wednesday { get; } = new DataBoxEdgeDayOfWeek(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static DataBoxEdgeDayOfWeek Thursday { get; } = new DataBoxEdgeDayOfWeek(ThursdayValue);
        /// <summary> Friday. </summary>
        public static DataBoxEdgeDayOfWeek Friday { get; } = new DataBoxEdgeDayOfWeek(FridayValue);
        /// <summary> Saturday. </summary>
        public static DataBoxEdgeDayOfWeek Saturday { get; } = new DataBoxEdgeDayOfWeek(SaturdayValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeDayOfWeek"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeDayOfWeek left, DataBoxEdgeDayOfWeek right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeDayOfWeek"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeDayOfWeek left, DataBoxEdgeDayOfWeek right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoxEdgeDayOfWeek"/>. </summary>
        public static implicit operator DataBoxEdgeDayOfWeek(string value) => new DataBoxEdgeDayOfWeek(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeDayOfWeek other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeDayOfWeek other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}