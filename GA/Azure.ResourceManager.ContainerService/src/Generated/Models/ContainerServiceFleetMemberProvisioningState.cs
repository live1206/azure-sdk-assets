// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The provisioning state of the last accepted operation. </summary>
    public readonly partial struct ContainerServiceFleetMemberProvisioningState : IEquatable<ContainerServiceFleetMemberProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleetMemberProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceFleetMemberProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string JoiningValue = "Joining";
        private const string LeavingValue = "Leaving";
        private const string UpdatingValue = "Updating";

        /// <summary> Succeeded. </summary>
        public static ContainerServiceFleetMemberProvisioningState Succeeded { get; } = new ContainerServiceFleetMemberProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ContainerServiceFleetMemberProvisioningState Failed { get; } = new ContainerServiceFleetMemberProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ContainerServiceFleetMemberProvisioningState Canceled { get; } = new ContainerServiceFleetMemberProvisioningState(CanceledValue);
        /// <summary> Joining. </summary>
        public static ContainerServiceFleetMemberProvisioningState Joining { get; } = new ContainerServiceFleetMemberProvisioningState(JoiningValue);
        /// <summary> Leaving. </summary>
        public static ContainerServiceFleetMemberProvisioningState Leaving { get; } = new ContainerServiceFleetMemberProvisioningState(LeavingValue);
        /// <summary> Updating. </summary>
        public static ContainerServiceFleetMemberProvisioningState Updating { get; } = new ContainerServiceFleetMemberProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="ContainerServiceFleetMemberProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceFleetMemberProvisioningState left, ContainerServiceFleetMemberProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceFleetMemberProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceFleetMemberProvisioningState left, ContainerServiceFleetMemberProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServiceFleetMemberProvisioningState"/>. </summary>
        public static implicit operator ContainerServiceFleetMemberProvisioningState(string value) => new ContainerServiceFleetMemberProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceFleetMemberProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceFleetMemberProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}