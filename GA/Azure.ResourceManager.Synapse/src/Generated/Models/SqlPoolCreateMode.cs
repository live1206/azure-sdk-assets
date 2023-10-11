// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary>
    /// Specifies the mode of sql pool creation.
    ///
    /// Default: regular sql pool creation.
    ///
    /// PointInTimeRestore: Creates a sql pool by restoring a point in time backup of an existing sql pool. sourceDatabaseId must be specified as the resource ID of the existing sql pool, and restorePointInTime must be specified.
    ///
    /// Recovery: Creates a sql pool by a geo-replicated backup. sourceDatabaseId  must be specified as the recoverableDatabaseId to restore.
    ///
    /// Restore: Creates a sql pool by restoring a backup of a deleted sql  pool. SourceDatabaseId should be the sql pool's original resource ID. SourceDatabaseId and sourceDatabaseDeletionDate must be specified.
    /// </summary>
    public readonly partial struct SqlPoolCreateMode : IEquatable<SqlPoolCreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlPoolCreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlPoolCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string PointInTimeRestoreValue = "PointInTimeRestore";
        private const string RecoveryValue = "Recovery";
        private const string RestoreValue = "Restore";

        /// <summary> Default. </summary>
        public static SqlPoolCreateMode Default { get; } = new SqlPoolCreateMode(DefaultValue);
        /// <summary> PointInTimeRestore. </summary>
        public static SqlPoolCreateMode PointInTimeRestore { get; } = new SqlPoolCreateMode(PointInTimeRestoreValue);
        /// <summary> Recovery. </summary>
        public static SqlPoolCreateMode Recovery { get; } = new SqlPoolCreateMode(RecoveryValue);
        /// <summary> Restore. </summary>
        public static SqlPoolCreateMode Restore { get; } = new SqlPoolCreateMode(RestoreValue);
        /// <summary> Determines if two <see cref="SqlPoolCreateMode"/> values are the same. </summary>
        public static bool operator ==(SqlPoolCreateMode left, SqlPoolCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlPoolCreateMode"/> values are not the same. </summary>
        public static bool operator !=(SqlPoolCreateMode left, SqlPoolCreateMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlPoolCreateMode"/>. </summary>
        public static implicit operator SqlPoolCreateMode(string value) => new SqlPoolCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlPoolCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlPoolCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}