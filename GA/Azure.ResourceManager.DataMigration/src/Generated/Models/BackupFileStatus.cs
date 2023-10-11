// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> An enumeration of Status of the log backup file. </summary>
    public readonly partial struct BackupFileStatus : IEquatable<BackupFileStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupFileStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupFileStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArrivedValue = "Arrived";
        private const string QueuedValue = "Queued";
        private const string UploadingValue = "Uploading";
        private const string UploadedValue = "Uploaded";
        private const string RestoringValue = "Restoring";
        private const string RestoredValue = "Restored";
        private const string CancelledValue = "Cancelled";

        /// <summary> Arrived. </summary>
        public static BackupFileStatus Arrived { get; } = new BackupFileStatus(ArrivedValue);
        /// <summary> Queued. </summary>
        public static BackupFileStatus Queued { get; } = new BackupFileStatus(QueuedValue);
        /// <summary> Uploading. </summary>
        public static BackupFileStatus Uploading { get; } = new BackupFileStatus(UploadingValue);
        /// <summary> Uploaded. </summary>
        public static BackupFileStatus Uploaded { get; } = new BackupFileStatus(UploadedValue);
        /// <summary> Restoring. </summary>
        public static BackupFileStatus Restoring { get; } = new BackupFileStatus(RestoringValue);
        /// <summary> Restored. </summary>
        public static BackupFileStatus Restored { get; } = new BackupFileStatus(RestoredValue);
        /// <summary> Cancelled. </summary>
        public static BackupFileStatus Cancelled { get; } = new BackupFileStatus(CancelledValue);
        /// <summary> Determines if two <see cref="BackupFileStatus"/> values are the same. </summary>
        public static bool operator ==(BackupFileStatus left, BackupFileStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupFileStatus"/> values are not the same. </summary>
        public static bool operator !=(BackupFileStatus left, BackupFileStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupFileStatus"/>. </summary>
        public static implicit operator BackupFileStatus(string value) => new BackupFileStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupFileStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupFileStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}