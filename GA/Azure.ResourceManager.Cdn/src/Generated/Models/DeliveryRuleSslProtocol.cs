// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The protocol of an established TLS connection. </summary>
    public readonly partial struct DeliveryRuleSslProtocol : IEquatable<DeliveryRuleSslProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleSslProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeliveryRuleSslProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tls1_0Value = "TLSv1";
        private const string Tls1_1Value = "TLSv1.1";
        private const string Tls1_2Value = "TLSv1.2";
        /// <summary> Determines if two <see cref="DeliveryRuleSslProtocol"/> values are the same. </summary>
        public static bool operator ==(DeliveryRuleSslProtocol left, DeliveryRuleSslProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeliveryRuleSslProtocol"/> values are not the same. </summary>
        public static bool operator !=(DeliveryRuleSslProtocol left, DeliveryRuleSslProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeliveryRuleSslProtocol"/>. </summary>
        public static implicit operator DeliveryRuleSslProtocol(string value) => new DeliveryRuleSslProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeliveryRuleSslProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeliveryRuleSslProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}