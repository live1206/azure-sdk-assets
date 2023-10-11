// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto. </summary>
    public readonly partial struct RollingUpgradeMode : IEquatable<RollingUpgradeMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RollingUpgradeMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RollingUpgradeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MonitoredValue = "Monitored";
        private const string UnmonitoredAutoValue = "UnmonitoredAuto";

        /// <summary> The upgrade will stop after completing each upgrade domain and automatically monitor health before proceeding. The value is 0. </summary>
        public static RollingUpgradeMode Monitored { get; } = new RollingUpgradeMode(MonitoredValue);
        /// <summary> The upgrade will proceed automatically without performing any health monitoring. The value is 1. </summary>
        public static RollingUpgradeMode UnmonitoredAuto { get; } = new RollingUpgradeMode(UnmonitoredAutoValue);
        /// <summary> Determines if two <see cref="RollingUpgradeMode"/> values are the same. </summary>
        public static bool operator ==(RollingUpgradeMode left, RollingUpgradeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RollingUpgradeMode"/> values are not the same. </summary>
        public static bool operator !=(RollingUpgradeMode left, RollingUpgradeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RollingUpgradeMode"/>. </summary>
        public static implicit operator RollingUpgradeMode(string value) => new RollingUpgradeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RollingUpgradeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RollingUpgradeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
