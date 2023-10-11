// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Request entity for previewing the Static Site workflow. </summary>
    public partial class StaticSitesWorkflowPreviewContent : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSitesWorkflowPreviewContent. </summary>
        public StaticSitesWorkflowPreviewContent()
        {
        }

        /// <summary> Initializes a new instance of StaticSitesWorkflowPreviewContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="repositoryUri"> URL for the repository of the static site. </param>
        /// <param name="branch"> The target branch in the repository. </param>
        /// <param name="buildProperties"> Build properties to configure on the repository. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSitesWorkflowPreviewContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri repositoryUri, string branch, StaticSiteBuildProperties buildProperties, string kind) : base(id, name, resourceType, systemData)
        {
            RepositoryUri = repositoryUri;
            Branch = branch;
            BuildProperties = buildProperties;
            Kind = kind;
        }

        /// <summary> URL for the repository of the static site. </summary>
        public Uri RepositoryUri { get; set; }
        /// <summary> The target branch in the repository. </summary>
        public string Branch { get; set; }
        /// <summary> Build properties to configure on the repository. </summary>
        public StaticSiteBuildProperties BuildProperties { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}