// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The response of a list operation. </summary>
    internal partial class FormulaList
    {
        /// <summary> Initializes a new instance of FormulaList. </summary>
        internal FormulaList()
        {
            Value = new ChangeTrackingList<DevTestLabFormulaData>();
        }

        /// <summary> Initializes a new instance of FormulaList. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link for next set of results. </param>
        internal FormulaList(IReadOnlyList<DevTestLabFormulaData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<DevTestLabFormulaData> Value { get; }
        /// <summary> Link for next set of results. </summary>
        public string NextLink { get; }
    }
}