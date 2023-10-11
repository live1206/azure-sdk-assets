// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> name and value of HTTP/S header to insert. </summary>
    public partial class FirewallPolicyHttpHeaderToInsert
    {
        /// <summary> Initializes a new instance of FirewallPolicyHttpHeaderToInsert. </summary>
        public FirewallPolicyHttpHeaderToInsert()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyHttpHeaderToInsert. </summary>
        /// <param name="headerName"> Contains the name of the header. </param>
        /// <param name="headerValue"> Contains the value of the header. </param>
        internal FirewallPolicyHttpHeaderToInsert(string headerName, string headerValue)
        {
            HeaderName = headerName;
            HeaderValue = headerValue;
        }

        /// <summary> Contains the name of the header. </summary>
        public string HeaderName { get; set; }
        /// <summary> Contains the value of the header. </summary>
        public string HeaderValue { get; set; }
    }
}