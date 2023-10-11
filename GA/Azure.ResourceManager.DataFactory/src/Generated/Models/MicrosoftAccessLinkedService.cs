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
    /// <summary> Microsoft Access linked service. </summary>
    public partial class MicrosoftAccessLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of MicrosoftAccessLinkedService. </summary>
        /// <param name="connectionString"> The non-access credential portion of the connection string as well as an optional encrypted credential. Type: string, or SecureString, or AzureKeyVaultSecretReference, or Expression with resultType string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public MicrosoftAccessLinkedService(DataFactoryElement<string> connectionString)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));

            ConnectionString = connectionString;
            LinkedServiceType = "MicrosoftAccess";
        }

        /// <summary> Initializes a new instance of MicrosoftAccessLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The non-access credential portion of the connection string as well as an optional encrypted credential. Type: string, or SecureString, or AzureKeyVaultSecretReference, or Expression with resultType string. </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the Microsoft Access as ODBC data store. Possible values are: Anonymous and Basic. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The access credential portion of the connection string specified in driver-specific property-value format. </param>
        /// <param name="userName"> User name for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for Basic authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal MicrosoftAccessLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryElement<string> authenticationType, DataFactorySecretBaseDefinition credential, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            AuthenticationType = authenticationType;
            Credential = credential;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "MicrosoftAccess";
        }

        /// <summary> The non-access credential portion of the connection string as well as an optional encrypted credential. Type: string, or SecureString, or AzureKeyVaultSecretReference, or Expression with resultType string. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> Type of authentication used to connect to the Microsoft Access as ODBC data store. Possible values are: Anonymous and Basic. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AuthenticationType { get; set; }
        /// <summary> The access credential portion of the connection string specified in driver-specific property-value format. </summary>
        public DataFactorySecretBaseDefinition Credential { get; set; }
        /// <summary> User name for Basic authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password for Basic authentication. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}