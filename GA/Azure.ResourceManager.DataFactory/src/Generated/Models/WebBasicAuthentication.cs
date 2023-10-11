// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A WebLinkedService that uses basic authentication to communicate with an HTTP endpoint. </summary>
    public partial class WebBasicAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of WebBasicAuthentication. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="username"> User name for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password for Basic authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/>, <paramref name="username"/> or <paramref name="password"/> is null. </exception>
        public WebBasicAuthentication(DataFactoryElement<string> uri, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password) : base(uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(password, nameof(password));

            Username = username;
            Password = password;
            AuthenticationType = WebAuthenticationType.Basic;
        }

        /// <summary> Initializes a new instance of WebBasicAuthentication. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="username"> User name for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password for Basic authentication. </param>
        internal WebBasicAuthentication(DataFactoryElement<string> uri, WebAuthenticationType authenticationType, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password) : base(uri, authenticationType)
        {
            Username = username;
            Password = password;
            AuthenticationType = authenticationType;
        }

        /// <summary> User name for Basic authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> The password for Basic authentication. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
    }
}