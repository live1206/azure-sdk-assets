// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> backup protectionIntent type. </summary>
    internal readonly partial struct ProtectionIntentItemType : IEquatable<ProtectionIntentItemType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProtectionIntentItemType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProtectionIntentItemType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AzureResourceItemValue = "AzureResourceItem";
        private const string RecoveryServiceVaultItemValue = "RecoveryServiceVaultItem";
        private const string AzureWorkloadContainerAutoProtectionIntentValue = "AzureWorkloadContainerAutoProtectionIntent";
        private const string AzureWorkloadAutoProtectionIntentValue = "AzureWorkloadAutoProtectionIntent";
        private const string AzureWorkloadSqlAutoProtectionIntentValue = "AzureWorkloadSQLAutoProtectionIntent";

        /// <summary> Invalid. </summary>
        public static ProtectionIntentItemType Invalid { get; } = new ProtectionIntentItemType(InvalidValue);
        /// <summary> AzureResourceItem. </summary>
        public static ProtectionIntentItemType AzureResourceItem { get; } = new ProtectionIntentItemType(AzureResourceItemValue);
        /// <summary> RecoveryServiceVaultItem. </summary>
        public static ProtectionIntentItemType RecoveryServiceVaultItem { get; } = new ProtectionIntentItemType(RecoveryServiceVaultItemValue);
        /// <summary> AzureWorkloadContainerAutoProtectionIntent. </summary>
        public static ProtectionIntentItemType AzureWorkloadContainerAutoProtectionIntent { get; } = new ProtectionIntentItemType(AzureWorkloadContainerAutoProtectionIntentValue);
        /// <summary> AzureWorkloadAutoProtectionIntent. </summary>
        public static ProtectionIntentItemType AzureWorkloadAutoProtectionIntent { get; } = new ProtectionIntentItemType(AzureWorkloadAutoProtectionIntentValue);
        /// <summary> AzureWorkloadSQLAutoProtectionIntent. </summary>
        public static ProtectionIntentItemType AzureWorkloadSqlAutoProtectionIntent { get; } = new ProtectionIntentItemType(AzureWorkloadSqlAutoProtectionIntentValue);
        /// <summary> Determines if two <see cref="ProtectionIntentItemType"/> values are the same. </summary>
        public static bool operator ==(ProtectionIntentItemType left, ProtectionIntentItemType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProtectionIntentItemType"/> values are not the same. </summary>
        public static bool operator !=(ProtectionIntentItemType left, ProtectionIntentItemType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProtectionIntentItemType"/>. </summary>
        public static implicit operator ProtectionIntentItemType(string value) => new ProtectionIntentItemType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProtectionIntentItemType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProtectionIntentItemType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}