// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The local certificate store location. </summary>
    public readonly partial struct ClusterCertificateStoreName : IEquatable<ClusterCertificateStoreName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterCertificateStoreName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterCertificateStoreName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AddressBookValue = "AddressBook";
        private const string AuthRootValue = "AuthRoot";
        private const string CertificateAuthorityValue = "CertificateAuthority";
        private const string DisallowedValue = "Disallowed";
        private const string MyValue = "My";
        private const string RootValue = "Root";
        private const string TrustedPeopleValue = "TrustedPeople";
        private const string TrustedPublisherValue = "TrustedPublisher";

        /// <summary> AddressBook. </summary>
        public static ClusterCertificateStoreName AddressBook { get; } = new ClusterCertificateStoreName(AddressBookValue);
        /// <summary> AuthRoot. </summary>
        public static ClusterCertificateStoreName AuthRoot { get; } = new ClusterCertificateStoreName(AuthRootValue);
        /// <summary> CertificateAuthority. </summary>
        public static ClusterCertificateStoreName CertificateAuthority { get; } = new ClusterCertificateStoreName(CertificateAuthorityValue);
        /// <summary> Disallowed. </summary>
        public static ClusterCertificateStoreName Disallowed { get; } = new ClusterCertificateStoreName(DisallowedValue);
        /// <summary> My. </summary>
        public static ClusterCertificateStoreName My { get; } = new ClusterCertificateStoreName(MyValue);
        /// <summary> Root. </summary>
        public static ClusterCertificateStoreName Root { get; } = new ClusterCertificateStoreName(RootValue);
        /// <summary> TrustedPeople. </summary>
        public static ClusterCertificateStoreName TrustedPeople { get; } = new ClusterCertificateStoreName(TrustedPeopleValue);
        /// <summary> TrustedPublisher. </summary>
        public static ClusterCertificateStoreName TrustedPublisher { get; } = new ClusterCertificateStoreName(TrustedPublisherValue);
        /// <summary> Determines if two <see cref="ClusterCertificateStoreName"/> values are the same. </summary>
        public static bool operator ==(ClusterCertificateStoreName left, ClusterCertificateStoreName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterCertificateStoreName"/> values are not the same. </summary>
        public static bool operator !=(ClusterCertificateStoreName left, ClusterCertificateStoreName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterCertificateStoreName"/>. </summary>
        public static implicit operator ClusterCertificateStoreName(string value) => new ClusterCertificateStoreName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterCertificateStoreName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterCertificateStoreName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}