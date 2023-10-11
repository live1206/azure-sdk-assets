// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The ListTableServices. </summary>
    internal partial class ListTableServices
    {
        /// <summary> Initializes a new instance of ListTableServices. </summary>
        internal ListTableServices()
        {
            Value = new ChangeTrackingList<TableServiceData>();
        }

        /// <summary> Initializes a new instance of ListTableServices. </summary>
        /// <param name="value"> List of table services returned. </param>
        internal ListTableServices(IReadOnlyList<TableServiceData> value)
        {
            Value = value;
        }

        /// <summary> List of table services returned. </summary>
        public IReadOnlyList<TableServiceData> Value { get; }
    }
}