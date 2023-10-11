// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct BotServicePrivateEndpointConnectionProvisioningState : IEquatable<BotServicePrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BotServicePrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BotServicePrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static BotServicePrivateEndpointConnectionProvisioningState Succeeded { get; } = new BotServicePrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static BotServicePrivateEndpointConnectionProvisioningState Creating { get; } = new BotServicePrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static BotServicePrivateEndpointConnectionProvisioningState Deleting { get; } = new BotServicePrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static BotServicePrivateEndpointConnectionProvisioningState Failed { get; } = new BotServicePrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="BotServicePrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(BotServicePrivateEndpointConnectionProvisioningState left, BotServicePrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BotServicePrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(BotServicePrivateEndpointConnectionProvisioningState left, BotServicePrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BotServicePrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator BotServicePrivateEndpointConnectionProvisioningState(string value) => new BotServicePrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BotServicePrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BotServicePrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}