// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// Partner client authentication
    /// Please note <see cref="PartnerClientAuthentication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureADPartnerClientAuthentication"/>.
    /// </summary>
    public abstract partial class PartnerClientAuthentication
    {
        /// <summary> Initializes a new instance of PartnerClientAuthentication. </summary>
        protected PartnerClientAuthentication()
        {
        }

        /// <summary> Initializes a new instance of PartnerClientAuthentication. </summary>
        /// <param name="clientAuthenticationType"> Type of client authentication. </param>
        internal PartnerClientAuthentication(PartnerClientAuthenticationType clientAuthenticationType)
        {
            ClientAuthenticationType = clientAuthenticationType;
        }

        /// <summary> Type of client authentication. </summary>
        internal PartnerClientAuthenticationType ClientAuthenticationType { get; set; }
    }
}