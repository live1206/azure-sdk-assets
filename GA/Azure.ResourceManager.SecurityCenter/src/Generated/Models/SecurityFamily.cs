// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The security family of the discovered solution. </summary>
    public readonly partial struct SecurityFamily : IEquatable<SecurityFamily>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityFamily"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WafValue = "Waf";
        private const string NgfwValue = "Ngfw";
        private const string SaasWafValue = "SaasWaf";
        private const string VulnerabilityAssessmentValue = "Va";

        /// <summary> Waf. </summary>
        public static SecurityFamily Waf { get; } = new SecurityFamily(WafValue);
        /// <summary> Ngfw. </summary>
        public static SecurityFamily Ngfw { get; } = new SecurityFamily(NgfwValue);
        /// <summary> SaasWaf. </summary>
        public static SecurityFamily SaasWaf { get; } = new SecurityFamily(SaasWafValue);
        /// <summary> Va. </summary>
        public static SecurityFamily VulnerabilityAssessment { get; } = new SecurityFamily(VulnerabilityAssessmentValue);
        /// <summary> Determines if two <see cref="SecurityFamily"/> values are the same. </summary>
        public static bool operator ==(SecurityFamily left, SecurityFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityFamily"/> values are not the same. </summary>
        public static bool operator !=(SecurityFamily left, SecurityFamily right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityFamily"/>. </summary>
        public static implicit operator SecurityFamily(string value) => new SecurityFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
