// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Specify which proxy mode to use ('IPTABLES' or 'IPVS'). </summary>
    public readonly partial struct ContainerServiceNetworkProfileKubeProxyMode : IEquatable<ContainerServiceNetworkProfileKubeProxyMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNetworkProfileKubeProxyMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceNetworkProfileKubeProxyMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPTablesValue = "IPTABLES";
        private const string IPVSValue = "IPVS";

        /// <summary> IPTables proxy mode. </summary>
        public static ContainerServiceNetworkProfileKubeProxyMode IPTables { get; } = new ContainerServiceNetworkProfileKubeProxyMode(IPTablesValue);
        /// <summary> IPVS proxy mode. Must be using Kubernetes version &gt;= 1.22. </summary>
        public static ContainerServiceNetworkProfileKubeProxyMode IPVS { get; } = new ContainerServiceNetworkProfileKubeProxyMode(IPVSValue);
        /// <summary> Determines if two <see cref="ContainerServiceNetworkProfileKubeProxyMode"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceNetworkProfileKubeProxyMode left, ContainerServiceNetworkProfileKubeProxyMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceNetworkProfileKubeProxyMode"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceNetworkProfileKubeProxyMode left, ContainerServiceNetworkProfileKubeProxyMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServiceNetworkProfileKubeProxyMode"/>. </summary>
        public static implicit operator ContainerServiceNetworkProfileKubeProxyMode(string value) => new ContainerServiceNetworkProfileKubeProxyMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceNetworkProfileKubeProxyMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceNetworkProfileKubeProxyMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
