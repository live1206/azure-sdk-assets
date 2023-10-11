// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Status of the shared private link resource. </summary>
    public readonly partial struct SignalRSharedPrivateLinkResourceStatus : IEquatable<SignalRSharedPrivateLinkResourceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SignalRSharedPrivateLinkResourceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignalRSharedPrivateLinkResourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";
        private const string TimeoutValue = "Timeout";

        /// <summary> Pending. </summary>
        public static SignalRSharedPrivateLinkResourceStatus Pending { get; } = new SignalRSharedPrivateLinkResourceStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static SignalRSharedPrivateLinkResourceStatus Approved { get; } = new SignalRSharedPrivateLinkResourceStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static SignalRSharedPrivateLinkResourceStatus Rejected { get; } = new SignalRSharedPrivateLinkResourceStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static SignalRSharedPrivateLinkResourceStatus Disconnected { get; } = new SignalRSharedPrivateLinkResourceStatus(DisconnectedValue);
        /// <summary> Timeout. </summary>
        public static SignalRSharedPrivateLinkResourceStatus Timeout { get; } = new SignalRSharedPrivateLinkResourceStatus(TimeoutValue);
        /// <summary> Determines if two <see cref="SignalRSharedPrivateLinkResourceStatus"/> values are the same. </summary>
        public static bool operator ==(SignalRSharedPrivateLinkResourceStatus left, SignalRSharedPrivateLinkResourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SignalRSharedPrivateLinkResourceStatus"/> values are not the same. </summary>
        public static bool operator !=(SignalRSharedPrivateLinkResourceStatus left, SignalRSharedPrivateLinkResourceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SignalRSharedPrivateLinkResourceStatus"/>. </summary>
        public static implicit operator SignalRSharedPrivateLinkResourceStatus(string value) => new SignalRSharedPrivateLinkResourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SignalRSharedPrivateLinkResourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SignalRSharedPrivateLinkResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
