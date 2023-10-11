// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A class representing the ElasticSanVolume data model.
    /// Response for Volume request.
    /// </summary>
    public partial class ElasticSanVolumeData : ResourceData
    {
        /// <summary> Initializes a new instance of ElasticSanVolumeData. </summary>
        /// <param name="sizeGiB"> Volume size. </param>
        public ElasticSanVolumeData(long sizeGiB)
        {
            SizeGiB = sizeGiB;
        }

        /// <summary> Initializes a new instance of ElasticSanVolumeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="volumeId"> Unique Id of the volume in GUID format. </param>
        /// <param name="creationData"> State of the operation on the resource. </param>
        /// <param name="sizeGiB"> Volume size. </param>
        /// <param name="storageTarget"> Storage target information. </param>
        internal ElasticSanVolumeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? volumeId, ElasticSanVolumeDataSourceInfo creationData, long sizeGiB, IscsiTargetInfo storageTarget) : base(id, name, resourceType, systemData)
        {
            VolumeId = volumeId;
            CreationData = creationData;
            SizeGiB = sizeGiB;
            StorageTarget = storageTarget;
        }

        /// <summary> Unique Id of the volume in GUID format. </summary>
        public Guid? VolumeId { get; }
        /// <summary> State of the operation on the resource. </summary>
        public ElasticSanVolumeDataSourceInfo CreationData { get; set; }
        /// <summary> Volume size. </summary>
        public long SizeGiB { get; set; }
        /// <summary> Storage target information. </summary>
        public IscsiTargetInfo StorageTarget { get; }
    }
}