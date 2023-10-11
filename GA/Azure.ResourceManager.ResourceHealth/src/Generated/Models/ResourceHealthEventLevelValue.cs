// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Level of event. </summary>
    public readonly partial struct ResourceHealthEventLevelValue : IEquatable<ResourceHealthEventLevelValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventLevelValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceHealthEventLevelValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CriticalValue = "Critical";
        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";
        private const string InformationalValue = "Informational";

        /// <summary> Critical. </summary>
        public static ResourceHealthEventLevelValue Critical { get; } = new ResourceHealthEventLevelValue(CriticalValue);
        /// <summary> Error. </summary>
        public static ResourceHealthEventLevelValue Error { get; } = new ResourceHealthEventLevelValue(ErrorValue);
        /// <summary> Warning. </summary>
        public static ResourceHealthEventLevelValue Warning { get; } = new ResourceHealthEventLevelValue(WarningValue);
        /// <summary> Informational. </summary>
        public static ResourceHealthEventLevelValue Informational { get; } = new ResourceHealthEventLevelValue(InformationalValue);
        /// <summary> Determines if two <see cref="ResourceHealthEventLevelValue"/> values are the same. </summary>
        public static bool operator ==(ResourceHealthEventLevelValue left, ResourceHealthEventLevelValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceHealthEventLevelValue"/> values are not the same. </summary>
        public static bool operator !=(ResourceHealthEventLevelValue left, ResourceHealthEventLevelValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceHealthEventLevelValue"/>. </summary>
        public static implicit operator ResourceHealthEventLevelValue(string value) => new ResourceHealthEventLevelValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceHealthEventLevelValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceHealthEventLevelValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}