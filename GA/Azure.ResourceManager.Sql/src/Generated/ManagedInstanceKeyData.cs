// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstanceKey data model.
    /// A managed instance key.
    /// </summary>
    public partial class ManagedInstanceKeyData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedInstanceKeyData. </summary>
        public ManagedInstanceKeyData()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceKeyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of encryption protector. This is metadata used for the Azure portal experience. </param>
        /// <param name="serverKeyType"> The key type like 'ServiceManaged', 'AzureKeyVault'. </param>
        /// <param name="uri"> The URI of the key. If the ServerKeyType is AzureKeyVault, then the URI is required. </param>
        /// <param name="thumbprint"> Thumbprint of the key. </param>
        /// <param name="createdOn"> The key creation date. </param>
        /// <param name="isAutoRotationEnabled"> Key auto rotation opt-in flag. Either true or false. </param>
        internal ManagedInstanceKeyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, SqlServerKeyType? serverKeyType, Uri uri, string thumbprint, DateTimeOffset? createdOn, bool? isAutoRotationEnabled) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ServerKeyType = serverKeyType;
            Uri = uri;
            Thumbprint = thumbprint;
            CreatedOn = createdOn;
            IsAutoRotationEnabled = isAutoRotationEnabled;
        }

        /// <summary> Kind of encryption protector. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> The key type like 'ServiceManaged', 'AzureKeyVault'. </summary>
        public SqlServerKeyType? ServerKeyType { get; set; }
        /// <summary> The URI of the key. If the ServerKeyType is AzureKeyVault, then the URI is required. </summary>
        public Uri Uri { get; set; }
        /// <summary> Thumbprint of the key. </summary>
        public string Thumbprint { get; }
        /// <summary> The key creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Key auto rotation opt-in flag. Either true or false. </summary>
        public bool? IsAutoRotationEnabled { get; }
    }
}
