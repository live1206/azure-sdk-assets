// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the action to take when a managed rule set score threshold is met. </summary>
    public readonly partial struct ManagedRuleSetActionType : IEquatable<ManagedRuleSetActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSetActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedRuleSetActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BlockValue = "Block";
        private const string LogValue = "Log";
        private const string RedirectValue = "Redirect";

        /// <summary> Block. </summary>
        public static ManagedRuleSetActionType Block { get; } = new ManagedRuleSetActionType(BlockValue);
        /// <summary> Log. </summary>
        public static ManagedRuleSetActionType Log { get; } = new ManagedRuleSetActionType(LogValue);
        /// <summary> Redirect. </summary>
        public static ManagedRuleSetActionType Redirect { get; } = new ManagedRuleSetActionType(RedirectValue);
        /// <summary> Determines if two <see cref="ManagedRuleSetActionType"/> values are the same. </summary>
        public static bool operator ==(ManagedRuleSetActionType left, ManagedRuleSetActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedRuleSetActionType"/> values are not the same. </summary>
        public static bool operator !=(ManagedRuleSetActionType left, ManagedRuleSetActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedRuleSetActionType"/>. </summary>
        public static implicit operator ManagedRuleSetActionType(string value) => new ManagedRuleSetActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedRuleSetActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedRuleSetActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}