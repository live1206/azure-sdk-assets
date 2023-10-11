// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The CertificateVerificationCodeProperties. </summary>
    public partial class CertificateVerificationCodeProperties
    {
        /// <summary> Initializes a new instance of CertificateVerificationCodeProperties. </summary>
        internal CertificateVerificationCodeProperties()
        {
        }

        /// <summary> Initializes a new instance of CertificateVerificationCodeProperties. </summary>
        /// <param name="verificationCode"> Verification code. </param>
        /// <param name="subject"> Certificate subject. </param>
        /// <param name="expireOn"> Code expiry. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="isVerified"> Indicate if the certificate is verified by owner of private key. </param>
        /// <param name="certificate"> base-64 representation of X509 certificate .cer file or just .pem file content. </param>
        /// <param name="createdOn"> Certificate created time. </param>
        /// <param name="updatedOn"> Certificate updated time. </param>
        internal CertificateVerificationCodeProperties(string verificationCode, string subject, DateTimeOffset? expireOn, BinaryData thumbprint, bool? isVerified, BinaryData certificate, DateTimeOffset? createdOn, DateTimeOffset? updatedOn)
        {
            VerificationCode = verificationCode;
            Subject = subject;
            ExpireOn = expireOn;
            Thumbprint = thumbprint;
            IsVerified = isVerified;
            Certificate = certificate;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
        }

        /// <summary> Verification code. </summary>
        public string VerificationCode { get; }
        /// <summary> Certificate subject. </summary>
        public string Subject { get; }
        /// <summary> Code expiry. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary>
        /// Certificate thumbprint.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Thumbprint { get; }
        /// <summary> Indicate if the certificate is verified by owner of private key. </summary>
        public bool? IsVerified { get; }
        /// <summary>
        /// base-64 representation of X509 certificate .cer file or just .pem file content.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Certificate { get; }
        /// <summary> Certificate created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Certificate updated time. </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}