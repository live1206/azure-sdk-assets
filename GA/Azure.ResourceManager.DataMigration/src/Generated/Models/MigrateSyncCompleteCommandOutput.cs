// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for command that completes sync migration for a database. </summary>
    public partial class MigrateSyncCompleteCommandOutput
    {
        /// <summary> Initializes a new instance of MigrateSyncCompleteCommandOutput. </summary>
        internal MigrateSyncCompleteCommandOutput()
        {
            Errors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of MigrateSyncCompleteCommandOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="errors"> List of errors that happened during the command execution. </param>
        internal MigrateSyncCompleteCommandOutput(string id, IReadOnlyList<ReportableException> errors)
        {
            Id = id;
            Errors = errors;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> List of errors that happened during the command execution. </summary>
        public IReadOnlyList<ReportableException> Errors { get; }
    }
}