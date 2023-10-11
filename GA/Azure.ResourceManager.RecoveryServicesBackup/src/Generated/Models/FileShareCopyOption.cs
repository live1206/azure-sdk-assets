// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Options to resolve copy conflicts. </summary>
    public readonly partial struct FileShareCopyOption : IEquatable<FileShareCopyOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileShareCopyOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileShareCopyOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string CreateCopyValue = "CreateCopy";
        private const string SkipValue = "Skip";
        private const string OverwriteValue = "Overwrite";
        private const string FailOnConflictValue = "FailOnConflict";

        /// <summary> Invalid. </summary>
        public static FileShareCopyOption Invalid { get; } = new FileShareCopyOption(InvalidValue);
        /// <summary> CreateCopy. </summary>
        public static FileShareCopyOption CreateCopy { get; } = new FileShareCopyOption(CreateCopyValue);
        /// <summary> Skip. </summary>
        public static FileShareCopyOption Skip { get; } = new FileShareCopyOption(SkipValue);
        /// <summary> Overwrite. </summary>
        public static FileShareCopyOption Overwrite { get; } = new FileShareCopyOption(OverwriteValue);
        /// <summary> FailOnConflict. </summary>
        public static FileShareCopyOption FailOnConflict { get; } = new FileShareCopyOption(FailOnConflictValue);
        /// <summary> Determines if two <see cref="FileShareCopyOption"/> values are the same. </summary>
        public static bool operator ==(FileShareCopyOption left, FileShareCopyOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileShareCopyOption"/> values are not the same. </summary>
        public static bool operator !=(FileShareCopyOption left, FileShareCopyOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileShareCopyOption"/>. </summary>
        public static implicit operator FileShareCopyOption(string value) => new FileShareCopyOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileShareCopyOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileShareCopyOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}