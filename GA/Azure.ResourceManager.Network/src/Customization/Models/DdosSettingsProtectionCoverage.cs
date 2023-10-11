// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The DDoS protection policy customizability of the public IP. Only standard coverage will have the ability to be customized. </summary>
    [Obsolete("This struct is obsolete and will be removed in a future release", false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly struct DdosSettingsProtectionCoverage : IEquatable<DdosSettingsProtectionCoverage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DdosSettingsProtectionCoverage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DdosSettingsProtectionCoverage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";

        /// <summary> Basic. </summary>
        public static DdosSettingsProtectionCoverage Basic { get; } = new DdosSettingsProtectionCoverage(BasicValue);
        /// <summary> Standard. </summary>
        public static DdosSettingsProtectionCoverage Standard { get; } = new DdosSettingsProtectionCoverage(StandardValue);
        /// <summary> Determines if two <see cref="DdosSettingsProtectionCoverage"/> values are the same. </summary>
        public static bool operator ==(DdosSettingsProtectionCoverage left, DdosSettingsProtectionCoverage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DdosSettingsProtectionCoverage"/> values are not the same. </summary>
        public static bool operator !=(DdosSettingsProtectionCoverage left, DdosSettingsProtectionCoverage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DdosSettingsProtectionCoverage"/>. </summary>
        public static implicit operator DdosSettingsProtectionCoverage(string value) => new DdosSettingsProtectionCoverage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DdosSettingsProtectionCoverage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DdosSettingsProtectionCoverage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
