// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Properties of the additional workspaces. </summary>
    public partial class AdditionalWorkspacesProperties
    {
        /// <summary> Initializes a new instance of AdditionalWorkspacesProperties. </summary>
        public AdditionalWorkspacesProperties()
        {
            DataTypes = new ChangeTrackingList<AdditionalWorkspaceDataType>();
        }

        /// <summary> Initializes a new instance of AdditionalWorkspacesProperties. </summary>
        /// <param name="workspace"> Workspace resource id. </param>
        /// <param name="workspaceType"> Workspace type. </param>
        /// <param name="dataTypes"> List of data types sent to workspace. </param>
        internal AdditionalWorkspacesProperties(string workspace, AdditionalWorkspaceType? workspaceType, IList<AdditionalWorkspaceDataType> dataTypes)
        {
            Workspace = workspace;
            WorkspaceType = workspaceType;
            DataTypes = dataTypes;
        }

        /// <summary> Workspace resource id. </summary>
        public string Workspace { get; set; }
        /// <summary> Workspace type. </summary>
        public AdditionalWorkspaceType? WorkspaceType { get; set; }
        /// <summary> List of data types sent to workspace. </summary>
        public IList<AdditionalWorkspaceDataType> DataTypes { get; }
    }
}