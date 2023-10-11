// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active Directory app registration. </summary>
    public partial class AppServiceAadRegistration
    {
        /// <summary> Initializes a new instance of AppServiceAadRegistration. </summary>
        public AppServiceAadRegistration()
        {
        }

        /// <summary> Initializes a new instance of AppServiceAadRegistration. </summary>
        /// <param name="openIdIssuer">
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </param>
        /// <param name="clientId">
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </param>
        /// <param name="clientSecretSettingName"> The app setting name that contains the client secret of the relying party application. </param>
        /// <param name="clientSecretCertificateThumbprintString">
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </param>
        /// <param name="clientSecretCertificateSubjectAlternativeName">
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </param>
        /// <param name="clientSecretCertificateIssuer">
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </param>
        internal AppServiceAadRegistration(string openIdIssuer, string clientId, string clientSecretSettingName, string clientSecretCertificateThumbprintString, string clientSecretCertificateSubjectAlternativeName, string clientSecretCertificateIssuer)
        {
            OpenIdIssuer = openIdIssuer;
            ClientId = clientId;
            ClientSecretSettingName = clientSecretSettingName;
            ClientSecretCertificateThumbprintString = clientSecretCertificateThumbprintString;
            ClientSecretCertificateSubjectAlternativeName = clientSecretCertificateSubjectAlternativeName;
            ClientSecretCertificateIssuer = clientSecretCertificateIssuer;
        }

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        public string OpenIdIssuer { get; set; }
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        public string ClientId { get; set; }
        /// <summary> The app setting name that contains the client secret of the relying party application. </summary>
        public string ClientSecretSettingName { get; set; }
        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        public string ClientSecretCertificateThumbprintString { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        public string ClientSecretCertificateSubjectAlternativeName { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        public string ClientSecretCertificateIssuer { get; set; }
    }
}
