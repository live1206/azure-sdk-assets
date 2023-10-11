// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Get User Token response details. </summary>
    public partial class UserTokenResult
    {
        /// <summary> Initializes a new instance of UserTokenResult. </summary>
        internal UserTokenResult()
        {
        }

        /// <summary> Initializes a new instance of UserTokenResult. </summary>
        /// <param name="value"> Shared Access Authorization token for the User. </param>
        internal UserTokenResult(string value)
        {
            Value = value;
        }

        /// <summary> Shared Access Authorization token for the User. </summary>
        public string Value { get; }
    }
}