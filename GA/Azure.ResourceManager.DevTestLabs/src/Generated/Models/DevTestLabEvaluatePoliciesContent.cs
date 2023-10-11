// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Request body for evaluating a policy set. </summary>
    public partial class DevTestLabEvaluatePoliciesContent
    {
        /// <summary> Initializes a new instance of DevTestLabEvaluatePoliciesContent. </summary>
        public DevTestLabEvaluatePoliciesContent()
        {
            Policies = new ChangeTrackingList<DevTestLabEvaluatePolicy>();
        }

        /// <summary> Policies to evaluate. </summary>
        public IList<DevTestLabEvaluatePolicy> Policies { get; }
    }
}
