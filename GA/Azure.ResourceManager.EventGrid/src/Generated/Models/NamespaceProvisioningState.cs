// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the namespace resource. </summary>
    public readonly partial struct NamespaceProvisioningState : IEquatable<NamespaceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NamespaceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NamespaceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string DeletedValue = "Deleted";
        private const string DeleteFailedValue = "DeleteFailed";
        private const string CreateFailedValue = "CreateFailed";
        private const string UpdatedFailedValue = "UpdatedFailed";

        /// <summary> Creating. </summary>
        public static NamespaceProvisioningState Creating { get; } = new NamespaceProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static NamespaceProvisioningState Updating { get; } = new NamespaceProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static NamespaceProvisioningState Deleting { get; } = new NamespaceProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static NamespaceProvisioningState Succeeded { get; } = new NamespaceProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static NamespaceProvisioningState Canceled { get; } = new NamespaceProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static NamespaceProvisioningState Failed { get; } = new NamespaceProvisioningState(FailedValue);
        /// <summary> Deleted. </summary>
        public static NamespaceProvisioningState Deleted { get; } = new NamespaceProvisioningState(DeletedValue);
        /// <summary> DeleteFailed. </summary>
        public static NamespaceProvisioningState DeleteFailed { get; } = new NamespaceProvisioningState(DeleteFailedValue);
        /// <summary> CreateFailed. </summary>
        public static NamespaceProvisioningState CreateFailed { get; } = new NamespaceProvisioningState(CreateFailedValue);
        /// <summary> UpdatedFailed. </summary>
        public static NamespaceProvisioningState UpdatedFailed { get; } = new NamespaceProvisioningState(UpdatedFailedValue);
        /// <summary> Determines if two <see cref="NamespaceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(NamespaceProvisioningState left, NamespaceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NamespaceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(NamespaceProvisioningState left, NamespaceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NamespaceProvisioningState"/>. </summary>
        public static implicit operator NamespaceProvisioningState(string value) => new NamespaceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NamespaceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NamespaceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
