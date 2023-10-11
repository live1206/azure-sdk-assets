// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Retention tag. </summary>
    public partial class DataProtectionBackupRetentionTag
    {
        /// <summary> Initializes a new instance of DataProtectionBackupRetentionTag. </summary>
        /// <param name="tagName"> Retention Tag Name to relate it to retention rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tagName"/> is null. </exception>
        public DataProtectionBackupRetentionTag(string tagName)
        {
            Argument.AssertNotNull(tagName, nameof(tagName));

            TagName = tagName;
        }

        /// <summary> Initializes a new instance of DataProtectionBackupRetentionTag. </summary>
        /// <param name="eTag"> Retention Tag version. </param>
        /// <param name="id"> Retention Tag version. </param>
        /// <param name="tagName"> Retention Tag Name to relate it to retention rule. </param>
        internal DataProtectionBackupRetentionTag(ETag? eTag, string id, string tagName)
        {
            ETag = eTag;
            Id = id;
            TagName = tagName;
        }

        /// <summary> Retention Tag version. </summary>
        public ETag? ETag { get; }
        /// <summary> Retention Tag version. </summary>
        public string Id { get; }
        /// <summary> Retention Tag Name to relate it to retention rule. </summary>
        public string TagName { get; set; }
    }
}