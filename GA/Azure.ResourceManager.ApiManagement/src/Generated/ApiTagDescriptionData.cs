// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiTagDescription data model.
    /// Contract details.
    /// </summary>
    public partial class ApiTagDescriptionData : ResourceData
    {
        /// <summary> Initializes a new instance of ApiTagDescriptionData. </summary>
        public ApiTagDescriptionData()
        {
        }

        /// <summary> Initializes a new instance of ApiTagDescriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description of the Tag. </param>
        /// <param name="externalDocsUri"> Absolute URL of external resources describing the tag. </param>
        /// <param name="externalDocsDescription"> Description of the external resources describing the tag. </param>
        /// <param name="tagId"> Identifier of the tag in the form of /tags/{tagId}. </param>
        /// <param name="displayName"> Tag name. </param>
        internal ApiTagDescriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, Uri externalDocsUri, string externalDocsDescription, string tagId, string displayName) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ExternalDocsUri = externalDocsUri;
            ExternalDocsDescription = externalDocsDescription;
            TagId = tagId;
            DisplayName = displayName;
        }

        /// <summary> Description of the Tag. </summary>
        public string Description { get; set; }
        /// <summary> Absolute URL of external resources describing the tag. </summary>
        public Uri ExternalDocsUri { get; set; }
        /// <summary> Description of the external resources describing the tag. </summary>
        public string ExternalDocsDescription { get; set; }
        /// <summary> Identifier of the tag in the form of /tags/{tagId}. </summary>
        public string TagId { get; set; }
        /// <summary> Tag name. </summary>
        public string DisplayName { get; set; }
    }
}
