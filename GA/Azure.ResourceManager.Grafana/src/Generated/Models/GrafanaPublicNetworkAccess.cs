// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> Indicate the state for enable or disable traffic over the public interface. </summary>
    public readonly partial struct GrafanaPublicNetworkAccess : IEquatable<GrafanaPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GrafanaPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GrafanaPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static GrafanaPublicNetworkAccess Enabled { get; } = new GrafanaPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static GrafanaPublicNetworkAccess Disabled { get; } = new GrafanaPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="GrafanaPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(GrafanaPublicNetworkAccess left, GrafanaPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GrafanaPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(GrafanaPublicNetworkAccess left, GrafanaPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GrafanaPublicNetworkAccess"/>. </summary>
        public static implicit operator GrafanaPublicNetworkAccess(string value) => new GrafanaPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GrafanaPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GrafanaPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}