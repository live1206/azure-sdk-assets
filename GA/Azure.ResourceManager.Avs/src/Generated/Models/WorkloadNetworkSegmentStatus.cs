// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Segment status. </summary>
    public readonly partial struct WorkloadNetworkSegmentStatus : IEquatable<WorkloadNetworkSegmentStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkSegmentStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkloadNetworkSegmentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SuccessValue = "SUCCESS";
        private const string FailureValue = "FAILURE";

        /// <summary> SUCCESS. </summary>
        public static WorkloadNetworkSegmentStatus Success { get; } = new WorkloadNetworkSegmentStatus(SuccessValue);
        /// <summary> FAILURE. </summary>
        public static WorkloadNetworkSegmentStatus Failure { get; } = new WorkloadNetworkSegmentStatus(FailureValue);
        /// <summary> Determines if two <see cref="WorkloadNetworkSegmentStatus"/> values are the same. </summary>
        public static bool operator ==(WorkloadNetworkSegmentStatus left, WorkloadNetworkSegmentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkloadNetworkSegmentStatus"/> values are not the same. </summary>
        public static bool operator !=(WorkloadNetworkSegmentStatus left, WorkloadNetworkSegmentStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WorkloadNetworkSegmentStatus"/>. </summary>
        public static implicit operator WorkloadNetworkSegmentStatus(string value) => new WorkloadNetworkSegmentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkloadNetworkSegmentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkloadNetworkSegmentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}