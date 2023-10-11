// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Status of the connection. </summary>
    public readonly partial struct ServiceBusPrivateLinkConnectionStatus : IEquatable<ServiceBusPrivateLinkConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceBusPrivateLinkConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceBusPrivateLinkConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static ServiceBusPrivateLinkConnectionStatus Pending { get; } = new ServiceBusPrivateLinkConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static ServiceBusPrivateLinkConnectionStatus Approved { get; } = new ServiceBusPrivateLinkConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static ServiceBusPrivateLinkConnectionStatus Rejected { get; } = new ServiceBusPrivateLinkConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static ServiceBusPrivateLinkConnectionStatus Disconnected { get; } = new ServiceBusPrivateLinkConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="ServiceBusPrivateLinkConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ServiceBusPrivateLinkConnectionStatus left, ServiceBusPrivateLinkConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceBusPrivateLinkConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ServiceBusPrivateLinkConnectionStatus left, ServiceBusPrivateLinkConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceBusPrivateLinkConnectionStatus"/>. </summary>
        public static implicit operator ServiceBusPrivateLinkConnectionStatus(string value) => new ServiceBusPrivateLinkConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceBusPrivateLinkConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceBusPrivateLinkConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}