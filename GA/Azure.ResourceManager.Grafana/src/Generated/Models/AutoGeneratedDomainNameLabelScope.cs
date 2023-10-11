// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> Scope for dns deterministic name hash calculation. </summary>
    public readonly partial struct AutoGeneratedDomainNameLabelScope : IEquatable<AutoGeneratedDomainNameLabelScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutoGeneratedDomainNameLabelScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutoGeneratedDomainNameLabelScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TenantReuseValue = "TenantReuse";

        /// <summary> TenantReuse. </summary>
        public static AutoGeneratedDomainNameLabelScope TenantReuse { get; } = new AutoGeneratedDomainNameLabelScope(TenantReuseValue);
        /// <summary> Determines if two <see cref="AutoGeneratedDomainNameLabelScope"/> values are the same. </summary>
        public static bool operator ==(AutoGeneratedDomainNameLabelScope left, AutoGeneratedDomainNameLabelScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutoGeneratedDomainNameLabelScope"/> values are not the same. </summary>
        public static bool operator !=(AutoGeneratedDomainNameLabelScope left, AutoGeneratedDomainNameLabelScope right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutoGeneratedDomainNameLabelScope"/>. </summary>
        public static implicit operator AutoGeneratedDomainNameLabelScope(string value) => new AutoGeneratedDomainNameLabelScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutoGeneratedDomainNameLabelScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutoGeneratedDomainNameLabelScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}