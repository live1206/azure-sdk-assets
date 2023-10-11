// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// BasePolicy Rule
    /// Please note <see cref="DataProtectionBasePolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataProtectionBackupRule"/> and <see cref="DataProtectionRetentionRule"/>.
    /// </summary>
    public abstract partial class DataProtectionBasePolicyRule
    {
        /// <summary> Initializes a new instance of DataProtectionBasePolicyRule. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected DataProtectionBasePolicyRule(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of DataProtectionBasePolicyRule. </summary>
        /// <param name="name"></param>
        /// <param name="objectType"></param>
        internal DataProtectionBasePolicyRule(string name, string objectType)
        {
            Name = name;
            ObjectType = objectType;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the object type. </summary>
        internal string ObjectType { get; set; }
    }
}