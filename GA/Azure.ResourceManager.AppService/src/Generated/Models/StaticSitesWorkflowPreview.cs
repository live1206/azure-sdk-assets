// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Preview for the Static Site Workflow to be generated. </summary>
    public partial class StaticSitesWorkflowPreview : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSitesWorkflowPreview. </summary>
        public StaticSitesWorkflowPreview()
        {
        }

        /// <summary> Initializes a new instance of StaticSitesWorkflowPreview. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="path"> The path for the workflow file to be generated. </param>
        /// <param name="contents"> The contents for the workflow file to be generated. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSitesWorkflowPreview(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string path, string contents, string kind) : base(id, name, resourceType, systemData)
        {
            Path = path;
            Contents = contents;
            Kind = kind;
        }

        /// <summary> The path for the workflow file to be generated. </summary>
        public string Path { get; }
        /// <summary> The contents for the workflow file to be generated. </summary>
        public string Contents { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}