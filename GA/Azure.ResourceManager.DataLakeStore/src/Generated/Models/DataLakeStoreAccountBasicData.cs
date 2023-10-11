// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Basic Data Lake Store account information, returned on list calls. </summary>
    public partial class DataLakeStoreAccountBasicData : ResourceData
    {
        /// <summary> Initializes a new instance of DataLakeStoreAccountBasicData. </summary>
        internal DataLakeStoreAccountBasicData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DataLakeStoreAccountBasicData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="accountId"> The unique identifier associated with this Data Lake Store account. </param>
        /// <param name="provisioningState"> The provisioning status of the Data Lake Store account. </param>
        /// <param name="state"> The state of the Data Lake Store account. </param>
        /// <param name="createdOn"> The account creation time. </param>
        /// <param name="lastModifiedOn"> The account last modified time. </param>
        /// <param name="endpoint"> The full CName endpoint for this account. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        internal DataLakeStoreAccountBasicData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? accountId, DataLakeStoreAccountStatus? provisioningState, DataLakeStoreAccountState? state, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string endpoint, AzureLocation? location, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            AccountId = accountId;
            ProvisioningState = provisioningState;
            State = state;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Endpoint = endpoint;
            Location = location;
            Tags = tags;
        }

        /// <summary> The unique identifier associated with this Data Lake Store account. </summary>
        public Guid? AccountId { get; }
        /// <summary> The provisioning status of the Data Lake Store account. </summary>
        public DataLakeStoreAccountStatus? ProvisioningState { get; }
        /// <summary> The state of the Data Lake Store account. </summary>
        public DataLakeStoreAccountState? State { get; }
        /// <summary> The account creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The account last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The full CName endpoint for this account. </summary>
        public string Endpoint { get; }
        /// <summary> The resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}