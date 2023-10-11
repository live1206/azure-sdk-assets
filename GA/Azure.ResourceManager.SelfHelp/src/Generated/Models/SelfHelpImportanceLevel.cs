// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Importance level of the insight. </summary>
    public readonly partial struct SelfHelpImportanceLevel : IEquatable<SelfHelpImportanceLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SelfHelpImportanceLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SelfHelpImportanceLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CriticalValue = "Critical";
        private const string WarningValue = "Warning";
        private const string InformationValue = "Information";

        /// <summary> A critical insight has been found after running the diagnostic. </summary>
        public static SelfHelpImportanceLevel Critical { get; } = new SelfHelpImportanceLevel(CriticalValue);
        /// <summary> A warning insight has been found after running the diagnostic. </summary>
        public static SelfHelpImportanceLevel Warning { get; } = new SelfHelpImportanceLevel(WarningValue);
        /// <summary> An information insight has been found after running the diagnostic. </summary>
        public static SelfHelpImportanceLevel Information { get; } = new SelfHelpImportanceLevel(InformationValue);
        /// <summary> Determines if two <see cref="SelfHelpImportanceLevel"/> values are the same. </summary>
        public static bool operator ==(SelfHelpImportanceLevel left, SelfHelpImportanceLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SelfHelpImportanceLevel"/> values are not the same. </summary>
        public static bool operator !=(SelfHelpImportanceLevel left, SelfHelpImportanceLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SelfHelpImportanceLevel"/>. </summary>
        public static implicit operator SelfHelpImportanceLevel(string value) => new SelfHelpImportanceLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SelfHelpImportanceLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SelfHelpImportanceLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}