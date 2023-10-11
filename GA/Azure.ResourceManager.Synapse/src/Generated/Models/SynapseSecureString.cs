// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Azure Synapse secure string definition. The string value will be masked with asterisks '*' during Get or List API calls. </summary>
    public partial class SynapseSecureString : SynapseSecretBase
    {
        /// <summary> Initializes a new instance of SynapseSecureString. </summary>
        /// <param name="value"> Value of secure string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseSecureString(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
            SecretBaseType = "SecureString";
        }

        /// <summary> Initializes a new instance of SynapseSecureString. </summary>
        /// <param name="secretBaseType"> Type of the secret. </param>
        /// <param name="value"> Value of secure string. </param>
        internal SynapseSecureString(string secretBaseType, string value) : base(secretBaseType)
        {
            Value = value;
            SecretBaseType = secretBaseType ?? "SecureString";
        }

        /// <summary> Value of secure string. </summary>
        public string Value { get; set; }
    }
}