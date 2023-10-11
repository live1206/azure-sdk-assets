// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update module operation. </summary>
    public partial class AutomationAccountModuleCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of AutomationAccountModuleCreateOrUpdateContent. </summary>
        /// <param name="contentLink"> Gets or sets the module content link. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentLink"/> is null. </exception>
        public AutomationAccountModuleCreateOrUpdateContent(AutomationContentLink contentLink)
        {
            Argument.AssertNotNull(contentLink, nameof(contentLink));

            Tags = new ChangeTrackingDictionary<string, string>();
            ContentLink = contentLink;
        }

        /// <summary> Gets or sets name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the module content link. </summary>
        public AutomationContentLink ContentLink { get; }
    }
}