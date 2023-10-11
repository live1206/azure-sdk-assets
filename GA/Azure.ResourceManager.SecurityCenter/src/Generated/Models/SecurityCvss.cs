// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> CVSS details. </summary>
    public partial class SecurityCvss
    {
        /// <summary> Initializes a new instance of SecurityCvss. </summary>
        internal SecurityCvss()
        {
        }

        /// <summary> Initializes a new instance of SecurityCvss. </summary>
        /// <param name="base"> CVSS base. </param>
        internal SecurityCvss(float? @base)
        {
            Base = @base;
        }

        /// <summary> CVSS base. </summary>
        public float? Base { get; }
    }
}