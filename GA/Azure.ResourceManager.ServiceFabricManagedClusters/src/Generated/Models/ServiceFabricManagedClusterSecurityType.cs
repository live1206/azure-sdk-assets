// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Specifies the security type of the nodeType. Only TrustedLaunch is currently supported. </summary>
    public readonly partial struct ServiceFabricManagedClusterSecurityType : IEquatable<ServiceFabricManagedClusterSecurityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterSecurityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceFabricManagedClusterSecurityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrustedLaunchValue = "TrustedLaunch";

        /// <summary> Trusted Launch is a security type that secures generation 2 virtual machines. </summary>
        public static ServiceFabricManagedClusterSecurityType TrustedLaunch { get; } = new ServiceFabricManagedClusterSecurityType(TrustedLaunchValue);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterSecurityType"/> values are the same. </summary>
        public static bool operator ==(ServiceFabricManagedClusterSecurityType left, ServiceFabricManagedClusterSecurityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterSecurityType"/> values are not the same. </summary>
        public static bool operator !=(ServiceFabricManagedClusterSecurityType left, ServiceFabricManagedClusterSecurityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceFabricManagedClusterSecurityType"/>. </summary>
        public static implicit operator ServiceFabricManagedClusterSecurityType(string value) => new ServiceFabricManagedClusterSecurityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceFabricManagedClusterSecurityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceFabricManagedClusterSecurityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}