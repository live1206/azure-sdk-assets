// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The OS architecture. </summary>
    public readonly partial struct ContainerRegistryOSArchitecture : IEquatable<ContainerRegistryOSArchitecture>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryOSArchitecture"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryOSArchitecture(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Amd64Value = "amd64";
        private const string X86Value = "x86";
        private const string ThreeHundredEightySixValue = "386";
        private const string ArmValue = "arm";
        private const string Arm64Value = "arm64";

        /// <summary> amd64. </summary>
        public static ContainerRegistryOSArchitecture Amd64 { get; } = new ContainerRegistryOSArchitecture(Amd64Value);
        /// <summary> x86. </summary>
        public static ContainerRegistryOSArchitecture X86 { get; } = new ContainerRegistryOSArchitecture(X86Value);
        /// <summary> 386. </summary>
        public static ContainerRegistryOSArchitecture ThreeHundredEightySix { get; } = new ContainerRegistryOSArchitecture(ThreeHundredEightySixValue);
        /// <summary> arm. </summary>
        public static ContainerRegistryOSArchitecture Arm { get; } = new ContainerRegistryOSArchitecture(ArmValue);
        /// <summary> arm64. </summary>
        public static ContainerRegistryOSArchitecture Arm64 { get; } = new ContainerRegistryOSArchitecture(Arm64Value);
        /// <summary> Determines if two <see cref="ContainerRegistryOSArchitecture"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryOSArchitecture left, ContainerRegistryOSArchitecture right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryOSArchitecture"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryOSArchitecture left, ContainerRegistryOSArchitecture right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryOSArchitecture"/>. </summary>
        public static implicit operator ContainerRegistryOSArchitecture(string value) => new ContainerRegistryOSArchitecture(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryOSArchitecture other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryOSArchitecture other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}