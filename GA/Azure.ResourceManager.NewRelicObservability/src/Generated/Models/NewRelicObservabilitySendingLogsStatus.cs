// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Indicates whether logs are being sent. </summary>
    public readonly partial struct NewRelicObservabilitySendingLogsStatus : IEquatable<NewRelicObservabilitySendingLogsStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilitySendingLogsStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NewRelicObservabilitySendingLogsStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IsEnabledValue = "Enabled";
        private const string IsDisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static NewRelicObservabilitySendingLogsStatus IsEnabled { get; } = new NewRelicObservabilitySendingLogsStatus(IsEnabledValue);
        /// <summary> Disabled. </summary>
        public static NewRelicObservabilitySendingLogsStatus IsDisabled { get; } = new NewRelicObservabilitySendingLogsStatus(IsDisabledValue);
        /// <summary> Determines if two <see cref="NewRelicObservabilitySendingLogsStatus"/> values are the same. </summary>
        public static bool operator ==(NewRelicObservabilitySendingLogsStatus left, NewRelicObservabilitySendingLogsStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NewRelicObservabilitySendingLogsStatus"/> values are not the same. </summary>
        public static bool operator !=(NewRelicObservabilitySendingLogsStatus left, NewRelicObservabilitySendingLogsStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NewRelicObservabilitySendingLogsStatus"/>. </summary>
        public static implicit operator NewRelicObservabilitySendingLogsStatus(string value) => new NewRelicObservabilitySendingLogsStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NewRelicObservabilitySendingLogsStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NewRelicObservabilitySendingLogsStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}