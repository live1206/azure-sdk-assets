// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> SSL certificates of an application gateway. </summary>
    public partial class ApplicationGatewaySslCertificate : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewaySslCertificate. </summary>
        public ApplicationGatewaySslCertificate()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewaySslCertificate. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="data"> Base-64 encoded pfx certificate. Only applicable in PUT Request. </param>
        /// <param name="password"> Password for the pfx file specified in data. Only applicable in PUT request. </param>
        /// <param name="publicCertData"> Base-64 encoded Public cert data corresponding to pfx specified in data. Only applicable in GET request. </param>
        /// <param name="keyVaultSecretId"> Secret Id of (base-64 encoded unencrypted pfx) 'Secret' or 'Certificate' object stored in KeyVault. </param>
        /// <param name="provisioningState"> The provisioning state of the SSL certificate resource. </param>
        internal ApplicationGatewaySslCertificate(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, BinaryData data, string password, BinaryData publicCertData, string keyVaultSecretId, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            Data = data;
            Password = password;
            PublicCertData = publicCertData;
            KeyVaultSecretId = keyVaultSecretId;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary>
        /// Base-64 encoded pfx certificate. Only applicable in PUT Request.
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
        public BinaryData Data { get; set; }
        /// <summary> Password for the pfx file specified in data. Only applicable in PUT request. </summary>
        public string Password { get; set; }
        /// <summary>
        /// Base-64 encoded Public cert data corresponding to pfx specified in data. Only applicable in GET request.
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
        public BinaryData PublicCertData { get; }
        /// <summary> Secret Id of (base-64 encoded unencrypted pfx) 'Secret' or 'Certificate' object stored in KeyVault. </summary>
        public string KeyVaultSecretId { get; set; }
        /// <summary> The provisioning state of the SSL certificate resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}