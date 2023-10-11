// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> State of soft delete. </summary>
    public readonly partial struct BackupVaultSoftDeleteState : IEquatable<BackupVaultSoftDeleteState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupVaultSoftDeleteState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupVaultSoftDeleteState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OffValue = "Off";
        private const string OnValue = "On";
        private const string AlwaysOnValue = "AlwaysOn";

        /// <summary> Soft Delete is turned off for the BackupVault. </summary>
        public static BackupVaultSoftDeleteState Off { get; } = new BackupVaultSoftDeleteState(OffValue);
        /// <summary> Soft Delete is enabled for the BackupVault but can be turned off. </summary>
        public static BackupVaultSoftDeleteState On { get; } = new BackupVaultSoftDeleteState(OnValue);
        /// <summary> Soft Delete is permanently enabled for the BackupVault and the setting cannot be changed. </summary>
        public static BackupVaultSoftDeleteState AlwaysOn { get; } = new BackupVaultSoftDeleteState(AlwaysOnValue);
        /// <summary> Determines if two <see cref="BackupVaultSoftDeleteState"/> values are the same. </summary>
        public static bool operator ==(BackupVaultSoftDeleteState left, BackupVaultSoftDeleteState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupVaultSoftDeleteState"/> values are not the same. </summary>
        public static bool operator !=(BackupVaultSoftDeleteState left, BackupVaultSoftDeleteState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupVaultSoftDeleteState"/>. </summary>
        public static implicit operator BackupVaultSoftDeleteState(string value) => new BackupVaultSoftDeleteState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupVaultSoftDeleteState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupVaultSoftDeleteState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
