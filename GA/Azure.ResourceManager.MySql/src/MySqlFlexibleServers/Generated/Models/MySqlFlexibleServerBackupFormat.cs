// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Backup Format for the current backup. (CollatedFormat is INTERNAL – DO NOT USE). </summary>
    public readonly partial struct MySqlFlexibleServerBackupFormat : IEquatable<MySqlFlexibleServerBackupFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerBackupFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerBackupFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string CollatedFormatValue = "CollatedFormat";

        /// <summary> None. </summary>
        public static MySqlFlexibleServerBackupFormat None { get; } = new MySqlFlexibleServerBackupFormat(NoneValue);
        /// <summary> CollatedFormat. </summary>
        public static MySqlFlexibleServerBackupFormat CollatedFormat { get; } = new MySqlFlexibleServerBackupFormat(CollatedFormatValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerBackupFormat"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerBackupFormat left, MySqlFlexibleServerBackupFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerBackupFormat"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerBackupFormat left, MySqlFlexibleServerBackupFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MySqlFlexibleServerBackupFormat"/>. </summary>
        public static implicit operator MySqlFlexibleServerBackupFormat(string value) => new MySqlFlexibleServerBackupFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerBackupFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerBackupFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}