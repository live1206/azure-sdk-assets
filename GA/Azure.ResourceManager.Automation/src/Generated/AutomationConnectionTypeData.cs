// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationConnectionType data model.
    /// Definition of the connection type.
    /// </summary>
    public partial class AutomationConnectionTypeData : ResourceData
    {
        /// <summary> Initializes a new instance of AutomationConnectionTypeData. </summary>
        internal AutomationConnectionTypeData()
        {
            FieldDefinitions = new ChangeTrackingDictionary<string, AutomationConnectionFieldDefinition>();
        }

        /// <summary> Initializes a new instance of AutomationConnectionTypeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isGlobal"> Gets or sets a Boolean value to indicate if the connection type is global. </param>
        /// <param name="fieldDefinitions"> Gets the field definitions of the connection type. </param>
        /// <param name="createdOn"> Gets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time. </param>
        /// <param name="description"> Gets or sets the description. </param>
        internal AutomationConnectionTypeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isGlobal, IReadOnlyDictionary<string, AutomationConnectionFieldDefinition> fieldDefinitions, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string description) : base(id, name, resourceType, systemData)
        {
            IsGlobal = isGlobal;
            FieldDefinitions = fieldDefinitions;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Description = description;
        }

        /// <summary> Gets or sets a Boolean value to indicate if the connection type is global. </summary>
        public bool? IsGlobal { get; }
        /// <summary> Gets the field definitions of the connection type. </summary>
        public IReadOnlyDictionary<string, AutomationConnectionFieldDefinition> FieldDefinitions { get; }
        /// <summary> Gets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets or sets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; }
    }
}
