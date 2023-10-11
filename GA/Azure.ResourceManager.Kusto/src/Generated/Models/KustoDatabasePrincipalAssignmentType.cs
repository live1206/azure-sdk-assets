// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The type of resource, Microsoft.Kusto/clusters/databases/principalAssignments. </summary>
    public readonly partial struct KustoDatabasePrincipalAssignmentType : IEquatable<KustoDatabasePrincipalAssignmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoDatabasePrincipalAssignmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoDatabasePrincipalAssignmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftKustoClustersDatabasesPrincipalAssignmentsValue = "Microsoft.Kusto/clusters/databases/principalAssignments";

        /// <summary> Microsoft.Kusto/clusters/databases/principalAssignments. </summary>
        public static KustoDatabasePrincipalAssignmentType MicrosoftKustoClustersDatabasesPrincipalAssignments { get; } = new KustoDatabasePrincipalAssignmentType(MicrosoftKustoClustersDatabasesPrincipalAssignmentsValue);
        /// <summary> Determines if two <see cref="KustoDatabasePrincipalAssignmentType"/> values are the same. </summary>
        public static bool operator ==(KustoDatabasePrincipalAssignmentType left, KustoDatabasePrincipalAssignmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoDatabasePrincipalAssignmentType"/> values are not the same. </summary>
        public static bool operator !=(KustoDatabasePrincipalAssignmentType left, KustoDatabasePrincipalAssignmentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoDatabasePrincipalAssignmentType"/>. </summary>
        public static implicit operator KustoDatabasePrincipalAssignmentType(string value) => new KustoDatabasePrincipalAssignmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoDatabasePrincipalAssignmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoDatabasePrincipalAssignmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}