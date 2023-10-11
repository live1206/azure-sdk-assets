// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Enum of the different backup types. </summary>
    public readonly partial struct BackupType : IEquatable<BackupType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DatabaseValue = "Database";
        private const string TransactionLogValue = "TransactionLog";
        private const string FileValue = "File";
        private const string DifferentialDatabaseValue = "DifferentialDatabase";
        private const string DifferentialFileValue = "DifferentialFile";
        private const string PartialValue = "Partial";
        private const string DifferentialPartialValue = "DifferentialPartial";

        /// <summary> Database. </summary>
        public static BackupType Database { get; } = new BackupType(DatabaseValue);
        /// <summary> TransactionLog. </summary>
        public static BackupType TransactionLog { get; } = new BackupType(TransactionLogValue);
        /// <summary> File. </summary>
        public static BackupType File { get; } = new BackupType(FileValue);
        /// <summary> DifferentialDatabase. </summary>
        public static BackupType DifferentialDatabase { get; } = new BackupType(DifferentialDatabaseValue);
        /// <summary> DifferentialFile. </summary>
        public static BackupType DifferentialFile { get; } = new BackupType(DifferentialFileValue);
        /// <summary> Partial. </summary>
        public static BackupType Partial { get; } = new BackupType(PartialValue);
        /// <summary> DifferentialPartial. </summary>
        public static BackupType DifferentialPartial { get; } = new BackupType(DifferentialPartialValue);
        /// <summary> Determines if two <see cref="BackupType"/> values are the same. </summary>
        public static bool operator ==(BackupType left, BackupType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupType"/> values are not the same. </summary>
        public static bool operator !=(BackupType left, BackupType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupType"/>. </summary>
        public static implicit operator BackupType(string value) => new BackupType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}