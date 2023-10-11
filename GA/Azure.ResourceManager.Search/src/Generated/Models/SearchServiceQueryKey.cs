// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes an API key for a given Azure Cognitive Search service that has permissions for query operations only. </summary>
    public partial class SearchServiceQueryKey
    {
        /// <summary> Initializes a new instance of SearchServiceQueryKey. </summary>
        internal SearchServiceQueryKey()
        {
        }

        /// <summary> Initializes a new instance of SearchServiceQueryKey. </summary>
        /// <param name="name"> The name of the query API key; may be empty. </param>
        /// <param name="key"> The value of the query API key. </param>
        internal SearchServiceQueryKey(string name, string key)
        {
            Name = name;
            Key = key;
        }

        /// <summary> The name of the query API key; may be empty. </summary>
        public string Name { get; }
        /// <summary> The value of the query API key. </summary>
        public string Key { get; }
    }
}