// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Status Codes for the Firewall. </summary>
    public readonly partial struct FirewallHealthStatus : IEquatable<FirewallHealthStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FirewallHealthStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallHealthStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GreenValue = "GREEN";
        private const string YellowValue = "YELLOW";
        private const string RedValue = "RED";
        private const string InitializingValue = "INITIALIZING";

        /// <summary> GREEN. </summary>
        public static FirewallHealthStatus Green { get; } = new FirewallHealthStatus(GreenValue);
        /// <summary> YELLOW. </summary>
        public static FirewallHealthStatus Yellow { get; } = new FirewallHealthStatus(YellowValue);
        /// <summary> RED. </summary>
        public static FirewallHealthStatus Red { get; } = new FirewallHealthStatus(RedValue);
        /// <summary> INITIALIZING. </summary>
        public static FirewallHealthStatus Initializing { get; } = new FirewallHealthStatus(InitializingValue);
        /// <summary> Determines if two <see cref="FirewallHealthStatus"/> values are the same. </summary>
        public static bool operator ==(FirewallHealthStatus left, FirewallHealthStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallHealthStatus"/> values are not the same. </summary>
        public static bool operator !=(FirewallHealthStatus left, FirewallHealthStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallHealthStatus"/>. </summary>
        public static implicit operator FirewallHealthStatus(string value) => new FirewallHealthStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallHealthStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallHealthStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}