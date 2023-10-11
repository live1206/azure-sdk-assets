// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Settings concerning key vault encryption for a configuration store. </summary>
    public partial class AutomationKeyVaultProperties
    {
        /// <summary> Initializes a new instance of AutomationKeyVaultProperties. </summary>
        public AutomationKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of AutomationKeyVaultProperties. </summary>
        /// <param name="keyvaultUri"> The URI of the key vault key used to encrypt data. </param>
        /// <param name="keyName"> The name of key used to encrypt data. </param>
        /// <param name="keyVersion"> The key version of the key used to encrypt data. </param>
        internal AutomationKeyVaultProperties(Uri keyvaultUri, string keyName, string keyVersion)
        {
            KeyvaultUri = keyvaultUri;
            KeyName = keyName;
            KeyVersion = keyVersion;
        }

        /// <summary> The URI of the key vault key used to encrypt data. </summary>
        public Uri KeyvaultUri { get; set; }
        /// <summary> The name of key used to encrypt data. </summary>
        public string KeyName { get; set; }
        /// <summary> The key version of the key used to encrypt data. </summary>
        public string KeyVersion { get; set; }
    }
}
