// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Status of protectable item, i.e. InProgress,Succeeded,Failed. </summary>
    public readonly partial struct InquiryStatus : IEquatable<InquiryStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InquiryStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InquiryStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string SuccessValue = "Success";
        private const string FailedValue = "Failed";

        /// <summary> Invalid. </summary>
        public static InquiryStatus Invalid { get; } = new InquiryStatus(InvalidValue);
        /// <summary> Success. </summary>
        public static InquiryStatus Success { get; } = new InquiryStatus(SuccessValue);
        /// <summary> Failed. </summary>
        public static InquiryStatus Failed { get; } = new InquiryStatus(FailedValue);
        /// <summary> Determines if two <see cref="InquiryStatus"/> values are the same. </summary>
        public static bool operator ==(InquiryStatus left, InquiryStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InquiryStatus"/> values are not the same. </summary>
        public static bool operator !=(InquiryStatus left, InquiryStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InquiryStatus"/>. </summary>
        public static implicit operator InquiryStatus(string value) => new InquiryStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InquiryStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InquiryStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}