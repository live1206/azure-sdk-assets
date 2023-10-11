// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the DataShare data model.
    /// A share data transfer object.
    /// </summary>
    public partial class DataShareData : ResourceData
    {
        /// <summary> Initializes a new instance of DataShareData. </summary>
        public DataShareData()
        {
        }

        /// <summary> Initializes a new instance of DataShareData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Time at which the share was created. </param>
        /// <param name="description"> Share description. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <param name="shareKind"> Share kind. </param>
        /// <param name="terms"> Share terms. </param>
        /// <param name="userEmail"> Email of the user who created the resource. </param>
        /// <param name="userName"> Name of the user who created the resource. </param>
        internal DataShareData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, string description, DataShareProvisioningState? provisioningState, DataShareKind? shareKind, string terms, string userEmail, string userName) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            Description = description;
            ProvisioningState = provisioningState;
            ShareKind = shareKind;
            Terms = terms;
            UserEmail = userEmail;
            UserName = userName;
        }

        /// <summary> Time at which the share was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Share description. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Share kind. </summary>
        public DataShareKind? ShareKind { get; set; }
        /// <summary> Share terms. </summary>
        public string Terms { get; set; }
        /// <summary> Email of the user who created the resource. </summary>
        public string UserEmail { get; }
        /// <summary> Name of the user who created the resource. </summary>
        public string UserName { get; }
    }
}