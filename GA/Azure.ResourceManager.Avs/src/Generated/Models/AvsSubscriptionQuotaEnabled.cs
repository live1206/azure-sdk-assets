// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Host quota is active for current subscription. </summary>
    public readonly partial struct AvsSubscriptionQuotaEnabled : IEquatable<AvsSubscriptionQuotaEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvsSubscriptionQuotaEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvsSubscriptionQuotaEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static AvsSubscriptionQuotaEnabled Enabled { get; } = new AvsSubscriptionQuotaEnabled(EnabledValue);
        /// <summary> Disabled. </summary>
        public static AvsSubscriptionQuotaEnabled Disabled { get; } = new AvsSubscriptionQuotaEnabled(DisabledValue);
        /// <summary> Determines if two <see cref="AvsSubscriptionQuotaEnabled"/> values are the same. </summary>
        public static bool operator ==(AvsSubscriptionQuotaEnabled left, AvsSubscriptionQuotaEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvsSubscriptionQuotaEnabled"/> values are not the same. </summary>
        public static bool operator !=(AvsSubscriptionQuotaEnabled left, AvsSubscriptionQuotaEnabled right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvsSubscriptionQuotaEnabled"/>. </summary>
        public static implicit operator AvsSubscriptionQuotaEnabled(string value) => new AvsSubscriptionQuotaEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvsSubscriptionQuotaEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvsSubscriptionQuotaEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}