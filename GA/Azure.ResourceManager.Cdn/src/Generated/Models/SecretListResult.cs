// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list secrets. It contains a list of Secret objects and a URL link to get the next set of results. </summary>
    internal partial class SecretListResult
    {
        /// <summary> Initializes a new instance of SecretListResult. </summary>
        internal SecretListResult()
        {
            Value = new ChangeTrackingList<FrontDoorSecretData>();
        }

        /// <summary> Initializes a new instance of SecretListResult. </summary>
        /// <param name="value"> List of AzureFrontDoor secrets within a profile. </param>
        /// <param name="nextLink"> URL to get the next set of Secret objects if there are any. </param>
        internal SecretListResult(IReadOnlyList<FrontDoorSecretData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of AzureFrontDoor secrets within a profile. </summary>
        public IReadOnlyList<FrontDoorSecretData> Value { get; }
        /// <summary> URL to get the next set of Secret objects if there are any. </summary>
        public string NextLink { get; }
    }
}