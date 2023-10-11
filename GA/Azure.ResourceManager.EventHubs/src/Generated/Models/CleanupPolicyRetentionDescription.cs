// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Enumerates the possible values for cleanup policy. </summary>
    public readonly partial struct CleanupPolicyRetentionDescription : IEquatable<CleanupPolicyRetentionDescription>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CleanupPolicyRetentionDescription"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CleanupPolicyRetentionDescription(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "Delete";
        private const string CompactionValue = "Compaction";

        /// <summary> Delete. </summary>
        public static CleanupPolicyRetentionDescription Delete { get; } = new CleanupPolicyRetentionDescription(DeleteValue);
        /// <summary> Compaction. </summary>
        public static CleanupPolicyRetentionDescription Compaction { get; } = new CleanupPolicyRetentionDescription(CompactionValue);
        /// <summary> Determines if two <see cref="CleanupPolicyRetentionDescription"/> values are the same. </summary>
        public static bool operator ==(CleanupPolicyRetentionDescription left, CleanupPolicyRetentionDescription right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CleanupPolicyRetentionDescription"/> values are not the same. </summary>
        public static bool operator !=(CleanupPolicyRetentionDescription left, CleanupPolicyRetentionDescription right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CleanupPolicyRetentionDescription"/>. </summary>
        public static implicit operator CleanupPolicyRetentionDescription(string value) => new CleanupPolicyRetentionDescription(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CleanupPolicyRetentionDescription other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CleanupPolicyRetentionDescription other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}