// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The DDoS protection mode of the public IP. </summary>
    public readonly partial struct DdosSettingsProtectionMode : IEquatable<DdosSettingsProtectionMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DdosSettingsProtectionMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DdosSettingsProtectionMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VirtualNetworkInheritedValue = "VirtualNetworkInherited";
        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> VirtualNetworkInherited. </summary>
        public static DdosSettingsProtectionMode VirtualNetworkInherited { get; } = new DdosSettingsProtectionMode(VirtualNetworkInheritedValue);
        /// <summary> Enabled. </summary>
        public static DdosSettingsProtectionMode Enabled { get; } = new DdosSettingsProtectionMode(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DdosSettingsProtectionMode Disabled { get; } = new DdosSettingsProtectionMode(DisabledValue);
        /// <summary> Determines if two <see cref="DdosSettingsProtectionMode"/> values are the same. </summary>
        public static bool operator ==(DdosSettingsProtectionMode left, DdosSettingsProtectionMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DdosSettingsProtectionMode"/> values are not the same. </summary>
        public static bool operator !=(DdosSettingsProtectionMode left, DdosSettingsProtectionMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DdosSettingsProtectionMode"/>. </summary>
        public static implicit operator DdosSettingsProtectionMode(string value) => new DdosSettingsProtectionMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DdosSettingsProtectionMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DdosSettingsProtectionMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}