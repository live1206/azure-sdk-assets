// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> User information that made some action. </summary>
    public partial class SecurityInsightsUserInfo
    {
        /// <summary> Initializes a new instance of SecurityInsightsUserInfo. </summary>
        public SecurityInsightsUserInfo()
        {
        }

        /// <summary> Initializes a new instance of SecurityInsightsUserInfo. </summary>
        /// <param name="email"> The email of the user. </param>
        /// <param name="name"> The name of the user. </param>
        /// <param name="objectId"> The object id of the user. </param>
        internal SecurityInsightsUserInfo(string email, string name, Guid? objectId)
        {
            Email = email;
            Name = name;
            ObjectId = objectId;
        }

        /// <summary> The email of the user. </summary>
        public string Email { get; }
        /// <summary> The name of the user. </summary>
        public string Name { get; }
        /// <summary> The object id of the user. </summary>
        public Guid? ObjectId { get; set; }
    }
}
