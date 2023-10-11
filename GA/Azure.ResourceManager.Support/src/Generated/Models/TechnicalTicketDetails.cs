// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Additional information for technical support ticket. </summary>
    internal partial class TechnicalTicketDetails
    {
        /// <summary> Initializes a new instance of TechnicalTicketDetails. </summary>
        public TechnicalTicketDetails()
        {
        }

        /// <summary> Initializes a new instance of TechnicalTicketDetails. </summary>
        /// <param name="resourceId"> This is the resource Id of the Azure service resource (For example: A virtual machine resource or an HDInsight resource) for which the support ticket is created. </param>
        internal TechnicalTicketDetails(ResourceIdentifier resourceId)
        {
            ResourceId = resourceId;
        }

        /// <summary> This is the resource Id of the Azure service resource (For example: A virtual machine resource or an HDInsight resource) for which the support ticket is created. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}