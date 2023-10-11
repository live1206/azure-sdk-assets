// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Operation Job Extended Info. </summary>
    public partial class DataProtectionOperationJobExtendedInfo : DataProtectionOperationExtendedInfo
    {
        /// <summary> Initializes a new instance of DataProtectionOperationJobExtendedInfo. </summary>
        internal DataProtectionOperationJobExtendedInfo()
        {
            ObjectType = "OperationJobExtendedInfo";
        }

        /// <summary> Initializes a new instance of DataProtectionOperationJobExtendedInfo. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="jobResourceId"> Arm Id of the job created for this operation. </param>
        internal DataProtectionOperationJobExtendedInfo(string objectType, ResourceIdentifier jobResourceId) : base(objectType)
        {
            JobResourceId = jobResourceId;
            ObjectType = objectType ?? "OperationJobExtendedInfo";
        }

        /// <summary> Arm Id of the job created for this operation. </summary>
        public ResourceIdentifier JobResourceId { get; }
    }
}