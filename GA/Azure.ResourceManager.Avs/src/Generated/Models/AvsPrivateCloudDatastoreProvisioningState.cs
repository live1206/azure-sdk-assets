// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The state of the datastore provisioning. </summary>
    public readonly partial struct AvsPrivateCloudDatastoreProvisioningState : IEquatable<AvsPrivateCloudDatastoreProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudDatastoreProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvsPrivateCloudDatastoreProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";
        private const string PendingValue = "Pending";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Succeeded { get; } = new AvsPrivateCloudDatastoreProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Failed { get; } = new AvsPrivateCloudDatastoreProvisioningState(FailedValue);
        /// <summary> Cancelled. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Cancelled { get; } = new AvsPrivateCloudDatastoreProvisioningState(CancelledValue);
        /// <summary> Pending. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Pending { get; } = new AvsPrivateCloudDatastoreProvisioningState(PendingValue);
        /// <summary> Creating. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Creating { get; } = new AvsPrivateCloudDatastoreProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Updating { get; } = new AvsPrivateCloudDatastoreProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Deleting { get; } = new AvsPrivateCloudDatastoreProvisioningState(DeletingValue);
        /// <summary> Canceled. </summary>
        public static AvsPrivateCloudDatastoreProvisioningState Canceled { get; } = new AvsPrivateCloudDatastoreProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="AvsPrivateCloudDatastoreProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AvsPrivateCloudDatastoreProvisioningState left, AvsPrivateCloudDatastoreProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvsPrivateCloudDatastoreProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AvsPrivateCloudDatastoreProvisioningState left, AvsPrivateCloudDatastoreProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvsPrivateCloudDatastoreProvisioningState"/>. </summary>
        public static implicit operator AvsPrivateCloudDatastoreProvisioningState(string value) => new AvsPrivateCloudDatastoreProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvsPrivateCloudDatastoreProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvsPrivateCloudDatastoreProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}