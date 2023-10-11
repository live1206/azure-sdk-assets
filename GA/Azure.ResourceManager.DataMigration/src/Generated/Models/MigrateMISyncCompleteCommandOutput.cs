// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for command that completes online migration for an Azure SQL Database Managed Instance. </summary>
    internal partial class MigrateMISyncCompleteCommandOutput
    {
        /// <summary> Initializes a new instance of MigrateMISyncCompleteCommandOutput. </summary>
        internal MigrateMISyncCompleteCommandOutput()
        {
            Errors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of MigrateMISyncCompleteCommandOutput. </summary>
        /// <param name="errors"> List of errors that happened during the command execution. </param>
        internal MigrateMISyncCompleteCommandOutput(IReadOnlyList<ReportableException> errors)
        {
            Errors = errors;
        }

        /// <summary> List of errors that happened during the command execution. </summary>
        public IReadOnlyList<ReportableException> Errors { get; }
    }
}