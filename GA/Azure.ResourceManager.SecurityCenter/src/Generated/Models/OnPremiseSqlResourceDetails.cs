// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Details of the On Premise Sql resource that was assessed. </summary>
    public partial class OnPremiseSqlResourceDetails : OnPremiseResourceDetails
    {
        /// <summary> Initializes a new instance of OnPremiseSqlResourceDetails. </summary>
        /// <param name="workspaceId"> Azure resource Id of the workspace the machine is attached to. </param>
        /// <param name="vmUuid"> The unique Id of the machine. </param>
        /// <param name="sourceComputerId"> The oms agent Id installed on the machine. </param>
        /// <param name="machineName"> The name of the machine. </param>
        /// <param name="serverName"> The Sql server name installed on the machine. </param>
        /// <param name="databaseName"> The Sql database name installed on the machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/>, <paramref name="sourceComputerId"/>, <paramref name="machineName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is null. </exception>
        public OnPremiseSqlResourceDetails(ResourceIdentifier workspaceId, Guid vmUuid, string sourceComputerId, string machineName, string serverName, string databaseName) : base(workspaceId, vmUuid, sourceComputerId, machineName)
        {
            Argument.AssertNotNull(workspaceId, nameof(workspaceId));
            Argument.AssertNotNull(sourceComputerId, nameof(sourceComputerId));
            Argument.AssertNotNull(machineName, nameof(machineName));
            Argument.AssertNotNull(serverName, nameof(serverName));
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            ServerName = serverName;
            DatabaseName = databaseName;
            Source = Source.OnPremiseSql;
        }

        /// <summary> Initializes a new instance of OnPremiseSqlResourceDetails. </summary>
        /// <param name="source"> The platform where the assessed resource resides. </param>
        /// <param name="workspaceId"> Azure resource Id of the workspace the machine is attached to. </param>
        /// <param name="vmUuid"> The unique Id of the machine. </param>
        /// <param name="sourceComputerId"> The oms agent Id installed on the machine. </param>
        /// <param name="machineName"> The name of the machine. </param>
        /// <param name="serverName"> The Sql server name installed on the machine. </param>
        /// <param name="databaseName"> The Sql database name installed on the machine. </param>
        internal OnPremiseSqlResourceDetails(Source source, ResourceIdentifier workspaceId, Guid vmUuid, string sourceComputerId, string machineName, string serverName, string databaseName) : base(source, workspaceId, vmUuid, sourceComputerId, machineName)
        {
            ServerName = serverName;
            DatabaseName = databaseName;
            Source = source;
        }

        /// <summary> The Sql server name installed on the machine. </summary>
        public string ServerName { get; set; }
        /// <summary> The Sql database name installed on the machine. </summary>
        public string DatabaseName { get; set; }
    }
}
