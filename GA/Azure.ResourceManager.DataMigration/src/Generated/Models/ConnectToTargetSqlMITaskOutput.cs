// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that validates connection to Azure SQL Database Managed Instance. </summary>
    public partial class ConnectToTargetSqlMITaskOutput
    {
        /// <summary> Initializes a new instance of ConnectToTargetSqlMITaskOutput. </summary>
        internal ConnectToTargetSqlMITaskOutput()
        {
            Logins = new ChangeTrackingList<string>();
            AgentJobs = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of ConnectToTargetSqlMITaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="logins"> List of logins on the target server. </param>
        /// <param name="agentJobs"> List of agent jobs on the target server. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        internal ConnectToTargetSqlMITaskOutput(string id, string targetServerVersion, string targetServerBrandVersion, IReadOnlyList<string> logins, IReadOnlyList<string> agentJobs, IReadOnlyList<ReportableException> validationErrors)
        {
            Id = id;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            Logins = logins;
            AgentJobs = agentJobs;
            ValidationErrors = validationErrors;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> List of logins on the target server. </summary>
        public IReadOnlyList<string> Logins { get; }
        /// <summary> List of agent jobs on the target server. </summary>
        public IReadOnlyList<string> AgentJobs { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}