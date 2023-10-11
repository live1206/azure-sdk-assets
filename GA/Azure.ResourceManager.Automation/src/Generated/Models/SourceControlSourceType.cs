// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The source type. Must be one of VsoGit, VsoTfvc, GitHub. </summary>
    public readonly partial struct SourceControlSourceType : IEquatable<SourceControlSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceControlSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceControlSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VsoGitValue = "VsoGit";
        private const string VsoTfvcValue = "VsoTfvc";
        private const string GitHubValue = "GitHub";

        /// <summary> VsoGit. </summary>
        public static SourceControlSourceType VsoGit { get; } = new SourceControlSourceType(VsoGitValue);
        /// <summary> VsoTfvc. </summary>
        public static SourceControlSourceType VsoTfvc { get; } = new SourceControlSourceType(VsoTfvcValue);
        /// <summary> GitHub. </summary>
        public static SourceControlSourceType GitHub { get; } = new SourceControlSourceType(GitHubValue);
        /// <summary> Determines if two <see cref="SourceControlSourceType"/> values are the same. </summary>
        public static bool operator ==(SourceControlSourceType left, SourceControlSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceControlSourceType"/> values are not the same. </summary>
        public static bool operator !=(SourceControlSourceType left, SourceControlSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SourceControlSourceType"/>. </summary>
        public static implicit operator SourceControlSourceType(string value) => new SourceControlSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceControlSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceControlSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}