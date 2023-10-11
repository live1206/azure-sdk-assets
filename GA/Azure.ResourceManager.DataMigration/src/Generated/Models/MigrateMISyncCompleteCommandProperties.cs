// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the command that completes online migration for an Azure SQL Database Managed Instance. </summary>
    public partial class MigrateMISyncCompleteCommandProperties : CommandProperties
    {
        /// <summary> Initializes a new instance of MigrateMISyncCompleteCommandProperties. </summary>
        public MigrateMISyncCompleteCommandProperties()
        {
            CommandType = CommandType.MigrateSqlServerAzureDBSqlMIComplete;
        }

        /// <summary> Initializes a new instance of MigrateMISyncCompleteCommandProperties. </summary>
        /// <param name="commandType"> Command type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the command. This is ignored if submitted. </param>
        /// <param name="input"> Command input. </param>
        /// <param name="output"> Command output. This is ignored if submitted. </param>
        internal MigrateMISyncCompleteCommandProperties(CommandType commandType, IReadOnlyList<ODataError> errors, CommandState? state, MigrateMISyncCompleteCommandInput input, MigrateMISyncCompleteCommandOutput output) : base(commandType, errors, state)
        {
            Input = input;
            Output = output;
            CommandType = commandType;
        }

        /// <summary> Command input. </summary>
        internal MigrateMISyncCompleteCommandInput Input { get; set; }
        /// <summary> Name of managed instance database. </summary>
        public string InputSourceDatabaseName
        {
            get => Input is null ? default : Input.SourceDatabaseName;
            set => Input = new MigrateMISyncCompleteCommandInput(value);
        }

        /// <summary> Command output. This is ignored if submitted. </summary>
        internal MigrateMISyncCompleteCommandOutput Output { get; }
        /// <summary> List of errors that happened during the command execution. </summary>
        public IReadOnlyList<ReportableException> OutputErrors
        {
            get => Output?.Errors;
        }
    }
}