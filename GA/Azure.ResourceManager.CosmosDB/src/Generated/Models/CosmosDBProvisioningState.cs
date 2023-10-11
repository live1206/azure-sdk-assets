// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The provisioning state of the resource. </summary>
    public readonly partial struct CosmosDBProvisioningState : IEquatable<CosmosDBProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string InProgressValue = "InProgress";
        private const string UpdatingValue = "Updating";
        private const string DroppingValue = "Dropping";

        /// <summary> Succeeded. </summary>
        public static CosmosDBProvisioningState Succeeded { get; } = new CosmosDBProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static CosmosDBProvisioningState Failed { get; } = new CosmosDBProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static CosmosDBProvisioningState Canceled { get; } = new CosmosDBProvisioningState(CanceledValue);
        /// <summary> InProgress. </summary>
        public static CosmosDBProvisioningState InProgress { get; } = new CosmosDBProvisioningState(InProgressValue);
        /// <summary> Updating. </summary>
        public static CosmosDBProvisioningState Updating { get; } = new CosmosDBProvisioningState(UpdatingValue);
        /// <summary> Dropping. </summary>
        public static CosmosDBProvisioningState Dropping { get; } = new CosmosDBProvisioningState(DroppingValue);
        /// <summary> Determines if two <see cref="CosmosDBProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CosmosDBProvisioningState left, CosmosDBProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBProvisioningState left, CosmosDBProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBProvisioningState"/>. </summary>
        public static implicit operator CosmosDBProvisioningState(string value) => new CosmosDBProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}