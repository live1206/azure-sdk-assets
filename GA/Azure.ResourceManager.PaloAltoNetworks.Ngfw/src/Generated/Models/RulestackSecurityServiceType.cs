// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The RulestackSecurityServiceType. </summary>
    public readonly partial struct RulestackSecurityServiceType : IEquatable<RulestackSecurityServiceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RulestackSecurityServiceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RulestackSecurityServiceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AntiSpywareValue = "antiSpyware";
        private const string AntiVirusValue = "antiVirus";
        private const string IPsVulnerabilityValue = "ipsVulnerability";
        private const string UrlFilteringValue = "urlFiltering";
        private const string FileBlockingValue = "fileBlocking";
        private const string DnsSubscriptionValue = "dnsSubscription";

        /// <summary> antiSpyware. </summary>
        public static RulestackSecurityServiceType AntiSpyware { get; } = new RulestackSecurityServiceType(AntiSpywareValue);
        /// <summary> antiVirus. </summary>
        public static RulestackSecurityServiceType AntiVirus { get; } = new RulestackSecurityServiceType(AntiVirusValue);
        /// <summary> ipsVulnerability. </summary>
        public static RulestackSecurityServiceType IPsVulnerability { get; } = new RulestackSecurityServiceType(IPsVulnerabilityValue);
        /// <summary> urlFiltering. </summary>
        public static RulestackSecurityServiceType UrlFiltering { get; } = new RulestackSecurityServiceType(UrlFilteringValue);
        /// <summary> fileBlocking. </summary>
        public static RulestackSecurityServiceType FileBlocking { get; } = new RulestackSecurityServiceType(FileBlockingValue);
        /// <summary> dnsSubscription. </summary>
        public static RulestackSecurityServiceType DnsSubscription { get; } = new RulestackSecurityServiceType(DnsSubscriptionValue);
        /// <summary> Determines if two <see cref="RulestackSecurityServiceType"/> values are the same. </summary>
        public static bool operator ==(RulestackSecurityServiceType left, RulestackSecurityServiceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RulestackSecurityServiceType"/> values are not the same. </summary>
        public static bool operator !=(RulestackSecurityServiceType left, RulestackSecurityServiceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RulestackSecurityServiceType"/>. </summary>
        public static implicit operator RulestackSecurityServiceType(string value) => new RulestackSecurityServiceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RulestackSecurityServiceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RulestackSecurityServiceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
