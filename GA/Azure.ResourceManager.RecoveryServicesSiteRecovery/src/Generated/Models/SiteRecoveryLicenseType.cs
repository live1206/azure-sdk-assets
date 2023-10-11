// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> License type. </summary>
    public readonly partial struct SiteRecoveryLicenseType : IEquatable<SiteRecoveryLicenseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryLicenseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SiteRecoveryLicenseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string NoLicenseTypeValue = "NoLicenseType";
        private const string WindowsServerValue = "WindowsServer";

        /// <summary> NotSpecified. </summary>
        public static SiteRecoveryLicenseType NotSpecified { get; } = new SiteRecoveryLicenseType(NotSpecifiedValue);
        /// <summary> NoLicenseType. </summary>
        public static SiteRecoveryLicenseType NoLicenseType { get; } = new SiteRecoveryLicenseType(NoLicenseTypeValue);
        /// <summary> WindowsServer. </summary>
        public static SiteRecoveryLicenseType WindowsServer { get; } = new SiteRecoveryLicenseType(WindowsServerValue);
        /// <summary> Determines if two <see cref="SiteRecoveryLicenseType"/> values are the same. </summary>
        public static bool operator ==(SiteRecoveryLicenseType left, SiteRecoveryLicenseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SiteRecoveryLicenseType"/> values are not the same. </summary>
        public static bool operator !=(SiteRecoveryLicenseType left, SiteRecoveryLicenseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SiteRecoveryLicenseType"/>. </summary>
        public static implicit operator SiteRecoveryLicenseType(string value) => new SiteRecoveryLicenseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SiteRecoveryLicenseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SiteRecoveryLicenseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}