// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformCertificate data model.
    /// Certificate resource payload.
    /// </summary>
    public partial class AppPlatformCertificateData : ResourceData
    {
        /// <summary> Initializes a new instance of AppPlatformCertificateData. </summary>
        public AppPlatformCertificateData()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of the certificate resource payload.
        /// Please note <see cref="AppPlatformCertificateProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppPlatformContentCertificateProperties"/> and <see cref="AppPlatformKeyVaultCertificateProperties"/>.
        /// </param>
        internal AppPlatformCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformCertificateProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// Properties of the certificate resource payload.
        /// Please note <see cref="AppPlatformCertificateProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppPlatformContentCertificateProperties"/> and <see cref="AppPlatformKeyVaultCertificateProperties"/>.
        /// </summary>
        public AppPlatformCertificateProperties Properties { get; set; }
    }
}