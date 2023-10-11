// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes the action that shall be taken when the certificate is removed from Key Vault. </summary>
    public readonly partial struct CertificateDeleteAction : IEquatable<CertificateDeleteAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CertificateDeleteAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CertificateDeleteAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoActionValue = "NoAction";

        /// <summary> NoAction. </summary>
        public static CertificateDeleteAction NoAction { get; } = new CertificateDeleteAction(NoActionValue);
        /// <summary> Determines if two <see cref="CertificateDeleteAction"/> values are the same. </summary>
        public static bool operator ==(CertificateDeleteAction left, CertificateDeleteAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CertificateDeleteAction"/> values are not the same. </summary>
        public static bool operator !=(CertificateDeleteAction left, CertificateDeleteAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CertificateDeleteAction"/>. </summary>
        public static implicit operator CertificateDeleteAction(string value) => new CertificateDeleteAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CertificateDeleteAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CertificateDeleteAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
