// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Specifies the SKU name of the cluster. Required on PUT (CreateOrUpdate) requests. </summary>
    public readonly partial struct StreamAnalyticsClusterSkuName : IEquatable<StreamAnalyticsClusterSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsClusterSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StreamAnalyticsClusterSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";

        /// <summary> The default SKU. </summary>
        public static StreamAnalyticsClusterSkuName Default { get; } = new StreamAnalyticsClusterSkuName(DefaultValue);
        /// <summary> Determines if two <see cref="StreamAnalyticsClusterSkuName"/> values are the same. </summary>
        public static bool operator ==(StreamAnalyticsClusterSkuName left, StreamAnalyticsClusterSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StreamAnalyticsClusterSkuName"/> values are not the same. </summary>
        public static bool operator !=(StreamAnalyticsClusterSkuName left, StreamAnalyticsClusterSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StreamAnalyticsClusterSkuName"/>. </summary>
        public static implicit operator StreamAnalyticsClusterSkuName(string value) => new StreamAnalyticsClusterSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StreamAnalyticsClusterSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StreamAnalyticsClusterSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}