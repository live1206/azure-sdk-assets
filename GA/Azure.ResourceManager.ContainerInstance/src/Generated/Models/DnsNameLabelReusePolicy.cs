// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The value representing the security enum. The 'Unsecure' value is the default value if not selected and means the object's domain name label is not secured against subdomain takeover. The 'TenantReuse' value is the default value if selected and means the object's domain name label can be reused within the same tenant. The 'SubscriptionReuse' value means the object's domain name label can be reused within the same subscription. The 'ResourceGroupReuse' value means the object's domain name label can be reused within the same resource group. The 'NoReuse' value means the object's domain name label cannot be reused within the same resource group, subscription, or tenant. </summary>
    public readonly partial struct DnsNameLabelReusePolicy : IEquatable<DnsNameLabelReusePolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DnsNameLabelReusePolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DnsNameLabelReusePolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnsecureValue = "Unsecure";
        private const string TenantReuseValue = "TenantReuse";
        private const string SubscriptionReuseValue = "SubscriptionReuse";
        private const string ResourceGroupReuseValue = "ResourceGroupReuse";
        private const string NoReuseValue = "Noreuse";

        /// <summary> Unsecure. </summary>
        public static DnsNameLabelReusePolicy Unsecure { get; } = new DnsNameLabelReusePolicy(UnsecureValue);
        /// <summary> TenantReuse. </summary>
        public static DnsNameLabelReusePolicy TenantReuse { get; } = new DnsNameLabelReusePolicy(TenantReuseValue);
        /// <summary> SubscriptionReuse. </summary>
        public static DnsNameLabelReusePolicy SubscriptionReuse { get; } = new DnsNameLabelReusePolicy(SubscriptionReuseValue);
        /// <summary> ResourceGroupReuse. </summary>
        public static DnsNameLabelReusePolicy ResourceGroupReuse { get; } = new DnsNameLabelReusePolicy(ResourceGroupReuseValue);
        /// <summary> Noreuse. </summary>
        public static DnsNameLabelReusePolicy NoReuse { get; } = new DnsNameLabelReusePolicy(NoReuseValue);
        /// <summary> Determines if two <see cref="DnsNameLabelReusePolicy"/> values are the same. </summary>
        public static bool operator ==(DnsNameLabelReusePolicy left, DnsNameLabelReusePolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DnsNameLabelReusePolicy"/> values are not the same. </summary>
        public static bool operator !=(DnsNameLabelReusePolicy left, DnsNameLabelReusePolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DnsNameLabelReusePolicy"/>. </summary>
        public static implicit operator DnsNameLabelReusePolicy(string value) => new DnsNameLabelReusePolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DnsNameLabelReusePolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DnsNameLabelReusePolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
