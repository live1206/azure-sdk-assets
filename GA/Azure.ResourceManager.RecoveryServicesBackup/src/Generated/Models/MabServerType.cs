// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Server type of MAB container. </summary>
    public readonly partial struct MabServerType : IEquatable<MabServerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MabServerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MabServerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string UnknownValue = "Unknown";
        private const string IaasVmContainerValue = "IaasVMContainer";
        private const string IaasVmServiceContainerValue = "IaasVMServiceContainer";
        private const string DpmContainerValue = "DPMContainer";
        private const string AzureBackupServerContainerValue = "AzureBackupServerContainer";
        private const string MabContainerValue = "MABContainer";
        private const string ClusterValue = "Cluster";
        private const string AzureSqlContainerValue = "AzureSqlContainer";
        private const string WindowsValue = "Windows";
        private const string VCenterValue = "VCenter";
        private const string VmAppContainerValue = "VMAppContainer";
        private const string SqlAvailabilityGroupWorkLoadContainerValue = "SQLAGWorkLoadContainer";
        private const string StorageContainerValue = "StorageContainer";
        private const string GenericContainerValue = "GenericContainer";

        /// <summary> Invalid. </summary>
        public static MabServerType Invalid { get; } = new MabServerType(InvalidValue);
        /// <summary> Unknown. </summary>
        public static MabServerType Unknown { get; } = new MabServerType(UnknownValue);
        /// <summary> IaasVMContainer. </summary>
        public static MabServerType IaasVmContainer { get; } = new MabServerType(IaasVmContainerValue);
        /// <summary> IaasVMServiceContainer. </summary>
        public static MabServerType IaasVmServiceContainer { get; } = new MabServerType(IaasVmServiceContainerValue);
        /// <summary> DPMContainer. </summary>
        public static MabServerType DpmContainer { get; } = new MabServerType(DpmContainerValue);
        /// <summary> AzureBackupServerContainer. </summary>
        public static MabServerType AzureBackupServerContainer { get; } = new MabServerType(AzureBackupServerContainerValue);
        /// <summary> MABContainer. </summary>
        public static MabServerType MabContainer { get; } = new MabServerType(MabContainerValue);
        /// <summary> Cluster. </summary>
        public static MabServerType Cluster { get; } = new MabServerType(ClusterValue);
        /// <summary> AzureSqlContainer. </summary>
        public static MabServerType AzureSqlContainer { get; } = new MabServerType(AzureSqlContainerValue);
        /// <summary> Windows. </summary>
        public static MabServerType Windows { get; } = new MabServerType(WindowsValue);
        /// <summary> VCenter. </summary>
        public static MabServerType VCenter { get; } = new MabServerType(VCenterValue);
        /// <summary> VMAppContainer. </summary>
        public static MabServerType VmAppContainer { get; } = new MabServerType(VmAppContainerValue);
        /// <summary> SQLAGWorkLoadContainer. </summary>
        public static MabServerType SqlAvailabilityGroupWorkLoadContainer { get; } = new MabServerType(SqlAvailabilityGroupWorkLoadContainerValue);
        /// <summary> StorageContainer. </summary>
        public static MabServerType StorageContainer { get; } = new MabServerType(StorageContainerValue);
        /// <summary> GenericContainer. </summary>
        public static MabServerType GenericContainer { get; } = new MabServerType(GenericContainerValue);
        /// <summary> Determines if two <see cref="MabServerType"/> values are the same. </summary>
        public static bool operator ==(MabServerType left, MabServerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MabServerType"/> values are not the same. </summary>
        public static bool operator !=(MabServerType left, MabServerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MabServerType"/>. </summary>
        public static implicit operator MabServerType(string value) => new MabServerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MabServerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MabServerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}