// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Describes information on user who created this ComputeInstance. </summary>
    public partial class MachineLearningComputeInstanceCreatedBy
    {
        /// <summary> Initializes a new instance of MachineLearningComputeInstanceCreatedBy. </summary>
        internal MachineLearningComputeInstanceCreatedBy()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningComputeInstanceCreatedBy. </summary>
        /// <param name="userName"> Name of the user. </param>
        /// <param name="userOrgId"> Uniquely identifies user' Azure Active Directory organization. </param>
        /// <param name="userId"> Uniquely identifies the user within his/her organization. </param>
        internal MachineLearningComputeInstanceCreatedBy(string userName, string userOrgId, string userId)
        {
            UserName = userName;
            UserOrgId = userOrgId;
            UserId = userId;
        }

        /// <summary> Name of the user. </summary>
        public string UserName { get; }
        /// <summary> Uniquely identifies user' Azure Active Directory organization. </summary>
        public string UserOrgId { get; }
        /// <summary> Uniquely identifies the user within his/her organization. </summary>
        public string UserId { get; }
    }
}