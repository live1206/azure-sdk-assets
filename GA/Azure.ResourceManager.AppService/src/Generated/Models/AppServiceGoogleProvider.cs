// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Google provider. </summary>
    public partial class AppServiceGoogleProvider
    {
        /// <summary> Initializes a new instance of AppServiceGoogleProvider. </summary>
        public AppServiceGoogleProvider()
        {
        }

        /// <summary> Initializes a new instance of AppServiceGoogleProvider. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the Google provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the Google provider. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        /// <param name="validation"> The configuration settings of the Azure Active Directory token validation flow. </param>
        internal AppServiceGoogleProvider(bool? isEnabled, ClientRegistration registration, LoginScopes login, AllowedAudiencesValidation validation)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
            Validation = validation;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Google provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the app registration for the Google provider. </summary>
        public ClientRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow. </summary>
        internal LoginScopes Login { get; set; }
        /// <summary> A list of the scopes that should be requested while authenticating. </summary>
        public IList<string> LoginScopes
        {
            get
            {
                if (Login is null)
                    Login = new LoginScopes();
                return Login.Scopes;
            }
        }

        /// <summary> The configuration settings of the Azure Active Directory token validation flow. </summary>
        internal AllowedAudiencesValidation Validation { get; set; }
        /// <summary> The configuration settings of the allowed list of audiences from which to validate the JWT token. </summary>
        public IList<string> ValidationAllowedAudiences
        {
            get
            {
                if (Validation is null)
                    Validation = new AllowedAudiencesValidation();
                return Validation.AllowedAudiences;
            }
        }
    }
}
