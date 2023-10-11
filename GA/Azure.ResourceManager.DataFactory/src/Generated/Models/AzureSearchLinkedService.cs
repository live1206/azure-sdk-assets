// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Windows Azure Search Service. </summary>
    public partial class AzureSearchLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AzureSearchLinkedService. </summary>
        /// <param name="uri"> URL for Azure Search service. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public AzureSearchLinkedService(DataFactoryElement<string> uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            LinkedServiceType = "AzureSearch";
        }

        /// <summary> Initializes a new instance of AzureSearchLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="uri"> URL for Azure Search service. Type: string (or Expression with resultType string). </param>
        /// <param name="key"> Admin Key for Azure Search service. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal AzureSearchLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> uri, DataFactorySecretBaseDefinition key, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Uri = uri;
            Key = key;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "AzureSearch";
        }

        /// <summary> URL for Azure Search service. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> Admin Key for Azure Search service. </summary>
        public DataFactorySecretBaseDefinition Key { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}