// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The type of this referenced entity. </summary>
    public readonly partial struct SynapseIntegrationRuntimeEntityReferenceType : IEquatable<SynapseIntegrationRuntimeEntityReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeEntityReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseIntegrationRuntimeEntityReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntegrationRuntimeReferenceValue = "IntegrationRuntimeReference";
        private const string LinkedServiceReferenceValue = "LinkedServiceReference";

        /// <summary> IntegrationRuntimeReference. </summary>
        public static SynapseIntegrationRuntimeEntityReferenceType IntegrationRuntimeReference { get; } = new SynapseIntegrationRuntimeEntityReferenceType(IntegrationRuntimeReferenceValue);
        /// <summary> LinkedServiceReference. </summary>
        public static SynapseIntegrationRuntimeEntityReferenceType LinkedServiceReference { get; } = new SynapseIntegrationRuntimeEntityReferenceType(LinkedServiceReferenceValue);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeEntityReferenceType"/> values are the same. </summary>
        public static bool operator ==(SynapseIntegrationRuntimeEntityReferenceType left, SynapseIntegrationRuntimeEntityReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeEntityReferenceType"/> values are not the same. </summary>
        public static bool operator !=(SynapseIntegrationRuntimeEntityReferenceType left, SynapseIntegrationRuntimeEntityReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseIntegrationRuntimeEntityReferenceType"/>. </summary>
        public static implicit operator SynapseIntegrationRuntimeEntityReferenceType(string value) => new SynapseIntegrationRuntimeEntityReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseIntegrationRuntimeEntityReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseIntegrationRuntimeEntityReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}