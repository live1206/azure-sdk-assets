// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Status of the shared private link resource. </summary>
    public readonly partial struct WebPubSubSharedPrivateLinkStatus : IEquatable<WebPubSubSharedPrivateLinkStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebPubSubSharedPrivateLinkStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebPubSubSharedPrivateLinkStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";
        private const string TimeoutValue = "Timeout";

        /// <summary> Pending. </summary>
        public static WebPubSubSharedPrivateLinkStatus Pending { get; } = new WebPubSubSharedPrivateLinkStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static WebPubSubSharedPrivateLinkStatus Approved { get; } = new WebPubSubSharedPrivateLinkStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static WebPubSubSharedPrivateLinkStatus Rejected { get; } = new WebPubSubSharedPrivateLinkStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static WebPubSubSharedPrivateLinkStatus Disconnected { get; } = new WebPubSubSharedPrivateLinkStatus(DisconnectedValue);
        /// <summary> Timeout. </summary>
        public static WebPubSubSharedPrivateLinkStatus Timeout { get; } = new WebPubSubSharedPrivateLinkStatus(TimeoutValue);
        /// <summary> Determines if two <see cref="WebPubSubSharedPrivateLinkStatus"/> values are the same. </summary>
        public static bool operator ==(WebPubSubSharedPrivateLinkStatus left, WebPubSubSharedPrivateLinkStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebPubSubSharedPrivateLinkStatus"/> values are not the same. </summary>
        public static bool operator !=(WebPubSubSharedPrivateLinkStatus left, WebPubSubSharedPrivateLinkStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebPubSubSharedPrivateLinkStatus"/>. </summary>
        public static implicit operator WebPubSubSharedPrivateLinkStatus(string value) => new WebPubSubSharedPrivateLinkStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebPubSubSharedPrivateLinkStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebPubSubSharedPrivateLinkStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}