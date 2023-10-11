// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The provisioning state of the resource. </summary>
    public readonly partial struct SubscriptionProvisioningState : IEquatable<SubscriptionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SubscriptionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SubscriptionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Accepted. </summary>
        public static SubscriptionProvisioningState Accepted { get; } = new SubscriptionProvisioningState(AcceptedValue);
        /// <summary> Succeeded. </summary>
        public static SubscriptionProvisioningState Succeeded { get; } = new SubscriptionProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static SubscriptionProvisioningState Failed { get; } = new SubscriptionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="SubscriptionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SubscriptionProvisioningState left, SubscriptionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SubscriptionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SubscriptionProvisioningState left, SubscriptionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SubscriptionProvisioningState"/>. </summary>
        public static implicit operator SubscriptionProvisioningState(string value) => new SubscriptionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SubscriptionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SubscriptionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}