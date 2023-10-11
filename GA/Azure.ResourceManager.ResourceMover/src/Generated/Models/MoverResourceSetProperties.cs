// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the move collection properties. </summary>
    public partial class MoverResourceSetProperties
    {
        /// <summary> Initializes a new instance of MoverResourceSetProperties. </summary>
        public MoverResourceSetProperties()
        {
        }

        /// <summary> Initializes a new instance of MoverResourceSetProperties. </summary>
        /// <param name="sourceLocation"> Gets or sets the source region. </param>
        /// <param name="targetLocation"> Gets or sets the target region. </param>
        /// <param name="moveLocation"> Gets or sets the move region which indicates the region where the VM Regional to Zonal move will be conducted. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="version"> Gets or sets the version of move collection. </param>
        /// <param name="moveType"> Defines the MoveType. </param>
        /// <param name="errors"> Defines the move collection errors. </param>
        internal MoverResourceSetProperties(AzureLocation? sourceLocation, AzureLocation? targetLocation, AzureLocation? moveLocation, MoverProvisioningState? provisioningState, string version, MoveType? moveType, MoveCollectionPropertiesErrors errors)
        {
            SourceLocation = sourceLocation;
            TargetLocation = targetLocation;
            MoveLocation = moveLocation;
            ProvisioningState = provisioningState;
            Version = version;
            MoveType = moveType;
            Errors = errors;
        }

        /// <summary> Gets or sets the source region. </summary>
        public AzureLocation? SourceLocation { get; set; }
        /// <summary> Gets or sets the target region. </summary>
        public AzureLocation? TargetLocation { get; set; }
        /// <summary> Gets or sets the move region which indicates the region where the VM Regional to Zonal move will be conducted. </summary>
        public AzureLocation? MoveLocation { get; set; }
        /// <summary> Defines the provisioning states. </summary>
        public MoverProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the version of move collection. </summary>
        public string Version { get; set; }
        /// <summary> Defines the MoveType. </summary>
        public MoveType? MoveType { get; set; }
        /// <summary> Defines the move collection errors. </summary>
        internal MoveCollectionPropertiesErrors Errors { get; }
        /// <summary> The move resource error body. </summary>
        public ResponseError ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}