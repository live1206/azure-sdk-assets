// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The level of notification. </summary>
    public readonly partial struct ClusterNotificationLevel : IEquatable<ClusterNotificationLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterNotificationLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterNotificationLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CriticalValue = "Critical";
        private const string AllValue = "All";

        /// <summary> Receive only critical notifications. </summary>
        public static ClusterNotificationLevel Critical { get; } = new ClusterNotificationLevel(CriticalValue);
        /// <summary> Receive all notifications. </summary>
        public static ClusterNotificationLevel All { get; } = new ClusterNotificationLevel(AllValue);
        /// <summary> Determines if two <see cref="ClusterNotificationLevel"/> values are the same. </summary>
        public static bool operator ==(ClusterNotificationLevel left, ClusterNotificationLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterNotificationLevel"/> values are not the same. </summary>
        public static bool operator !=(ClusterNotificationLevel left, ClusterNotificationLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterNotificationLevel"/>. </summary>
        public static implicit operator ClusterNotificationLevel(string value) => new ClusterNotificationLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterNotificationLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterNotificationLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}