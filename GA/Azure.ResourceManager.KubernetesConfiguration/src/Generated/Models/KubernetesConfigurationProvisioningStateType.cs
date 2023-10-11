// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> The provisioning state of the resource provider. </summary>
    public readonly partial struct KubernetesConfigurationProvisioningStateType : IEquatable<KubernetesConfigurationProvisioningStateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesConfigurationProvisioningStateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesConfigurationProvisioningStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string DeletingValue = "Deleting";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Accepted. </summary>
        public static KubernetesConfigurationProvisioningStateType Accepted { get; } = new KubernetesConfigurationProvisioningStateType(AcceptedValue);
        /// <summary> Deleting. </summary>
        public static KubernetesConfigurationProvisioningStateType Deleting { get; } = new KubernetesConfigurationProvisioningStateType(DeletingValue);
        /// <summary> Running. </summary>
        public static KubernetesConfigurationProvisioningStateType Running { get; } = new KubernetesConfigurationProvisioningStateType(RunningValue);
        /// <summary> Succeeded. </summary>
        public static KubernetesConfigurationProvisioningStateType Succeeded { get; } = new KubernetesConfigurationProvisioningStateType(SucceededValue);
        /// <summary> Failed. </summary>
        public static KubernetesConfigurationProvisioningStateType Failed { get; } = new KubernetesConfigurationProvisioningStateType(FailedValue);
        /// <summary> Determines if two <see cref="KubernetesConfigurationProvisioningStateType"/> values are the same. </summary>
        public static bool operator ==(KubernetesConfigurationProvisioningStateType left, KubernetesConfigurationProvisioningStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesConfigurationProvisioningStateType"/> values are not the same. </summary>
        public static bool operator !=(KubernetesConfigurationProvisioningStateType left, KubernetesConfigurationProvisioningStateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KubernetesConfigurationProvisioningStateType"/>. </summary>
        public static implicit operator KubernetesConfigurationProvisioningStateType(string value) => new KubernetesConfigurationProvisioningStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesConfigurationProvisioningStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesConfigurationProvisioningStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}