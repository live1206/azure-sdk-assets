// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The list of cognitive services accounts operation response. </summary>
    internal partial class CognitiveServicesAccountListResult
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccountListResult. </summary>
        internal CognitiveServicesAccountListResult()
        {
            Value = new ChangeTrackingList<CognitiveServicesAccountData>();
        }

        /// <summary> Initializes a new instance of CognitiveServicesAccountListResult. </summary>
        /// <param name="nextLink"> The link used to get the next page of accounts. </param>
        /// <param name="value"> Gets the list of Cognitive Services accounts and their properties. </param>
        internal CognitiveServicesAccountListResult(string nextLink, IReadOnlyList<CognitiveServicesAccountData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of accounts. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of Cognitive Services accounts and their properties. </summary>
        public IReadOnlyList<CognitiveServicesAccountData> Value { get; }
    }
}