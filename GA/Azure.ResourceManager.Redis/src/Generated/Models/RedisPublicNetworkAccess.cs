// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints are the exclusive access method. Default value is 'Enabled'. </summary>
    public readonly partial struct RedisPublicNetworkAccess : IEquatable<RedisPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static RedisPublicNetworkAccess Enabled { get; } = new RedisPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static RedisPublicNetworkAccess Disabled { get; } = new RedisPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="RedisPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(RedisPublicNetworkAccess left, RedisPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(RedisPublicNetworkAccess left, RedisPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisPublicNetworkAccess"/>. </summary>
        public static implicit operator RedisPublicNetworkAccess(string value) => new RedisPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}