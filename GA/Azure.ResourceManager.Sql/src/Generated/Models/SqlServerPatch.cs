// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update request for an Azure SQL Database server. </summary>
    public partial class SqlServerPatch
    {
        /// <summary> Initializes a new instance of SqlServerPatch. </summary>
        public SqlServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<SqlServerPrivateEndpointConnection>();
        }

        /// <summary> Server identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Administrator username for the server. Once created it cannot be changed. </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for server creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> The version of the server. </summary>
        public string Version { get; set; }
        /// <summary> The state of the server. </summary>
        public string State { get; }
        /// <summary> The fully qualified domain name of the server. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> List of private endpoint connections on a server. </summary>
        public IReadOnlyList<SqlServerPrivateEndpointConnection> PrivateEndpointConnections { get; }
        /// <summary> Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'. </summary>
        public string MinimalTlsVersion { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this server.  Value is optional but if passed in, must be 'Enabled' or 'Disabled' or 'SecuredByPerimeter'. </summary>
        public ServerNetworkAccessFlag? PublicNetworkAccess { get; set; }
        /// <summary> Whether or not existing server has a workspace created and if it allows connection from workspace. </summary>
        public ServerWorkspaceFeature? WorkspaceFeature { get; }
        /// <summary> The resource id of a user assigned identity to be used by default. </summary>
        public ResourceIdentifier PrimaryUserAssignedIdentityId { get; set; }
        /// <summary> The Client id used for cross tenant CMK scenario. </summary>
        public Guid? FederatedClientId { get; set; }
        /// <summary> A CMK URI of the key to use for encryption. </summary>
        public Uri KeyId { get; set; }
        /// <summary> The Azure Active Directory administrator of the server. This can only be used at server create time. If used for server update, it will be ignored or it will result in an error. For updates individual APIs will need to be used. </summary>
        public ServerExternalAdministrator Administrators { get; set; }
        /// <summary> Whether or not to restrict outbound network access for this server.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </summary>
        public ServerNetworkAccessFlag? RestrictOutboundNetworkAccess { get; set; }
        /// <summary> Status of external governance. </summary>
        public ExternalGovernanceStatus? ExternalGovernanceStatus { get; }
    }
}