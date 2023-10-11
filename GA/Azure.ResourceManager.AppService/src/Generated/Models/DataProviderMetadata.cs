// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Additional configuration for a data providers. </summary>
    public partial class DataProviderMetadata
    {
        /// <summary> Initializes a new instance of DataProviderMetadata. </summary>
        public DataProviderMetadata()
        {
            PropertyBag = new ChangeTrackingList<DataProviderKeyValuePair>();
        }

        /// <summary> Initializes a new instance of DataProviderMetadata. </summary>
        /// <param name="providerName"></param>
        /// <param name="propertyBag"> Settings for the data provider. </param>
        internal DataProviderMetadata(string providerName, IReadOnlyList<DataProviderKeyValuePair> propertyBag)
        {
            ProviderName = providerName;
            PropertyBag = propertyBag;
        }

        /// <summary> Gets or sets the provider name. </summary>
        public string ProviderName { get; set; }
        /// <summary> Settings for the data provider. </summary>
        public IReadOnlyList<DataProviderKeyValuePair> PropertyBag { get; }
    }
}