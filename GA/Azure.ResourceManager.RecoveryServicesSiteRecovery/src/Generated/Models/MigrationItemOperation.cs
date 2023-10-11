// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The MigrationItemOperation. </summary>
    public readonly partial struct MigrationItemOperation : IEquatable<MigrationItemOperation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MigrationItemOperation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MigrationItemOperation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisableMigrationValue = "DisableMigration";
        private const string TestMigrateValue = "TestMigrate";
        private const string TestMigrateCleanupValue = "TestMigrateCleanup";
        private const string MigrateValue = "Migrate";
        private const string StartResyncValue = "StartResync";
        private const string PauseReplicationValue = "PauseReplication";
        private const string ResumeReplicationValue = "ResumeReplication";

        /// <summary> DisableMigration. </summary>
        public static MigrationItemOperation DisableMigration { get; } = new MigrationItemOperation(DisableMigrationValue);
        /// <summary> TestMigrate. </summary>
        public static MigrationItemOperation TestMigrate { get; } = new MigrationItemOperation(TestMigrateValue);
        /// <summary> TestMigrateCleanup. </summary>
        public static MigrationItemOperation TestMigrateCleanup { get; } = new MigrationItemOperation(TestMigrateCleanupValue);
        /// <summary> Migrate. </summary>
        public static MigrationItemOperation Migrate { get; } = new MigrationItemOperation(MigrateValue);
        /// <summary> StartResync. </summary>
        public static MigrationItemOperation StartResync { get; } = new MigrationItemOperation(StartResyncValue);
        /// <summary> PauseReplication. </summary>
        public static MigrationItemOperation PauseReplication { get; } = new MigrationItemOperation(PauseReplicationValue);
        /// <summary> ResumeReplication. </summary>
        public static MigrationItemOperation ResumeReplication { get; } = new MigrationItemOperation(ResumeReplicationValue);
        /// <summary> Determines if two <see cref="MigrationItemOperation"/> values are the same. </summary>
        public static bool operator ==(MigrationItemOperation left, MigrationItemOperation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MigrationItemOperation"/> values are not the same. </summary>
        public static bool operator !=(MigrationItemOperation left, MigrationItemOperation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MigrationItemOperation"/>. </summary>
        public static implicit operator MigrationItemOperation(string value) => new MigrationItemOperation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MigrationItemOperation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MigrationItemOperation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}