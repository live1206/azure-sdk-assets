// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Chronicity of the availability transition. </summary>
    public readonly partial struct ReasonChronicityType : IEquatable<ReasonChronicityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReasonChronicityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReasonChronicityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TransientValue = "Transient";
        private const string PersistentValue = "Persistent";

        /// <summary> Transient. </summary>
        public static ReasonChronicityType Transient { get; } = new ReasonChronicityType(TransientValue);
        /// <summary> Persistent. </summary>
        public static ReasonChronicityType Persistent { get; } = new ReasonChronicityType(PersistentValue);
        /// <summary> Determines if two <see cref="ReasonChronicityType"/> values are the same. </summary>
        public static bool operator ==(ReasonChronicityType left, ReasonChronicityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReasonChronicityType"/> values are not the same. </summary>
        public static bool operator !=(ReasonChronicityType left, ReasonChronicityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReasonChronicityType"/>. </summary>
        public static implicit operator ReasonChronicityType(string value) => new ReasonChronicityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReasonChronicityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReasonChronicityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}