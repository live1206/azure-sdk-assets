// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again. </summary>
    public readonly partial struct BackupValidationType : IEquatable<BackupValidationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupValidationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupValidationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ShallowValidationValue = "ShallowValidation";
        private const string DeepValidationValue = "DeepValidation";

        /// <summary> ShallowValidation. </summary>
        public static BackupValidationType ShallowValidation { get; } = new BackupValidationType(ShallowValidationValue);
        /// <summary> DeepValidation. </summary>
        public static BackupValidationType DeepValidation { get; } = new BackupValidationType(DeepValidationValue);
        /// <summary> Determines if two <see cref="BackupValidationType"/> values are the same. </summary>
        public static bool operator ==(BackupValidationType left, BackupValidationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupValidationType"/> values are not the same. </summary>
        public static bool operator !=(BackupValidationType left, BackupValidationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupValidationType"/>. </summary>
        public static implicit operator BackupValidationType(string value) => new BackupValidationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupValidationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupValidationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
