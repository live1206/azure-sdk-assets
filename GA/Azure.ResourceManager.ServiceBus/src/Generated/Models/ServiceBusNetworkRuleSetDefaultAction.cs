// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Default Action for Network Rule Set. </summary>
    public readonly partial struct ServiceBusNetworkRuleSetDefaultAction : IEquatable<ServiceBusNetworkRuleSetDefaultAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceBusNetworkRuleSetDefaultAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceBusNetworkRuleSetDefaultAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static ServiceBusNetworkRuleSetDefaultAction Allow { get; } = new ServiceBusNetworkRuleSetDefaultAction(AllowValue);
        /// <summary> Deny. </summary>
        public static ServiceBusNetworkRuleSetDefaultAction Deny { get; } = new ServiceBusNetworkRuleSetDefaultAction(DenyValue);
        /// <summary> Determines if two <see cref="ServiceBusNetworkRuleSetDefaultAction"/> values are the same. </summary>
        public static bool operator ==(ServiceBusNetworkRuleSetDefaultAction left, ServiceBusNetworkRuleSetDefaultAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceBusNetworkRuleSetDefaultAction"/> values are not the same. </summary>
        public static bool operator !=(ServiceBusNetworkRuleSetDefaultAction left, ServiceBusNetworkRuleSetDefaultAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceBusNetworkRuleSetDefaultAction"/>. </summary>
        public static implicit operator ServiceBusNetworkRuleSetDefaultAction(string value) => new ServiceBusNetworkRuleSetDefaultAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceBusNetworkRuleSetDefaultAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceBusNetworkRuleSetDefaultAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}