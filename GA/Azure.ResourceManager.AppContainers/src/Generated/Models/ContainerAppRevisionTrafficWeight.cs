// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Traffic weight assigned to a revision. </summary>
    public partial class ContainerAppRevisionTrafficWeight
    {
        /// <summary> Initializes a new instance of ContainerAppRevisionTrafficWeight. </summary>
        public ContainerAppRevisionTrafficWeight()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppRevisionTrafficWeight. </summary>
        /// <param name="revisionName"> Name of a revision. </param>
        /// <param name="weight"> Traffic weight assigned to a revision. </param>
        /// <param name="isLatestRevision"> Indicates that the traffic weight belongs to a latest stable revision. </param>
        /// <param name="label"> Associates a traffic label with a revision. </param>
        internal ContainerAppRevisionTrafficWeight(string revisionName, int? weight, bool? isLatestRevision, string label)
        {
            RevisionName = revisionName;
            Weight = weight;
            IsLatestRevision = isLatestRevision;
            Label = label;
        }

        /// <summary> Name of a revision. </summary>
        public string RevisionName { get; set; }
        /// <summary> Traffic weight assigned to a revision. </summary>
        public int? Weight { get; set; }
        /// <summary> Indicates that the traffic weight belongs to a latest stable revision. </summary>
        public bool? IsLatestRevision { get; set; }
        /// <summary> Associates a traffic label with a revision. </summary>
        public string Label { get; set; }
    }
}