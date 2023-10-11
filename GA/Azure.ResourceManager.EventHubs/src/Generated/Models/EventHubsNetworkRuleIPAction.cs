// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The IP Filter Action. </summary>
    public readonly partial struct EventHubsNetworkRuleIPAction : IEquatable<EventHubsNetworkRuleIPAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkRuleIPAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsNetworkRuleIPAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";

        /// <summary> Allow. </summary>
        public static EventHubsNetworkRuleIPAction Allow { get; } = new EventHubsNetworkRuleIPAction(AllowValue);
        /// <summary> Determines if two <see cref="EventHubsNetworkRuleIPAction"/> values are the same. </summary>
        public static bool operator ==(EventHubsNetworkRuleIPAction left, EventHubsNetworkRuleIPAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsNetworkRuleIPAction"/> values are not the same. </summary>
        public static bool operator !=(EventHubsNetworkRuleIPAction left, EventHubsNetworkRuleIPAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventHubsNetworkRuleIPAction"/>. </summary>
        public static implicit operator EventHubsNetworkRuleIPAction(string value) => new EventHubsNetworkRuleIPAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsNetworkRuleIPAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsNetworkRuleIPAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}