// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Push settings for the App. </summary>
    public partial class WebAppPushSettings : ResourceData
    {
        /// <summary> Initializes a new instance of WebAppPushSettings. </summary>
        public WebAppPushSettings()
        {
        }

        /// <summary> Initializes a new instance of WebAppPushSettings. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isPushEnabled"> Gets or sets a flag indicating whether the Push endpoint is enabled. </param>
        /// <param name="tagWhitelistJson"> Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint. </param>
        /// <param name="tagsRequiringAuth">
        /// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.
        /// </param>
        /// <param name="dynamicTagsJson"> Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal WebAppPushSettings(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isPushEnabled, string tagWhitelistJson, string tagsRequiringAuth, string dynamicTagsJson, string kind) : base(id, name, resourceType, systemData)
        {
            IsPushEnabled = isPushEnabled;
            TagWhitelistJson = tagWhitelistJson;
            TagsRequiringAuth = tagsRequiringAuth;
            DynamicTagsJson = dynamicTagsJson;
            Kind = kind;
        }

        /// <summary> Gets or sets a flag indicating whether the Push endpoint is enabled. </summary>
        public bool? IsPushEnabled { get; set; }
        /// <summary> Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint. </summary>
        public string TagWhitelistJson { get; set; }
        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        public string TagsRequiringAuth { get; set; }
        /// <summary> Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint. </summary>
        public string DynamicTagsJson { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}