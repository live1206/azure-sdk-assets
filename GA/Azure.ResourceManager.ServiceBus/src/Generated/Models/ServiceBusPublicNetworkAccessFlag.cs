// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> This determines if traffic is allowed over public network. By default it is enabled. </summary>
    public readonly partial struct ServiceBusPublicNetworkAccessFlag : IEquatable<ServiceBusPublicNetworkAccessFlag>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceBusPublicNetworkAccessFlag"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceBusPublicNetworkAccessFlag(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ServiceBusPublicNetworkAccessFlag Enabled { get; } = new ServiceBusPublicNetworkAccessFlag(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ServiceBusPublicNetworkAccessFlag Disabled { get; } = new ServiceBusPublicNetworkAccessFlag(DisabledValue);
        /// <summary> Determines if two <see cref="ServiceBusPublicNetworkAccessFlag"/> values are the same. </summary>
        public static bool operator ==(ServiceBusPublicNetworkAccessFlag left, ServiceBusPublicNetworkAccessFlag right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceBusPublicNetworkAccessFlag"/> values are not the same. </summary>
        public static bool operator !=(ServiceBusPublicNetworkAccessFlag left, ServiceBusPublicNetworkAccessFlag right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceBusPublicNetworkAccessFlag"/>. </summary>
        public static implicit operator ServiceBusPublicNetworkAccessFlag(string value) => new ServiceBusPublicNetworkAccessFlag(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceBusPublicNetworkAccessFlag other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceBusPublicNetworkAccessFlag other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}