// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Gets or sets the type of the source data store. </summary>
    public readonly partial struct SourceDataStoreType : IEquatable<SourceDataStoreType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceDataStoreType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceDataStoreType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArchiveStoreValue = "ArchiveStore";
        private const string SnapshotStoreValue = "SnapshotStore";
        private const string OperationalStoreValue = "OperationalStore";
        private const string VaultStoreValue = "VaultStore";

        /// <summary> ArchiveStore. </summary>
        public static SourceDataStoreType ArchiveStore { get; } = new SourceDataStoreType(ArchiveStoreValue);
        /// <summary> SnapshotStore. </summary>
        public static SourceDataStoreType SnapshotStore { get; } = new SourceDataStoreType(SnapshotStoreValue);
        /// <summary> OperationalStore. </summary>
        public static SourceDataStoreType OperationalStore { get; } = new SourceDataStoreType(OperationalStoreValue);
        /// <summary> VaultStore. </summary>
        public static SourceDataStoreType VaultStore { get; } = new SourceDataStoreType(VaultStoreValue);
        /// <summary> Determines if two <see cref="SourceDataStoreType"/> values are the same. </summary>
        public static bool operator ==(SourceDataStoreType left, SourceDataStoreType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceDataStoreType"/> values are not the same. </summary>
        public static bool operator !=(SourceDataStoreType left, SourceDataStoreType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SourceDataStoreType"/>. </summary>
        public static implicit operator SourceDataStoreType(string value) => new SourceDataStoreType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceDataStoreType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceDataStoreType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}