// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Connection string for ingesting security data and logs. </summary>
    public partial class IngestionConnectionString
    {
        /// <summary> Initializes a new instance of IngestionConnectionString. </summary>
        internal IngestionConnectionString()
        {
        }

        /// <summary> Initializes a new instance of IngestionConnectionString. </summary>
        /// <param name="location"> The region where ingested logs and data resides. </param>
        /// <param name="value"> Connection string value. </param>
        internal IngestionConnectionString(AzureLocation? location, string value)
        {
            Location = location;
            Value = value;
        }

        /// <summary> The region where ingested logs and data resides. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Connection string value. </summary>
        public string Value { get; }
    }
}