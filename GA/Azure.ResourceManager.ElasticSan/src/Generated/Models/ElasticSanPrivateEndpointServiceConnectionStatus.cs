// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct ElasticSanPrivateEndpointServiceConnectionStatus : IEquatable<ElasticSanPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticSanPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticSanPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string FailedValue = "Failed";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static ElasticSanPrivateEndpointServiceConnectionStatus Pending { get; } = new ElasticSanPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static ElasticSanPrivateEndpointServiceConnectionStatus Approved { get; } = new ElasticSanPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Failed. </summary>
        public static ElasticSanPrivateEndpointServiceConnectionStatus Failed { get; } = new ElasticSanPrivateEndpointServiceConnectionStatus(FailedValue);
        /// <summary> Rejected. </summary>
        public static ElasticSanPrivateEndpointServiceConnectionStatus Rejected { get; } = new ElasticSanPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="ElasticSanPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ElasticSanPrivateEndpointServiceConnectionStatus left, ElasticSanPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticSanPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ElasticSanPrivateEndpointServiceConnectionStatus left, ElasticSanPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ElasticSanPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator ElasticSanPrivateEndpointServiceConnectionStatus(string value) => new ElasticSanPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticSanPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticSanPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}