// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The batch configuration properties definition. </summary>
    public partial class IntegrationAccountBatchConfigurationProperties : ArtifactProperties
    {
        /// <summary> Initializes a new instance of IntegrationAccountBatchConfigurationProperties. </summary>
        /// <param name="batchGroupName"> The name of the batch group. </param>
        /// <param name="releaseCriteria"> The batch release criteria. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="batchGroupName"/> or <paramref name="releaseCriteria"/> is null. </exception>
        public IntegrationAccountBatchConfigurationProperties(string batchGroupName, IntegrationAccountBatchReleaseCriteria releaseCriteria)
        {
            Argument.AssertNotNull(batchGroupName, nameof(batchGroupName));
            Argument.AssertNotNull(releaseCriteria, nameof(releaseCriteria));

            BatchGroupName = batchGroupName;
            ReleaseCriteria = releaseCriteria;
        }

        /// <summary> Initializes a new instance of IntegrationAccountBatchConfigurationProperties. </summary>
        /// <param name="createdOn"> The artifact creation time. </param>
        /// <param name="changedOn"> The artifact changed time. </param>
        /// <param name="metadata"> Anything. </param>
        /// <param name="batchGroupName"> The name of the batch group. </param>
        /// <param name="releaseCriteria"> The batch release criteria. </param>
        internal IntegrationAccountBatchConfigurationProperties(DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, string batchGroupName, IntegrationAccountBatchReleaseCriteria releaseCriteria) : base(createdOn, changedOn, metadata)
        {
            BatchGroupName = batchGroupName;
            ReleaseCriteria = releaseCriteria;
        }

        /// <summary> The name of the batch group. </summary>
        public string BatchGroupName { get; set; }
        /// <summary> The batch release criteria. </summary>
        public IntegrationAccountBatchReleaseCriteria ReleaseCriteria { get; set; }
    }
}