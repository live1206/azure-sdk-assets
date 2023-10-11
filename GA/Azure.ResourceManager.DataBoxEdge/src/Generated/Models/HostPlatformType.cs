// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Platform where the runtime is hosted. </summary>
    public readonly partial struct HostPlatformType : IEquatable<HostPlatformType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostPlatformType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostPlatformType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KubernetesClusterValue = "KubernetesCluster";
        private const string LinuxVmValue = "LinuxVM";

        /// <summary> KubernetesCluster. </summary>
        public static HostPlatformType KubernetesCluster { get; } = new HostPlatformType(KubernetesClusterValue);
        /// <summary> LinuxVM. </summary>
        public static HostPlatformType LinuxVm { get; } = new HostPlatformType(LinuxVmValue);
        /// <summary> Determines if two <see cref="HostPlatformType"/> values are the same. </summary>
        public static bool operator ==(HostPlatformType left, HostPlatformType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostPlatformType"/> values are not the same. </summary>
        public static bool operator !=(HostPlatformType left, HostPlatformType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HostPlatformType"/>. </summary>
        public static implicit operator HostPlatformType(string value) => new HostPlatformType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostPlatformType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostPlatformType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}