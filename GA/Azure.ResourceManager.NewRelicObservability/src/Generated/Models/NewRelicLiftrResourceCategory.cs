// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Liftr Resource category. </summary>
    public readonly partial struct NewRelicLiftrResourceCategory : IEquatable<NewRelicLiftrResourceCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NewRelicLiftrResourceCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NewRelicLiftrResourceCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string MonitorLogsValue = "MonitorLogs";

        /// <summary> Unknown. </summary>
        public static NewRelicLiftrResourceCategory Unknown { get; } = new NewRelicLiftrResourceCategory(UnknownValue);
        /// <summary> MonitorLogs. </summary>
        public static NewRelicLiftrResourceCategory MonitorLogs { get; } = new NewRelicLiftrResourceCategory(MonitorLogsValue);
        /// <summary> Determines if two <see cref="NewRelicLiftrResourceCategory"/> values are the same. </summary>
        public static bool operator ==(NewRelicLiftrResourceCategory left, NewRelicLiftrResourceCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NewRelicLiftrResourceCategory"/> values are not the same. </summary>
        public static bool operator !=(NewRelicLiftrResourceCategory left, NewRelicLiftrResourceCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NewRelicLiftrResourceCategory"/>. </summary>
        public static implicit operator NewRelicLiftrResourceCategory(string value) => new NewRelicLiftrResourceCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NewRelicLiftrResourceCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NewRelicLiftrResourceCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}