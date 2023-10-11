// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Migration secret parameters. </summary>
    public partial class PostgreSqlMigrationSecretParameters
    {
        /// <summary> Initializes a new instance of PostgreSqlMigrationSecretParameters. </summary>
        /// <param name="adminCredentials"> Admin credentials for source and target servers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="adminCredentials"/> is null. </exception>
        public PostgreSqlMigrationSecretParameters(PostgreSqlMigrationAdminCredentials adminCredentials)
        {
            Argument.AssertNotNull(adminCredentials, nameof(adminCredentials));

            AdminCredentials = adminCredentials;
        }

        /// <summary> Initializes a new instance of PostgreSqlMigrationSecretParameters. </summary>
        /// <param name="adminCredentials"> Admin credentials for source and target servers. </param>
        /// <param name="sourceServerUsername"> Gets or sets the username for the source server. This user need not be an admin. </param>
        /// <param name="targetServerUsername"> Gets or sets the username for the target server. This user need not be an admin. </param>
        internal PostgreSqlMigrationSecretParameters(PostgreSqlMigrationAdminCredentials adminCredentials, string sourceServerUsername, string targetServerUsername)
        {
            AdminCredentials = adminCredentials;
            SourceServerUsername = sourceServerUsername;
            TargetServerUsername = targetServerUsername;
        }

        /// <summary> Admin credentials for source and target servers. </summary>
        public PostgreSqlMigrationAdminCredentials AdminCredentials { get; set; }
        /// <summary> Gets or sets the username for the source server. This user need not be an admin. </summary>
        public string SourceServerUsername { get; set; }
        /// <summary> Gets or sets the username for the target server. This user need not be an admin. </summary>
        public string TargetServerUsername { get; set; }
    }
}