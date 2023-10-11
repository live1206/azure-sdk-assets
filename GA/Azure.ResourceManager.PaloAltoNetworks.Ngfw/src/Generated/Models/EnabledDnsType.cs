// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Enabled DNS type values. </summary>
    public readonly partial struct EnabledDnsType : IEquatable<EnabledDnsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnabledDnsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnabledDnsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CustomValue = "CUSTOM";
        private const string AzureValue = "AZURE";

        /// <summary> CUSTOM. </summary>
        public static EnabledDnsType Custom { get; } = new EnabledDnsType(CustomValue);
        /// <summary> AZURE. </summary>
        public static EnabledDnsType Azure { get; } = new EnabledDnsType(AzureValue);
        /// <summary> Determines if two <see cref="EnabledDnsType"/> values are the same. </summary>
        public static bool operator ==(EnabledDnsType left, EnabledDnsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnabledDnsType"/> values are not the same. </summary>
        public static bool operator !=(EnabledDnsType left, EnabledDnsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnabledDnsType"/>. </summary>
        public static implicit operator EnabledDnsType(string value) => new EnabledDnsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnabledDnsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnabledDnsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}