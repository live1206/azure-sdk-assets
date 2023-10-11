// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Hive Catalog Option for Flink cluster. </summary>
    public partial class FlinkHiveCatalogOption
    {
        /// <summary> Initializes a new instance of FlinkHiveCatalogOption. </summary>
        /// <param name="metastoreDBConnectionPasswordSecret"> Secret reference name from secretsProfile.secrets containing password for database connection. </param>
        /// <param name="metastoreDBConnectionUriString"> Connection string for hive metastore database. </param>
        /// <param name="metastoreDBConnectionUserName"> User name for database connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metastoreDBConnectionPasswordSecret"/>, <paramref name="metastoreDBConnectionUriString"/> or <paramref name="metastoreDBConnectionUserName"/> is null. </exception>
        public FlinkHiveCatalogOption(string metastoreDBConnectionPasswordSecret, string metastoreDBConnectionUriString, string metastoreDBConnectionUserName)
        {
            Argument.AssertNotNull(metastoreDBConnectionPasswordSecret, nameof(metastoreDBConnectionPasswordSecret));
            Argument.AssertNotNull(metastoreDBConnectionUriString, nameof(metastoreDBConnectionUriString));
            Argument.AssertNotNull(metastoreDBConnectionUserName, nameof(metastoreDBConnectionUserName));

            MetastoreDBConnectionPasswordSecret = metastoreDBConnectionPasswordSecret;
            MetastoreDBConnectionUriString = metastoreDBConnectionUriString;
            MetastoreDBConnectionUserName = metastoreDBConnectionUserName;
        }

        /// <summary> Secret reference name from secretsProfile.secrets containing password for database connection. </summary>
        public string MetastoreDBConnectionPasswordSecret { get; set; }
        /// <summary> Connection string for hive metastore database. </summary>
        public string MetastoreDBConnectionUriString { get; set; }
        /// <summary> User name for database connection. </summary>
        public string MetastoreDBConnectionUserName { get; set; }
    }
}