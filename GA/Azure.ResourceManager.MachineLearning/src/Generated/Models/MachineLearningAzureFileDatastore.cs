// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure File datastore configuration. </summary>
    public partial class MachineLearningAzureFileDatastore : MachineLearningDatastoreProperties
    {
        /// <summary> Initializes a new instance of MachineLearningAzureFileDatastore. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="accountName"> [Required] Storage account name. </param>
        /// <param name="fileShareName"> [Required] The name of the Azure file share that the datastore points to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/>, <paramref name="accountName"/> or <paramref name="fileShareName"/> is null. </exception>
        public MachineLearningAzureFileDatastore(MachineLearningDatastoreCredentials credentials, string accountName, string fileShareName) : base(credentials)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(fileShareName, nameof(fileShareName));

            AccountName = accountName;
            FileShareName = fileShareName;
            DatastoreType = DatastoreType.AzureFile;
        }

        /// <summary> Initializes a new instance of MachineLearningAzureFileDatastore. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="accountName"> [Required] Storage account name. </param>
        /// <param name="endpoint"> Azure cloud endpoint for the storage account. </param>
        /// <param name="fileShareName"> [Required] The name of the Azure file share that the datastore points to. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer's storage. </param>
        internal MachineLearningAzureFileDatastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, MachineLearningDatastoreCredentials credentials, DatastoreType datastoreType, bool? isDefault, string accountName, string endpoint, string fileShareName, string protocol, MachineLearningServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity) : base(description, properties, tags, credentials, datastoreType, isDefault)
        {
            AccountName = accountName;
            Endpoint = endpoint;
            FileShareName = fileShareName;
            Protocol = protocol;
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            DatastoreType = datastoreType;
        }

        /// <summary> [Required] Storage account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Azure cloud endpoint for the storage account. </summary>
        public string Endpoint { get; set; }
        /// <summary> [Required] The name of the Azure file share that the datastore points to. </summary>
        public string FileShareName { get; set; }
        /// <summary> Protocol used to communicate with the storage account. </summary>
        public string Protocol { get; set; }
        /// <summary> Indicates which identity to use to authenticate service data access to customer's storage. </summary>
        public MachineLearningServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
    }
}
