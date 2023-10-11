// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Valid values are JobStorageAccount and SystemAccount. If set to JobStorageAccount, this requires the user to also specify jobStorageAccount property. . </summary>
    public readonly partial struct StreamingJobContentStoragePolicy : IEquatable<StreamingJobContentStoragePolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StreamingJobContentStoragePolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StreamingJobContentStoragePolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemAccountValue = "SystemAccount";
        private const string JobStorageAccountValue = "JobStorageAccount";

        /// <summary> SystemAccount. </summary>
        public static StreamingJobContentStoragePolicy SystemAccount { get; } = new StreamingJobContentStoragePolicy(SystemAccountValue);
        /// <summary> JobStorageAccount. </summary>
        public static StreamingJobContentStoragePolicy JobStorageAccount { get; } = new StreamingJobContentStoragePolicy(JobStorageAccountValue);
        /// <summary> Determines if two <see cref="StreamingJobContentStoragePolicy"/> values are the same. </summary>
        public static bool operator ==(StreamingJobContentStoragePolicy left, StreamingJobContentStoragePolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StreamingJobContentStoragePolicy"/> values are not the same. </summary>
        public static bool operator !=(StreamingJobContentStoragePolicy left, StreamingJobContentStoragePolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StreamingJobContentStoragePolicy"/>. </summary>
        public static implicit operator StreamingJobContentStoragePolicy(string value) => new StreamingJobContentStoragePolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StreamingJobContentStoragePolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StreamingJobContentStoragePolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}