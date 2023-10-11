// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the GitHub provider. </summary>
    public partial class AppServiceGitHubProvider
    {
        /// <summary> Initializes a new instance of AppServiceGitHubProvider. </summary>
        public AppServiceGitHubProvider()
        {
        }

        /// <summary> Initializes a new instance of AppServiceGitHubProvider. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the app registration for the GitHub provider. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        internal AppServiceGitHubProvider(bool? isEnabled, ClientRegistration registration, LoginScopes login)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the GitHub provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the app registration for the GitHub provider. </summary>
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
    }
}