// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The message filter type. </summary>
    public readonly partial struct MessageFilterType : IEquatable<MessageFilterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageFilterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageFilterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string IncludeValue = "Include";
        private const string ExcludeValue = "Exclude";

        /// <summary> NotSpecified. </summary>
        public static MessageFilterType NotSpecified { get; } = new MessageFilterType(NotSpecifiedValue);
        /// <summary> Include. </summary>
        public static MessageFilterType Include { get; } = new MessageFilterType(IncludeValue);
        /// <summary> Exclude. </summary>
        public static MessageFilterType Exclude { get; } = new MessageFilterType(ExcludeValue);
        /// <summary> Determines if two <see cref="MessageFilterType"/> values are the same. </summary>
        public static bool operator ==(MessageFilterType left, MessageFilterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageFilterType"/> values are not the same. </summary>
        public static bool operator !=(MessageFilterType left, MessageFilterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageFilterType"/>. </summary>
        public static implicit operator MessageFilterType(string value) => new MessageFilterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageFilterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageFilterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}