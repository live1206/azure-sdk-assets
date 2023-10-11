// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The application control policy enforcement/protection mode of the machine group. </summary>
    public readonly partial struct AdaptiveApplicationControlEnforcementMode : IEquatable<AdaptiveApplicationControlEnforcementMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdaptiveApplicationControlEnforcementMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdaptiveApplicationControlEnforcementMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuditValue = "Audit";
        private const string EnforceValue = "Enforce";
        private const string NoneValue = "None";

        /// <summary> Audit. </summary>
        public static AdaptiveApplicationControlEnforcementMode Audit { get; } = new AdaptiveApplicationControlEnforcementMode(AuditValue);
        /// <summary> Enforce. </summary>
        public static AdaptiveApplicationControlEnforcementMode Enforce { get; } = new AdaptiveApplicationControlEnforcementMode(EnforceValue);
        /// <summary> None. </summary>
        public static AdaptiveApplicationControlEnforcementMode None { get; } = new AdaptiveApplicationControlEnforcementMode(NoneValue);
        /// <summary> Determines if two <see cref="AdaptiveApplicationControlEnforcementMode"/> values are the same. </summary>
        public static bool operator ==(AdaptiveApplicationControlEnforcementMode left, AdaptiveApplicationControlEnforcementMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdaptiveApplicationControlEnforcementMode"/> values are not the same. </summary>
        public static bool operator !=(AdaptiveApplicationControlEnforcementMode left, AdaptiveApplicationControlEnforcementMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AdaptiveApplicationControlEnforcementMode"/>. </summary>
        public static implicit operator AdaptiveApplicationControlEnforcementMode(string value) => new AdaptiveApplicationControlEnforcementMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdaptiveApplicationControlEnforcementMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdaptiveApplicationControlEnforcementMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
