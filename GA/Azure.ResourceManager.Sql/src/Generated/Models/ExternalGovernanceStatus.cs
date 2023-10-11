// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Status of external governance. </summary>
    public readonly partial struct ExternalGovernanceStatus : IEquatable<ExternalGovernanceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExternalGovernanceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExternalGovernanceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ExternalGovernanceStatus Enabled { get; } = new ExternalGovernanceStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ExternalGovernanceStatus Disabled { get; } = new ExternalGovernanceStatus(DisabledValue);
        /// <summary> Determines if two <see cref="ExternalGovernanceStatus"/> values are the same. </summary>
        public static bool operator ==(ExternalGovernanceStatus left, ExternalGovernanceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExternalGovernanceStatus"/> values are not the same. </summary>
        public static bool operator !=(ExternalGovernanceStatus left, ExternalGovernanceStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExternalGovernanceStatus"/>. </summary>
        public static implicit operator ExternalGovernanceStatus(string value) => new ExternalGovernanceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExternalGovernanceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExternalGovernanceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}