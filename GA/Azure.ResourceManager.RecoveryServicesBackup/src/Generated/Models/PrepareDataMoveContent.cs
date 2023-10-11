// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Prepare DataMove Request. </summary>
    public partial class PrepareDataMoveContent
    {
        /// <summary> Initializes a new instance of PrepareDataMoveContent. </summary>
        /// <param name="targetResourceId"> ARM Id of target vault. </param>
        /// <param name="targetRegion"> Target Region. </param>
        /// <param name="dataMoveLevel"> DataMove Level. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/> is null. </exception>
        public PrepareDataMoveContent(ResourceIdentifier targetResourceId, AzureLocation targetRegion, DataMoveLevel dataMoveLevel)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));

            TargetResourceId = targetResourceId;
            TargetRegion = targetRegion;
            DataMoveLevel = dataMoveLevel;
            SourceContainerArmIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> ARM Id of target vault. </summary>
        public ResourceIdentifier TargetResourceId { get; }
        /// <summary> Target Region. </summary>
        public AzureLocation TargetRegion { get; }
        /// <summary> DataMove Level. </summary>
        public DataMoveLevel DataMoveLevel { get; }
        /// <summary>
        /// Source Container ArmIds
        /// This needs to be populated only if DataMoveLevel is set to container
        /// </summary>
        public IList<ResourceIdentifier> SourceContainerArmIds { get; }
        /// <summary> Ignore the artifacts which are already moved. </summary>
        public bool? IgnoreMoved { get; set; }
    }
}