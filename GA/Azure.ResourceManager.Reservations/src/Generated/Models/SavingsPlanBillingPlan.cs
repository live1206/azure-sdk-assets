// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </summary>
    public readonly partial struct SavingsPlanBillingPlan : IEquatable<SavingsPlanBillingPlan>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SavingsPlanBillingPlan"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SavingsPlanBillingPlan(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string P1MValue = "P1M";

        /// <summary> P1M. </summary>
        public static SavingsPlanBillingPlan P1M { get; } = new SavingsPlanBillingPlan(P1MValue);
        /// <summary> Determines if two <see cref="SavingsPlanBillingPlan"/> values are the same. </summary>
        public static bool operator ==(SavingsPlanBillingPlan left, SavingsPlanBillingPlan right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SavingsPlanBillingPlan"/> values are not the same. </summary>
        public static bool operator !=(SavingsPlanBillingPlan left, SavingsPlanBillingPlan right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SavingsPlanBillingPlan"/>. </summary>
        public static implicit operator SavingsPlanBillingPlan(string value) => new SavingsPlanBillingPlan(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SavingsPlanBillingPlan other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SavingsPlanBillingPlan other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}