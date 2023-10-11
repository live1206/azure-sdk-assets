// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Indicates that either the API key or an access token from Azure Active Directory can be used for authentication. </summary>
    internal partial class DataPlaneAadOrApiKeyAuthOption
    {
        /// <summary> Initializes a new instance of DataPlaneAadOrApiKeyAuthOption. </summary>
        public DataPlaneAadOrApiKeyAuthOption()
        {
        }

        /// <summary> Initializes a new instance of DataPlaneAadOrApiKeyAuthOption. </summary>
        /// <param name="aadAuthFailureMode"> Describes what response the data plane API of a Search service would send for requests that failed authentication. </param>
        internal DataPlaneAadOrApiKeyAuthOption(SearchAadAuthFailureMode? aadAuthFailureMode)
        {
            AadAuthFailureMode = aadAuthFailureMode;
        }

        /// <summary> Describes what response the data plane API of a Search service would send for requests that failed authentication. </summary>
        public SearchAadAuthFailureMode? AadAuthFailureMode { get; set; }
    }
}