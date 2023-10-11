// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets certificate preference if secure communication is enabled. </summary>
    public readonly partial struct SapSslPreference : IEquatable<SapSslPreference>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapSslPreference"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapSslPreference(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string RootCertificateValue = "RootCertificate";
        private const string ServerCertificateValue = "ServerCertificate";

        /// <summary> Disabled. </summary>
        public static SapSslPreference Disabled { get; } = new SapSslPreference(DisabledValue);
        /// <summary> RootCertificate. </summary>
        public static SapSslPreference RootCertificate { get; } = new SapSslPreference(RootCertificateValue);
        /// <summary> ServerCertificate. </summary>
        public static SapSslPreference ServerCertificate { get; } = new SapSslPreference(ServerCertificateValue);
        /// <summary> Determines if two <see cref="SapSslPreference"/> values are the same. </summary>
        public static bool operator ==(SapSslPreference left, SapSslPreference right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapSslPreference"/> values are not the same. </summary>
        public static bool operator !=(SapSslPreference left, SapSslPreference right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SapSslPreference"/>. </summary>
        public static implicit operator SapSslPreference(string value) => new SapSslPreference(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapSslPreference other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapSslPreference other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}