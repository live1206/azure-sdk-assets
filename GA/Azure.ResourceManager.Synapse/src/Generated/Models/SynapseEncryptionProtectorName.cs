// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The SynapseEncryptionProtectorName. </summary>
    public readonly partial struct SynapseEncryptionProtectorName : IEquatable<SynapseEncryptionProtectorName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseEncryptionProtectorName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseEncryptionProtectorName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "current";

        /// <summary> current. </summary>
        public static SynapseEncryptionProtectorName Current { get; } = new SynapseEncryptionProtectorName(CurrentValue);
        /// <summary> Determines if two <see cref="SynapseEncryptionProtectorName"/> values are the same. </summary>
        public static bool operator ==(SynapseEncryptionProtectorName left, SynapseEncryptionProtectorName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseEncryptionProtectorName"/> values are not the same. </summary>
        public static bool operator !=(SynapseEncryptionProtectorName left, SynapseEncryptionProtectorName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseEncryptionProtectorName"/>. </summary>
        public static implicit operator SynapseEncryptionProtectorName(string value) => new SynapseEncryptionProtectorName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseEncryptionProtectorName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseEncryptionProtectorName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}