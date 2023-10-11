// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Email Template update Parameters. </summary>
    public partial class ApiManagementEmailTemplateCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of ApiManagementEmailTemplateCreateOrUpdateContent. </summary>
        public ApiManagementEmailTemplateCreateOrUpdateContent()
        {
            Parameters = new ChangeTrackingList<EmailTemplateParametersContractProperties>();
        }

        /// <summary> Subject of the Template. </summary>
        public string Subject { get; set; }
        /// <summary> Title of the Template. </summary>
        public string Title { get; set; }
        /// <summary> Description of the Email Template. </summary>
        public string Description { get; set; }
        /// <summary> Email Template Body. This should be a valid XDocument. </summary>
        public string Body { get; set; }
        /// <summary> Email Template Parameter values. </summary>
        public IList<EmailTemplateParametersContractProperties> Parameters { get; }
    }
}