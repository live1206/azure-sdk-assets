// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for Content Key Policy key for token validation. A derived class must be used to create a token key.
    /// Please note <see cref="ContentKeyPolicyRestrictionTokenKey"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContentKeyPolicyRsaTokenKey"/>, <see cref="ContentKeyPolicySymmetricTokenKey"/> and <see cref="ContentKeyPolicyX509CertificateTokenKey"/>.
    /// </summary>
    public abstract partial class ContentKeyPolicyRestrictionTokenKey
    {
        /// <summary> Initializes a new instance of ContentKeyPolicyRestrictionTokenKey. </summary>
        protected ContentKeyPolicyRestrictionTokenKey()
        {
        }

        /// <summary> Initializes a new instance of ContentKeyPolicyRestrictionTokenKey. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal ContentKeyPolicyRestrictionTokenKey(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}