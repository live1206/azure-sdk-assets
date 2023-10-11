// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> The name object for a server. </summary>
    public partial class CosmosDBForPostgreSqlServerNameItem
    {
        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlServerNameItem. </summary>
        internal CosmosDBForPostgreSqlServerNameItem()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlServerNameItem. </summary>
        /// <param name="name"> The name of a server. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        internal CosmosDBForPostgreSqlServerNameItem(string name, string fullyQualifiedDomainName)
        {
            Name = name;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
        }

        /// <summary> The name of a server. </summary>
        public string Name { get; }
        /// <summary> The fully qualified domain name of a server. </summary>
        public string FullyQualifiedDomainName { get; }
    }
}