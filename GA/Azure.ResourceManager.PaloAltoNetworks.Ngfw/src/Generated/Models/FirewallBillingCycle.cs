// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Billing cycle. </summary>
    public readonly partial struct FirewallBillingCycle : IEquatable<FirewallBillingCycle>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FirewallBillingCycle"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallBillingCycle(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WeeklyValue = "WEEKLY";
        private const string MonthlyValue = "MONTHLY";

        /// <summary> WEEKLY. </summary>
        public static FirewallBillingCycle Weekly { get; } = new FirewallBillingCycle(WeeklyValue);
        /// <summary> MONTHLY. </summary>
        public static FirewallBillingCycle Monthly { get; } = new FirewallBillingCycle(MonthlyValue);
        /// <summary> Determines if two <see cref="FirewallBillingCycle"/> values are the same. </summary>
        public static bool operator ==(FirewallBillingCycle left, FirewallBillingCycle right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallBillingCycle"/> values are not the same. </summary>
        public static bool operator !=(FirewallBillingCycle left, FirewallBillingCycle right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallBillingCycle"/>. </summary>
        public static implicit operator FirewallBillingCycle(string value) => new FirewallBillingCycle(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallBillingCycle other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallBillingCycle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}