// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Day of maintenance window. </summary>
    public readonly partial struct SynapseDayOfWeek : IEquatable<SynapseDayOfWeek>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseDayOfWeek"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseDayOfWeek(string value)
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
        public static SynapseDayOfWeek Sunday { get; } = new SynapseDayOfWeek(SundayValue);
        /// <summary> Monday. </summary>
        public static SynapseDayOfWeek Monday { get; } = new SynapseDayOfWeek(MondayValue);
        /// <summary> Tuesday. </summary>
        public static SynapseDayOfWeek Tuesday { get; } = new SynapseDayOfWeek(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static SynapseDayOfWeek Wednesday { get; } = new SynapseDayOfWeek(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static SynapseDayOfWeek Thursday { get; } = new SynapseDayOfWeek(ThursdayValue);
        /// <summary> Friday. </summary>
        public static SynapseDayOfWeek Friday { get; } = new SynapseDayOfWeek(FridayValue);
        /// <summary> Saturday. </summary>
        public static SynapseDayOfWeek Saturday { get; } = new SynapseDayOfWeek(SaturdayValue);
        /// <summary> Determines if two <see cref="SynapseDayOfWeek"/> values are the same. </summary>
        public static bool operator ==(SynapseDayOfWeek left, SynapseDayOfWeek right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseDayOfWeek"/> values are not the same. </summary>
        public static bool operator !=(SynapseDayOfWeek left, SynapseDayOfWeek right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseDayOfWeek"/>. </summary>
        public static implicit operator SynapseDayOfWeek(string value) => new SynapseDayOfWeek(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseDayOfWeek other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseDayOfWeek other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
