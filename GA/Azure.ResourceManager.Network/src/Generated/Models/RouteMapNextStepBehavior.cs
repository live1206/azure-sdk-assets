// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Supported next step behaviors after a rule is applied to a matched route. </summary>
    public readonly partial struct RouteMapNextStepBehavior : IEquatable<RouteMapNextStepBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouteMapNextStepBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouteMapNextStepBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ContinueValue = "Continue";
        private const string TerminateValue = "Terminate";

        /// <summary> Unknown. </summary>
        public static RouteMapNextStepBehavior Unknown { get; } = new RouteMapNextStepBehavior(UnknownValue);
        /// <summary> Continue. </summary>
        public static RouteMapNextStepBehavior Continue { get; } = new RouteMapNextStepBehavior(ContinueValue);
        /// <summary> Terminate. </summary>
        public static RouteMapNextStepBehavior Terminate { get; } = new RouteMapNextStepBehavior(TerminateValue);
        /// <summary> Determines if two <see cref="RouteMapNextStepBehavior"/> values are the same. </summary>
        public static bool operator ==(RouteMapNextStepBehavior left, RouteMapNextStepBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouteMapNextStepBehavior"/> values are not the same. </summary>
        public static bool operator !=(RouteMapNextStepBehavior left, RouteMapNextStepBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouteMapNextStepBehavior"/>. </summary>
        public static implicit operator RouteMapNextStepBehavior(string value) => new RouteMapNextStepBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouteMapNextStepBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouteMapNextStepBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}