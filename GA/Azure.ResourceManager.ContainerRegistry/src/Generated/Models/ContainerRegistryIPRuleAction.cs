// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The action of IP ACL rule. </summary>
    public readonly partial struct ContainerRegistryIPRuleAction : IEquatable<ContainerRegistryIPRuleAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryIPRuleAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryIPRuleAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";

        /// <summary> Allow. </summary>
        public static ContainerRegistryIPRuleAction Allow { get; } = new ContainerRegistryIPRuleAction(AllowValue);
        /// <summary> Determines if two <see cref="ContainerRegistryIPRuleAction"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryIPRuleAction left, ContainerRegistryIPRuleAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryIPRuleAction"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryIPRuleAction left, ContainerRegistryIPRuleAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryIPRuleAction"/>. </summary>
        public static implicit operator ContainerRegistryIPRuleAction(string value) => new ContainerRegistryIPRuleAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryIPRuleAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryIPRuleAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
