// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The type of single sign on Secret Type. </summary>
    public readonly partial struct HostPoolSsoSecretType : IEquatable<HostPoolSsoSecretType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostPoolSsoSecretType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostPoolSsoSecretType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SharedKeyValue = "SharedKey";
        private const string CertificateValue = "Certificate";
        private const string SharedKeyInKeyVaultValue = "SharedKeyInKeyVault";
        private const string CertificateInKeyVaultValue = "CertificateInKeyVault";

        /// <summary> SharedKey. </summary>
        public static HostPoolSsoSecretType SharedKey { get; } = new HostPoolSsoSecretType(SharedKeyValue);
        /// <summary> Certificate. </summary>
        public static HostPoolSsoSecretType Certificate { get; } = new HostPoolSsoSecretType(CertificateValue);
        /// <summary> SharedKeyInKeyVault. </summary>
        public static HostPoolSsoSecretType SharedKeyInKeyVault { get; } = new HostPoolSsoSecretType(SharedKeyInKeyVaultValue);
        /// <summary> CertificateInKeyVault. </summary>
        public static HostPoolSsoSecretType CertificateInKeyVault { get; } = new HostPoolSsoSecretType(CertificateInKeyVaultValue);
        /// <summary> Determines if two <see cref="HostPoolSsoSecretType"/> values are the same. </summary>
        public static bool operator ==(HostPoolSsoSecretType left, HostPoolSsoSecretType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostPoolSsoSecretType"/> values are not the same. </summary>
        public static bool operator !=(HostPoolSsoSecretType left, HostPoolSsoSecretType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HostPoolSsoSecretType"/>. </summary>
        public static implicit operator HostPoolSsoSecretType(string value) => new HostPoolSsoSecretType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostPoolSsoSecretType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostPoolSsoSecretType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}