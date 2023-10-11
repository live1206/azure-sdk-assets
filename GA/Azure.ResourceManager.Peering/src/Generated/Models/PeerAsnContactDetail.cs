// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The contact detail class. </summary>
    public partial class PeerAsnContactDetail
    {
        /// <summary> Initializes a new instance of PeerAsnContactDetail. </summary>
        public PeerAsnContactDetail()
        {
        }

        /// <summary> Initializes a new instance of PeerAsnContactDetail. </summary>
        /// <param name="role"> The role of the contact. </param>
        /// <param name="email"> The e-mail address of the contact. </param>
        /// <param name="phone"> The phone number of the contact. </param>
        internal PeerAsnContactDetail(PeeringRole? role, string email, string phone)
        {
            Role = role;
            Email = email;
            Phone = phone;
        }

        /// <summary> The role of the contact. </summary>
        public PeeringRole? Role { get; set; }
        /// <summary> The e-mail address of the contact. </summary>
        public string Email { get; set; }
        /// <summary> The phone number of the contact. </summary>
        public string Phone { get; set; }
    }
}