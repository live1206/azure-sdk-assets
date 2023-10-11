// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EnergyServices.Models
{
    /// <summary> Defines the partition add/ delete action properties. </summary>
    public partial class DataPartitionAddOrRemoveContent
    {
        /// <summary> Initializes a new instance of DataPartitionAddOrRemoveContent. </summary>
        public DataPartitionAddOrRemoveContent()
        {
        }

        /// <summary> Initializes a new instance of DataPartitionAddOrRemoveContent. </summary>
        /// <param name="name"> The list of Energy services resource's Data Partition Names. </param>
        internal DataPartitionAddOrRemoveContent(DataPartitionName name)
        {
            Name = name;
        }
    }
}