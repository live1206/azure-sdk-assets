// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update connection operation. </summary>
    public partial class AutomationConnectionCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of AutomationConnectionCreateOrUpdateContent. </summary>
        /// <param name="name"> Gets or sets the name of the connection. </param>
        /// <param name="connectionType"> Gets or sets the connectionType of the connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="connectionType"/> is null. </exception>
        public AutomationConnectionCreateOrUpdateContent(string name, ConnectionTypeAssociationProperty connectionType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(connectionType, nameof(connectionType));

            Name = name;
            ConnectionType = connectionType;
            FieldDefinitionValues = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the name of the connection. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the description of the connection. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the connectionType of the connection. </summary>
        internal ConnectionTypeAssociationProperty ConnectionType { get; }
        /// <summary> Gets or sets the name of the connection type. </summary>
        public string ConnectionTypeName
        {
            get => ConnectionType?.Name;
        }

        /// <summary> Gets or sets the field definition properties of the connection. </summary>
        public IDictionary<string, string> FieldDefinitionValues { get; }
    }
}