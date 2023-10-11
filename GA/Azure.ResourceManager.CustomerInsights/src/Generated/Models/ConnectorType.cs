// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Type of connector. </summary>
    public readonly partial struct ConnectorType : IEquatable<ConnectorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string CRMValue = "CRM";
        private const string AzureBlobValue = "AzureBlob";
        private const string SalesforceValue = "Salesforce";
        private const string ExchangeOnlineValue = "ExchangeOnline";
        private const string OutboundValue = "Outbound";

        /// <summary> None. </summary>
        public static ConnectorType None { get; } = new ConnectorType(NoneValue);
        /// <summary> CRM. </summary>
        public static ConnectorType CRM { get; } = new ConnectorType(CRMValue);
        /// <summary> AzureBlob. </summary>
        public static ConnectorType AzureBlob { get; } = new ConnectorType(AzureBlobValue);
        /// <summary> Salesforce. </summary>
        public static ConnectorType Salesforce { get; } = new ConnectorType(SalesforceValue);
        /// <summary> ExchangeOnline. </summary>
        public static ConnectorType ExchangeOnline { get; } = new ConnectorType(ExchangeOnlineValue);
        /// <summary> Outbound. </summary>
        public static ConnectorType Outbound { get; } = new ConnectorType(OutboundValue);
        /// <summary> Determines if two <see cref="ConnectorType"/> values are the same. </summary>
        public static bool operator ==(ConnectorType left, ConnectorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectorType"/> values are not the same. </summary>
        public static bool operator !=(ConnectorType left, ConnectorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectorType"/>. </summary>
        public static implicit operator ConnectorType(string value) => new ConnectorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}