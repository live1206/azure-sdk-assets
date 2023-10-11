// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the MongoDBUserDefinition data model.
    /// An Azure Cosmos DB User Definition
    /// </summary>
    public partial class MongoDBUserDefinitionData : ResourceData
    {
        /// <summary> Initializes a new instance of MongoDBUserDefinitionData. </summary>
        public MongoDBUserDefinitionData()
        {
            Roles = new ChangeTrackingList<MongoDBRole>();
        }

        /// <summary> Initializes a new instance of MongoDBUserDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="userName"> The user name for User Definition. </param>
        /// <param name="password"> The password for User Definition. Response does not contain user password. </param>
        /// <param name="databaseName"> The database name for which access is being granted for this User Definition. </param>
        /// <param name="customData"> A custom definition for the USer Definition. </param>
        /// <param name="roles"> The set of roles inherited by the User Definition. </param>
        /// <param name="mechanisms"> The Mongo Auth mechanism. For now, we only support auth mechanism SCRAM-SHA-256. </param>
        internal MongoDBUserDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string userName, string password, string databaseName, string customData, IList<MongoDBRole> roles, string mechanisms) : base(id, name, resourceType, systemData)
        {
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;
            CustomData = customData;
            Roles = roles;
            Mechanisms = mechanisms;
        }

        /// <summary> The user name for User Definition. </summary>
        public string UserName { get; set; }
        /// <summary> The password for User Definition. Response does not contain user password. </summary>
        public string Password { get; set; }
        /// <summary> The database name for which access is being granted for this User Definition. </summary>
        public string DatabaseName { get; set; }
        /// <summary> A custom definition for the USer Definition. </summary>
        public string CustomData { get; set; }
        /// <summary> The set of roles inherited by the User Definition. </summary>
        public IList<MongoDBRole> Roles { get; }
        /// <summary> The Mongo Auth mechanism. For now, we only support auth mechanism SCRAM-SHA-256. </summary>
        public string Mechanisms { get; set; }
    }
}