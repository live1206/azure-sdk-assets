// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The kind of the service. </summary>
    public readonly partial struct FhirServiceKind : IEquatable<FhirServiceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FhirServiceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FhirServiceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FhirStu3Value = "fhir-Stu3";
        private const string FhirR4Value = "fhir-R4";

        /// <summary> fhir-Stu3. </summary>
        public static FhirServiceKind FhirStu3 { get; } = new FhirServiceKind(FhirStu3Value);
        /// <summary> fhir-R4. </summary>
        public static FhirServiceKind FhirR4 { get; } = new FhirServiceKind(FhirR4Value);
        /// <summary> Determines if two <see cref="FhirServiceKind"/> values are the same. </summary>
        public static bool operator ==(FhirServiceKind left, FhirServiceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FhirServiceKind"/> values are not the same. </summary>
        public static bool operator !=(FhirServiceKind left, FhirServiceKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FhirServiceKind"/>. </summary>
        public static implicit operator FhirServiceKind(string value) => new FhirServiceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FhirServiceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FhirServiceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}