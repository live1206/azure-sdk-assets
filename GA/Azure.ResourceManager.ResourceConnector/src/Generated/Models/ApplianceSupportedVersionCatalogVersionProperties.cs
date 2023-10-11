// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> The SupportedVersionCatalogVersionData object for appliance. </summary>
    public partial class ApplianceSupportedVersionCatalogVersionProperties
    {
        /// <summary> Initializes a new instance of ApplianceSupportedVersionCatalogVersionProperties. </summary>
        internal ApplianceSupportedVersionCatalogVersionProperties()
        {
        }

        /// <summary> Initializes a new instance of ApplianceSupportedVersionCatalogVersionProperties. </summary>
        /// <param name="audience"> The image audience name for the version available for upgrade. </param>
        /// <param name="catalog"> The image catalog name for the version available for upgrade. </param>
        /// <param name="offer"> The image offer name for the version available for upgrade. </param>
        /// <param name="version"> The image version for the version available for upgrade. </param>
        internal ApplianceSupportedVersionCatalogVersionProperties(string audience, string catalog, string offer, string version)
        {
            Audience = audience;
            Catalog = catalog;
            Offer = offer;
            Version = version;
        }

        /// <summary> The image audience name for the version available for upgrade. </summary>
        public string Audience { get; }
        /// <summary> The image catalog name for the version available for upgrade. </summary>
        public string Catalog { get; }
        /// <summary> The image offer name for the version available for upgrade. </summary>
        public string Offer { get; }
        /// <summary> The image version for the version available for upgrade. </summary>
        public string Version { get; }
    }
}