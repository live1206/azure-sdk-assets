// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of RunAs credential to use for hybrid worker. </summary>
    internal partial class RunAsCredentialAssociationProperty
    {
        /// <summary> Initializes a new instance of RunAsCredentialAssociationProperty. </summary>
        public RunAsCredentialAssociationProperty()
        {
        }

        /// <summary> Initializes a new instance of RunAsCredentialAssociationProperty. </summary>
        /// <param name="name"> Gets or sets the name of the credential. </param>
        internal RunAsCredentialAssociationProperty(string name)
        {
            Name = name;
        }

        /// <summary> Gets or sets the name of the credential. </summary>
        public string Name { get; set; }
    }
}