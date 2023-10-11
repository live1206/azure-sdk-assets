// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A list of server backups. </summary>
    internal partial class PostgreSqlFlexibleServerBackupListResult
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerBackupListResult. </summary>
        internal PostgreSqlFlexibleServerBackupListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFlexibleServerBackupData>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerBackupListResult. </summary>
        /// <param name="value"> The list of backups of a server. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        internal PostgreSqlFlexibleServerBackupListResult(IReadOnlyList<PostgreSqlFlexibleServerBackupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of backups of a server. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerBackupData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}