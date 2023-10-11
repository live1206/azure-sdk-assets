// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Base definition for datastore contents configuration.
    /// Please note <see cref="MachineLearningDatastoreProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MachineLearningAzureBlobDatastore"/>, <see cref="MachineLearningAzureDataLakeGen1Datastore"/>, <see cref="MachineLearningAzureDataLakeGen2Datastore"/> and <see cref="MachineLearningAzureFileDatastore"/>.
    /// </summary>
    public partial class MachineLearningDatastoreProperties : MachineLearningResourceBase
    {
        /// <summary> Initializes a new instance of MachineLearningDatastoreProperties. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> is null. </exception>
        public MachineLearningDatastoreProperties(MachineLearningDatastoreCredentials credentials)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));

            Credentials = credentials;
        }

        /// <summary> Initializes a new instance of MachineLearningDatastoreProperties. </summary>
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
        internal MachineLearningDatastoreProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, MachineLearningDatastoreCredentials credentials, DatastoreType datastoreType, bool? isDefault) : base(description, properties, tags)
        {
            Credentials = credentials;
            DatastoreType = datastoreType;
            IsDefault = isDefault;
        }

        /// <summary>
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </summary>
        public MachineLearningDatastoreCredentials Credentials { get; set; }
        /// <summary> [Required] Storage type backing the datastore. </summary>
        internal DatastoreType DatastoreType { get; set; }
        /// <summary> Readonly property to indicate if datastore is the workspace default datastore. </summary>
        public bool? IsDefault { get; }
    }
}
