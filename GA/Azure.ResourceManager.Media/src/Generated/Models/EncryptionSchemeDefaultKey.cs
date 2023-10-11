// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify properties of default content key for each encryption scheme. </summary>
    public partial class EncryptionSchemeDefaultKey
    {
        /// <summary> Initializes a new instance of EncryptionSchemeDefaultKey. </summary>
        public EncryptionSchemeDefaultKey()
        {
        }

        /// <summary> Initializes a new instance of EncryptionSchemeDefaultKey. </summary>
        /// <param name="label"> Label can be used to specify Content Key when creating a Streaming Locator. </param>
        /// <param name="policyName"> Policy used by Default Key. </param>
        internal EncryptionSchemeDefaultKey(string label, string policyName)
        {
            Label = label;
            PolicyName = policyName;
        }

        /// <summary> Label can be used to specify Content Key when creating a Streaming Locator. </summary>
        public string Label { get; set; }
        /// <summary> Policy used by Default Key. </summary>
        public string PolicyName { get; set; }
    }
}