// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The provisioning state. </summary>
    public readonly partial struct AvsPrivateCloudProvisioningState : IEquatable<AvsPrivateCloudProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvsPrivateCloudProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";
        private const string PendingValue = "Pending";
        private const string BuildingValue = "Building";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static AvsPrivateCloudProvisioningState Succeeded { get; } = new AvsPrivateCloudProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AvsPrivateCloudProvisioningState Failed { get; } = new AvsPrivateCloudProvisioningState(FailedValue);
        /// <summary> Cancelled. </summary>
        public static AvsPrivateCloudProvisioningState Cancelled { get; } = new AvsPrivateCloudProvisioningState(CancelledValue);
        /// <summary> Pending. </summary>
        public static AvsPrivateCloudProvisioningState Pending { get; } = new AvsPrivateCloudProvisioningState(PendingValue);
        /// <summary> Building. </summary>
        public static AvsPrivateCloudProvisioningState Building { get; } = new AvsPrivateCloudProvisioningState(BuildingValue);
        /// <summary> Deleting. </summary>
        public static AvsPrivateCloudProvisioningState Deleting { get; } = new AvsPrivateCloudProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static AvsPrivateCloudProvisioningState Updating { get; } = new AvsPrivateCloudProvisioningState(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static AvsPrivateCloudProvisioningState Canceled { get; } = new AvsPrivateCloudProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="AvsPrivateCloudProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AvsPrivateCloudProvisioningState left, AvsPrivateCloudProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvsPrivateCloudProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AvsPrivateCloudProvisioningState left, AvsPrivateCloudProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvsPrivateCloudProvisioningState"/>. </summary>
        public static implicit operator AvsPrivateCloudProvisioningState(string value) => new AvsPrivateCloudProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvsPrivateCloudProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvsPrivateCloudProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
