// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Status of the individual operation. </summary>
    public readonly partial struct ReservationOperationStatus : IEquatable<ReservationOperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReservationOperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";
        private const string PendingValue = "Pending";

        /// <summary> Succeeded. </summary>
        public static ReservationOperationStatus Succeeded { get; } = new ReservationOperationStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static ReservationOperationStatus Failed { get; } = new ReservationOperationStatus(FailedValue);
        /// <summary> Cancelled. </summary>
        public static ReservationOperationStatus Cancelled { get; } = new ReservationOperationStatus(CancelledValue);
        /// <summary> Pending. </summary>
        public static ReservationOperationStatus Pending { get; } = new ReservationOperationStatus(PendingValue);
        /// <summary> Determines if two <see cref="ReservationOperationStatus"/> values are the same. </summary>
        public static bool operator ==(ReservationOperationStatus left, ReservationOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(ReservationOperationStatus left, ReservationOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationOperationStatus"/>. </summary>
        public static implicit operator ReservationOperationStatus(string value) => new ReservationOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}