// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> An enumeration of SQL Server Database states. </summary>
    public readonly partial struct DatabaseState : IEquatable<DatabaseState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnlineValue = "Online";
        private const string RestoringValue = "Restoring";
        private const string RecoveringValue = "Recovering";
        private const string RecoveryPendingValue = "RecoveryPending";
        private const string SuspectValue = "Suspect";
        private const string EmergencyValue = "Emergency";
        private const string OfflineValue = "Offline";
        private const string CopyingValue = "Copying";
        private const string OfflineSecondaryValue = "OfflineSecondary";

        /// <summary> Online. </summary>
        public static DatabaseState Online { get; } = new DatabaseState(OnlineValue);
        /// <summary> Restoring. </summary>
        public static DatabaseState Restoring { get; } = new DatabaseState(RestoringValue);
        /// <summary> Recovering. </summary>
        public static DatabaseState Recovering { get; } = new DatabaseState(RecoveringValue);
        /// <summary> RecoveryPending. </summary>
        public static DatabaseState RecoveryPending { get; } = new DatabaseState(RecoveryPendingValue);
        /// <summary> Suspect. </summary>
        public static DatabaseState Suspect { get; } = new DatabaseState(SuspectValue);
        /// <summary> Emergency. </summary>
        public static DatabaseState Emergency { get; } = new DatabaseState(EmergencyValue);
        /// <summary> Offline. </summary>
        public static DatabaseState Offline { get; } = new DatabaseState(OfflineValue);
        /// <summary> Copying. </summary>
        public static DatabaseState Copying { get; } = new DatabaseState(CopyingValue);
        /// <summary> OfflineSecondary. </summary>
        public static DatabaseState OfflineSecondary { get; } = new DatabaseState(OfflineSecondaryValue);
        /// <summary> Determines if two <see cref="DatabaseState"/> values are the same. </summary>
        public static bool operator ==(DatabaseState left, DatabaseState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseState"/> values are not the same. </summary>
        public static bool operator !=(DatabaseState left, DatabaseState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatabaseState"/>. </summary>
        public static implicit operator DatabaseState(string value) => new DatabaseState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}