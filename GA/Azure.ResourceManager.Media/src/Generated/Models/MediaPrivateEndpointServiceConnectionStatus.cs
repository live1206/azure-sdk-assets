// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct MediaPrivateEndpointServiceConnectionStatus : IEquatable<MediaPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static MediaPrivateEndpointServiceConnectionStatus Pending { get; } = new MediaPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static MediaPrivateEndpointServiceConnectionStatus Approved { get; } = new MediaPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static MediaPrivateEndpointServiceConnectionStatus Rejected { get; } = new MediaPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="MediaPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(MediaPrivateEndpointServiceConnectionStatus left, MediaPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(MediaPrivateEndpointServiceConnectionStatus left, MediaPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator MediaPrivateEndpointServiceConnectionStatus(string value) => new MediaPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}