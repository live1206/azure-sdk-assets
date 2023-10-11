// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> The EmergingIssueNameContent. </summary>
    public readonly partial struct EmergingIssueNameContent : IEquatable<EmergingIssueNameContent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EmergingIssueNameContent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EmergingIssueNameContent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static EmergingIssueNameContent Default { get; } = new EmergingIssueNameContent(DefaultValue);
        /// <summary> Determines if two <see cref="EmergingIssueNameContent"/> values are the same. </summary>
        public static bool operator ==(EmergingIssueNameContent left, EmergingIssueNameContent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EmergingIssueNameContent"/> values are not the same. </summary>
        public static bool operator !=(EmergingIssueNameContent left, EmergingIssueNameContent right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EmergingIssueNameContent"/>. </summary>
        public static implicit operator EmergingIssueNameContent(string value) => new EmergingIssueNameContent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EmergingIssueNameContent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EmergingIssueNameContent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
