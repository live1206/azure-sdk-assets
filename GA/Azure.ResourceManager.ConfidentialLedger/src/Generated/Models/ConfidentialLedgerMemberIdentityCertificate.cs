// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Object representing MemberIdentityCertificate for Managed CCF. </summary>
    public partial class ConfidentialLedgerMemberIdentityCertificate
    {
        /// <summary> Initializes a new instance of ConfidentialLedgerMemberIdentityCertificate. </summary>
        public ConfidentialLedgerMemberIdentityCertificate()
        {
        }

        /// <summary> Initializes a new instance of ConfidentialLedgerMemberIdentityCertificate. </summary>
        /// <param name="certificate"> Member Identity Certificate. </param>
        /// <param name="encryptionkey"> Member Identity Certificate Encryption Key. </param>
        /// <param name="tags"> Anything. </param>
        internal ConfidentialLedgerMemberIdentityCertificate(string certificate, string encryptionkey, BinaryData tags)
        {
            Certificate = certificate;
            Encryptionkey = encryptionkey;
            Tags = tags;
        }

        /// <summary> Member Identity Certificate. </summary>
        public string Certificate { get; set; }
        /// <summary> Member Identity Certificate Encryption Key. </summary>
        public string Encryptionkey { get; set; }
        /// <summary>
        /// Anything
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
        public BinaryData Tags { get; set; }
    }
}