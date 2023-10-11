// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The dsc extensionHandler property associated with the node. </summary>
    public partial class DscNodeExtensionHandlerAssociationProperty
    {
        /// <summary> Initializes a new instance of DscNodeExtensionHandlerAssociationProperty. </summary>
        public DscNodeExtensionHandlerAssociationProperty()
        {
        }

        /// <summary> Initializes a new instance of DscNodeExtensionHandlerAssociationProperty. </summary>
        /// <param name="name"> Gets or sets the name of the extension handler. </param>
        /// <param name="version"> Gets or sets the version of the extension handler. </param>
        internal DscNodeExtensionHandlerAssociationProperty(string name, string version)
        {
            Name = name;
            Version = version;
        }

        /// <summary> Gets or sets the name of the extension handler. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the version of the extension handler. </summary>
        public string Version { get; set; }
    }
}