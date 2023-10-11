// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The type of direct peering. </summary>
    public readonly partial struct DirectPeeringType : IEquatable<DirectPeeringType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DirectPeeringType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DirectPeeringType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EdgeValue = "Edge";
        private const string TransitValue = "Transit";
        private const string CdnValue = "Cdn";
        private const string InternalValue = "Internal";
        private const string IxValue = "Ix";
        private const string IxRsValue = "IxRs";
        private const string VoiceValue = "Voice";
        private const string EdgeZoneForOperatorsValue = "EdgeZoneForOperators";

        /// <summary> Edge. </summary>
        public static DirectPeeringType Edge { get; } = new DirectPeeringType(EdgeValue);
        /// <summary> Transit. </summary>
        public static DirectPeeringType Transit { get; } = new DirectPeeringType(TransitValue);
        /// <summary> Cdn. </summary>
        public static DirectPeeringType Cdn { get; } = new DirectPeeringType(CdnValue);
        /// <summary> Internal. </summary>
        public static DirectPeeringType Internal { get; } = new DirectPeeringType(InternalValue);
        /// <summary> Ix. </summary>
        public static DirectPeeringType Ix { get; } = new DirectPeeringType(IxValue);
        /// <summary> IxRs. </summary>
        public static DirectPeeringType IxRs { get; } = new DirectPeeringType(IxRsValue);
        /// <summary> Voice. </summary>
        public static DirectPeeringType Voice { get; } = new DirectPeeringType(VoiceValue);
        /// <summary> EdgeZoneForOperators. </summary>
        public static DirectPeeringType EdgeZoneForOperators { get; } = new DirectPeeringType(EdgeZoneForOperatorsValue);
        /// <summary> Determines if two <see cref="DirectPeeringType"/> values are the same. </summary>
        public static bool operator ==(DirectPeeringType left, DirectPeeringType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DirectPeeringType"/> values are not the same. </summary>
        public static bool operator !=(DirectPeeringType left, DirectPeeringType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DirectPeeringType"/>. </summary>
        public static implicit operator DirectPeeringType(string value) => new DirectPeeringType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DirectPeeringType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DirectPeeringType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}