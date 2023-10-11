// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The metastore specification for Spark cluster. </summary>
    public partial class SparkMetastoreSpec
    {
        /// <summary> Initializes a new instance of SparkMetastoreSpec. </summary>
        /// <param name="dbServerHost"> The database server host. </param>
        /// <param name="dbName"> The database name. </param>
        /// <param name="dbUserName"> The database user name. </param>
        /// <param name="dbPasswordSecretName"> The secret name which contains the database user password. </param>
        /// <param name="keyVaultId"> The key vault resource id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dbServerHost"/>, <paramref name="dbName"/>, <paramref name="dbUserName"/>, <paramref name="dbPasswordSecretName"/> or <paramref name="keyVaultId"/> is null. </exception>
        public SparkMetastoreSpec(string dbServerHost, string dbName, string dbUserName, string dbPasswordSecretName, string keyVaultId)
        {
            Argument.AssertNotNull(dbServerHost, nameof(dbServerHost));
            Argument.AssertNotNull(dbName, nameof(dbName));
            Argument.AssertNotNull(dbUserName, nameof(dbUserName));
            Argument.AssertNotNull(dbPasswordSecretName, nameof(dbPasswordSecretName));
            Argument.AssertNotNull(keyVaultId, nameof(keyVaultId));

            DBServerHost = dbServerHost;
            DBName = dbName;
            DBUserName = dbUserName;
            DBPasswordSecretName = dbPasswordSecretName;
            KeyVaultId = keyVaultId;
        }

        /// <summary> Initializes a new instance of SparkMetastoreSpec. </summary>
        /// <param name="dbServerHost"> The database server host. </param>
        /// <param name="dbName"> The database name. </param>
        /// <param name="dbUserName"> The database user name. </param>
        /// <param name="dbPasswordSecretName"> The secret name which contains the database user password. </param>
        /// <param name="keyVaultId"> The key vault resource id. </param>
        /// <param name="thriftUriString"> The thrift url. </param>
        internal SparkMetastoreSpec(string dbServerHost, string dbName, string dbUserName, string dbPasswordSecretName, string keyVaultId, string thriftUriString)
        {
            DBServerHost = dbServerHost;
            DBName = dbName;
            DBUserName = dbUserName;
            DBPasswordSecretName = dbPasswordSecretName;
            KeyVaultId = keyVaultId;
            ThriftUriString = thriftUriString;
        }

        /// <summary> The database server host. </summary>
        public string DBServerHost { get; set; }
        /// <summary> The database name. </summary>
        public string DBName { get; set; }
        /// <summary> The database user name. </summary>
        public string DBUserName { get; set; }
        /// <summary> The secret name which contains the database user password. </summary>
        public string DBPasswordSecretName { get; set; }
        /// <summary> The key vault resource id. </summary>
        public string KeyVaultId { get; set; }
        /// <summary> The thrift url. </summary>
        public string ThriftUriString { get; set; }
    }
}